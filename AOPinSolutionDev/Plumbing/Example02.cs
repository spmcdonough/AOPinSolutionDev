namespace AOPinSolutionDev.Plumbing
{


    internal class Example02
    {


        #region Constructors


        public Example02() {}


        #endregion Constructors


        #region "Business Logic" Methods


        // Imagine these methods simulating complex business operations -
        // even though here they're simply writing lines out to the log.
        private void OperationNo1()
        {
            LoggingSupport.WriteToLog("Entering OperationNo1()\r\n",1);
            LoggingSupport.WriteToLog("It is by caffeine alone I set my mind in motion,\r\n",2);
            LoggingSupport.WriteToLog("Exiting OperationNo1()\r\n",1);
        }

        private void OperationNo2()
        {
            LoggingSupport.WriteToLog("Entering OperationNo2()\r\n",1);
            LoggingSupport.WriteToLog("it is by the beans of java that the mind acquires speed,\r\n",2);
            LoggingSupport.WriteToLog("Exiting OperationNo2()\r\n",1);
        }

        private void OperationNo3()
        {
            LoggingSupport.WriteToLog("Entering OperationNo3()\r\n",1);
            LoggingSupport.WriteToLog("the hands acquire shaking, the shaking becomes a warning;\r\n", 2);
            LoggingSupport.WriteToLog("Exiting OperationNo3()\r\n",1);
        }

        private void OperationNo4()
        {
            LoggingSupport.WriteToLog("Entering OperationNo4()\r\n",1);
            LoggingSupport.WriteToLog("it is by caffeine alone I set my mind in motion.\r\n", 2);
            LoggingSupport.WriteToLog("Exiting OperationNo4()\r\n",1);
        }

        public void OrchestrateBusinessProcess()
        {
            LoggingSupport.WriteToLog("Entering OrchestrateBusinessProcess()\r\n", 0);
            OperationNo1();
            OperationNo2();
            OperationNo3();
            OperationNo4();
            LoggingSupport.WriteToLog("Exiting OrchestrateBusinessProcess()\r\n",0);
        }


        #endregion "Business Logic" Methods


    }


}
