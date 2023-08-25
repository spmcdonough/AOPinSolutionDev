#region Namespace Imports


using AOPinSolutionDev.Plumbing;
using System;
using System.Threading;
using PostSharp.Aspects;
using PostSharp.Serialization;


#endregion Namespace Imports


namespace AOPinSolutionDev.Aspects
{


    /// <summary>
    /// This aspect supplies automatic retry support for any method that could
    /// use it. It acts as a Method Interception Aspect, and so the aspect is
    /// called before the method it is applied to is actually called. Since we
    /// are in effect "wrapping" the method, we can seamlessly implement retry
    /// support.
    /// </summary>
    [PSerializable]
    public class RetryHandlingAspect : MethodInterceptionAspect
    {


        #region Overrides: MethodInterceptionAspect


        // The one method we care about: OnInvoke() this method wraps the
        // attributed/called method, so we can control how failure in the
        // method is handled. We'll allow a maximum of five tries with a
        // pause between each.
        public override void OnInvoke(MethodInterceptionArgs args)
        {
            const Int32 c_MaxRetries = 5;
            const Int32 c_RetryPauseInMs = 10000;
            Int32 retriesCounter = 0;

            while (true)
            {
                try
                {
                    // Execute the target method the attribute is attached to.
                    args.Proceed();
                    return;
                }
                catch
                {
                    retriesCounter++;
                    if (retriesCounter > c_MaxRetries)
                    {
                        throw;
                    }
                    else
                    {
                        LoggingSupport.WriteToLog(String.Format("Retrying operation in {0} ms. Retries remaining = {1}", c_RetryPauseInMs,(c_MaxRetries - retriesCounter)), 3);
                        LoggingSupport.LoggingTextBox.Refresh();
                        Thread.Sleep(c_RetryPauseInMs);
                    }
                }
            }
        }


        #endregion Overrides: MethodInterceptionAspect


    }


}
