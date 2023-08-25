#region Namespace Imports


using AOPinSolutionDev.Plumbing;
using PostSharp.Aspects;
using PostSharp.Serialization;
using System;


#endregion Namespace Imports


namespace AOPinSolutionDev.Aspects
{

    
    /// <summary>
    /// This method boundary aspect (created with PostSharp) is responsible 
    /// for handling logging activities for each of the methods with which 
    /// it is associated.
    /// </summary>
    [PSerializable]
    internal class LoggingToTextboxAspect : OnMethodBoundaryAspect
    {


        #region Overrides: OnMethodBoundaryAspect


        /// <summary>
        /// The OnEntry method fires on the join point that occurs just before
        /// a method is entered and its first lines of code are executed.
        /// </summary>
        public override void OnEntry(MethodExecutionArgs args)
        {
            CreateLogEntry(args, "Entering Method");
        }


        /// <summary>
        /// The OnExit method fires on the join point that occurs just after
        /// a method is exited and its execution is complete.
        /// </summary>
        public override void OnExit(MethodExecutionArgs args)
        {
            CreateLogEntry(args, "Exiting Method");
        }


        #endregion Overrides: OnMethodBoundaryAspect


        /// <summary>
        /// This method contains the logic that determines what should be written
        /// to the log, if anything. It analyzes the method that is being (or was 
        /// just) called, parameters that are being (or were) passed, etc., and
        /// creates log text based on those values.
        /// </summary>
        private void CreateLogEntry(MethodExecutionArgs args, String action)
        {
            // We'll use depth to determine if this is firing for a method that
            // should be logged.
            Int32 depth = 2;

            // What is the name of the method that we're entering/exiting?
            String methodName = args.Method.Name;

            // We'll use the name of the method to determine the depth of the log
            // entry to be written.
            if (methodName.Contains("Orchestrate"))
            {
                depth = 0;
            }
            else if (methodName.Contains("OperationNo"))
            {
                depth = 1;
            }
            else if (methodName.Contains(".ctor"))
            {
                depth = -1;
            }

            // Provided we have a depth greater than zero (i.e., we recognize the
            // current method as one for which we want to log entry/exit), we'll go
            // ahead and log the action and name of the method we're in.
            if (depth > -1)
            {
                String logMessage = action + " " + methodName;
                LoggingSupport.WriteToLog(logMessage, depth);
            }
        }


    }
}
