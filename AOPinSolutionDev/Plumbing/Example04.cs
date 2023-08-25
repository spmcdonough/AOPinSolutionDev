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
