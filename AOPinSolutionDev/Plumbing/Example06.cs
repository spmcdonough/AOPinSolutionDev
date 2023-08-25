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
