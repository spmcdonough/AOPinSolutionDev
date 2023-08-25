#region Namespace Imports


using AOPinSolutionDev.Aspects;
using System;


#endregion Namespace Imports


namespace AOPinSolutionDev.Plumbing
{


    
    internal class Example04
    {


        #region Constructors


        public Example04() {}


        #endregion Constructors


        #region "Business Logic" Methods


        [TimingAspect]
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
