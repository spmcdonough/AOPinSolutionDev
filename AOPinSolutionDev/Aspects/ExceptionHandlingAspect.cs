#region Namespace Imports


using PostSharp.Aspects;
using PostSharp.Serialization;


#endregion Namespace Imports


namespace AOPinSolutionDev.Aspects
{
    
    
    /// <summary>
    /// This method interception aspect can be used to add "automatic"
    /// exception handling to a method. When a method is set up to use
    /// this aspect, the method is wrapped in an exception handler that
    /// prevents exceptions from bubbling-up. Any trapped exception is
    /// also written to the log window.
    /// </summary>
    [PSerializable]
    public class ExceptionHandlingAspect : OnExceptionAspect
    {


        #region Overrides: OnExceptionAspect 


        /// <summary>
        /// Whenever a OnExceptionAspect is applied to a method,
        /// execution of that method that happens to generate and exception
        /// will first be handled by the attached aspect. This give us the
        /// possibility to retry, correct the problem, and even "eat" the
        /// exception.
        /// </summary>
        public override void OnException(MethodExecutionArgs args)
        {
            // This particular exception handler is assigned for ICNDB use ...
            // so pass back a constructed Chuck Norris fact.
            args.FlowBehavior = FlowBehavior.Return;
            args.ReturnValue = "When Chuck Norris calls a web service, the " +
                               "network connection is optional. The service still replies.\r\n";
        }


        #endregion Overrides : OnExceptionAspect


    }
}
