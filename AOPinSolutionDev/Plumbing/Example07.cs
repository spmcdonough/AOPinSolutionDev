#region Namespace Imports


using AOPinSolutionDev.Aspects;
using System;


#endregion Namespace Imports


namespace AOPinSolutionDev.Plumbing
{


    
    internal class Example07
    {


        #region Constructors


        public Example07() {}


        #endregion Constructors


        #region "Business Logic" Methods


        [RetryHandlingAspect(AspectPriority = 4), ExceptionHandlingAspect(AspectPriority = 1), TimingAspect(AspectPriority = 2), LoggingToTextboxAspect(AspectPriority = 3)]
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
