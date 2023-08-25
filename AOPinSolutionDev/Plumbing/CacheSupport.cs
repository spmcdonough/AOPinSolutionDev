#region Namespace Imports


using System;
using System.Collections.Generic;


#endregion Namespace Imports


namespace AOPinSolutionDev.Plumbing
{


    // This class is used to simulate a persistent cache in the environment.
    // For web projects, this may be the ASP.NET cache; for other systems,
    // something like Redis may be more appropriate. 
    internal class CacheSupport
    {


        private static Dictionary<String, Object> _cacheDictionary = new Dictionary<String, Object>();


        #region Methods


        public static void Add(String keyName, Object value)
        {
            _cacheDictionary.Add(keyName, value);
        }


        public static Object Get(String keyName)
        {
            Object returnValue = null;
            _cacheDictionary.TryGetValue(keyName, out returnValue);
            return returnValue;
        }


        #endregion Methods


    }
}
