#region Namespace Imports


using AOPinSolutionDev.Aspects;
using System;


#endregion Namespace Imports


namespace AOPinSolutionDev.Plumbing
{


    
    internal class Example05
    {


        #region Constructors


        public Example05() {}


        #endregion Constructors


        #region "Business Logic" Methods


        [ExceptionHandlingAspect]
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
