#region Namespace Imports


using Metalama.Framework.Aspects;
using MetalamaBaby.Forms;
using System.Diagnostics;


#endregion Namespace Imports


namespace MetalamaBaby.Aspects
{


    public class MethodTimingAspectAttribute : OverrideMethodAspect
    {


        /// <summary>
        /// Here is another OverrideMethodAspect that can tell us how long it takes
        /// the method it's attached to to run from start to finish. We implemented
        /// it as a OnMethodBoundaryAspect in the PostSharp project, but we're using
        /// an alternate approach with Metalama.
        /// </summary>
        public override dynamic? OverrideMethod()
        {
            MainForm mainFormRef = Form.ActiveForm as MainForm;
            if (null != mainFormRef)
            {
                mainFormRef.WriteToStatusBox("Aspect: Begin stopwatch for method timing.", 1);
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                meta.Proceed();
                stopWatch.Stop();
                var elapsedMS = stopWatch.ElapsedMilliseconds;
                mainFormRef.WriteToStatusBox($"Aspect: {meta.Target.Method} took {elapsedMS} milliseconds to run.", 1);
            }
            return null;
        }
    }
}
