#region Namespace Imports


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOPinSolutionDev.Aspects;

#endregion Namespace Imports


namespace AOPinSolutionDev.Plumbing
{


    
    internal class Example07
    {


        #region Constructors


        public Example07() {}


        #endregion Constructors


        #region "Business Logic" Methods


        [RetryHandlingAspect(AspectPriority = 2), ExceptionHandlingAspect(AspectPriority = 1), TimingAspect(AspectPriority = 1), LoggingToTextboxAspect(AspectPriority = 1)]
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
