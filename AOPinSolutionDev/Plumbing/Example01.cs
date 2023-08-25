namespace AOPinSolutionDev.Plumbing
{


    internal class Example01
    {


        #region Constructors


        public Example01() {}


        #endregion Constructors


        #region "Business Logic" Methods


        // Imagine these methods simulating complex business operations -
        // even though here they're simply writing lines out to the log.
        private void OperationNo1()
        {
            LoggingSupport.WriteToLog("It is by caffeine alone I set my mind in motion,\r\n");
        }

        private void OperationNo2()
        {
            LoggingSupport.WriteToLog("it is by the beans of java that the mind acquires speed,\r\n");
        }

        private void OperationNo3()
        {
            LoggingSupport.WriteToLog("the hands acquire shaking, the shaking becomes a warning;\r\n");
        }

        private void OperationNo4()
        {
            LoggingSupport.WriteToLog("it is by caffeine alone I set my mind in motion.\r\n");
        }

        public void OrchestrateBusinessProcess()
        {
            OperationNo1();
            OperationNo2();
            OperationNo3();
            OperationNo4();
        }


        #endregion "Business Logic" Methods


    }


}
