#region Namespace Imports


using AOPinSolutionDev.Plumbing;
using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Web;


#endregion Namespace Imports


namespace AOPinSolutionDev.Aspects
{

    
    /// <summary>
    /// A Location Interception Aspect is useful for adding custom code in
    /// and around the getting and setting of properties and fields. This
    /// particular aspect is designed to fetch a property value from 
    /// "somewhere else" (with an assumed high-cost to retrieve) and hold/
    /// cache it locally once it has been retrieved.
    /// </summary>
    [PSerializable]
    public class RemoteReadOnlyPropertyAspect : LocationInterceptionAspect
    {


        // A constant we can use to build cache keys, and an object that can
        // be used for synchronization and locking.
        private const String CACHE_KEY_TEMPLATE = "LIA_RROPA_{0}";
        private Object _remotePropertyLockObject = new object();


        #region Overrides: LocationInterceptionAspect


        /// <summary>
        /// This method is invoked whenever an associated property's "get"
        /// accessor is called. We have the opportunity to carry out additional
        /// action, as well as call the actual "get"
        /// </summary>
        public override void OnGetValue(LocationInterceptionArgs args)
        {
            // Attempt to fetch the desired property from the ASP.NET Cache.
            String cacheKey = String.Format(CACHE_KEY_TEMPLATE, args.LocationName);
            Object remotePropertyValue = HttpContext.Current.Cache[cacheKey];

            // Did we get anything back?
            if (remotePropertyValue == null)
            {
                // Pause here by locking to ensure that only one caller actually makes
                // the call to retrieve the property value.
                lock (_remotePropertyLockObject)
                {
                    remotePropertyValue = HttpContext.Current.Cache[cacheKey];
                    if (remotePropertyValue == null)
                    {
                        // The property value isn't available in the Cache, so we need to
                        // fetch it, store it, and pass it back.
                        args.ProceedGetValue();
                        LoggingSupport.WriteToLog(args.LocationName + " property value fetched from source.");
                        HttpContext.Current.Cache.Insert(cacheKey, args.Value);
                    }
                    else
                    {
                        // Property wasn't initially in cache, but another thread (in ahead of the
                        // current one) populated it.
                        LoggingSupport.WriteToLog(args.LocationName + " property value fetched from ASP.NET Cache.");
                        args.Value = remotePropertyValue;                        
                    }
                }
            }
            else
            {
                // Simply assign the property value from the Cache.
                LoggingSupport.WriteToLog(args.LocationName + " property value fetched from ASP.NET Cache.");
                args.Value = remotePropertyValue;
            }
        }


        #endregion Overrides: LocationInterceptionAspect


    }
}