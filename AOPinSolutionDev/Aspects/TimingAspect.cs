#region Namespace Imports


using AOPinSolutionDev.Plumbing;
using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Diagnostics;


#endregion Namespace Imports


namespace AOPinSolutionDev.Aspects
{


    /// <summary>
    /// This aspect performs simple end-to-end method execution timing using
    /// the <c>StopWatch</c> class in the System.Diagnostics namespace. A 
    /// <c>StopWatch</c> is started when the method enters, the <c>StopWatch</c>
    /// is stopped on method exit, and the time spent in the method is written
    /// to the log window.
    /// </summary>
    [PSerializable]
    public class TimingAspect : OnMethodBoundaryAspect
    {


        #region Overrides: OnMethodBoundaryAspect


        /// <summary>
        /// The OnEntry method fires on the join point that occurs just before
        /// a method is entered and its first lines of code are executed.
        /// </summary>
        public override void OnEntry(MethodExecutionArgs args)
        {
            // Start the stopwatch!
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            args.MethodExecutionTag = stopwatch;
            LoggingSupport.WriteToLog(String.Format("Stopwatch started for '{0}' method.\r\n", args.Method.Name));
        }


        /// <summary>
        /// The OnExit method fires on the join point that occurs just after
        /// a method is exited and its execution is complete.
        /// </summary>
        public override void OnExit(MethodExecutionArgs args)
        {
            var stopWatch = args.MethodExecutionTag as Stopwatch;
            stopWatch.Stop();
            LoggingSupport.WriteToLog(String.Format("Stopwatch stopped for '{0}' method. Elapsed time: {1} ms.\r\n", 
                args.Method.Name, stopWatch.ElapsedMilliseconds));
        }


        #endregion Overrides: OnMethodBoundaryAspect


    }
}
