#region Namespace Imports


using AOPinSolutionDev.Aspects;
using System;


#endregion Namespace Imports


namespace AOPinSolutionDev.Plumbing
{


    
    internal class Example06
    {


        #region Constructors


        public Example06() {}


        #endregion Constructors


        #region "Business Logic" Methods


        [RetryHandlingAspect]
        private String GetJoke()
        {
            return IcndbMethods.FetchChuckNorrisJoke();
        }


        public void OrchestrateBusinessProcess()
        {
            LoggingSupport.WriteToLog(GetJoke());
        }


        #endregion "Business Logic" Methods


    }


}
