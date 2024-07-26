#region Namespace Imports

using System.Reflection.Metadata.Ecma335;
using MetalamaBaby.Forms;
using Metalama.Framework.Aspects;


#endregion Namespace Imports


namespace MetalamaBaby.Aspects
{


    /// <summary>
    /// Metalama's way of implementing aspects is a bit different than PostSharp's.
    /// The end result is roughly the same, but it's the implementation details that
    /// are the most interesting.
    /// </summary>
    public class LoggingToStatusTextBoxAttribute : OverrideMethodAspect
    {


        /// <summary>
        /// Like the OnMethodInterceptionAspect of PostSharp, Metalama's OverrideMethod()
        /// is where our aspect gets implemented. We still attach the aspect to a method
        /// with an attribute at the method, class, or assembly level. Everything else is
        /// different and cool to see in action.
        /// </summary>
        public override dynamic? OverrideMethod()
        {
            MainForm mainFormRef = Form.ActiveForm as MainForm;
            if (null != mainFormRef) {
                Int32 depth = 2;
                String messageToReturn = $"Aspect reports: entering {meta.Target.Method} method.";
                if (meta.Target.Method.ToString().Contains("TopLevel"))
                {
                    depth = 1;
                }
                mainFormRef.WriteToStatusBox(String.Empty, depth);
                mainFormRef.WriteToStatusBox(messageToReturn, depth);
                try
                {
                    var result = meta.Proceed();
                    mainFormRef.WriteToStatusBox($"Aspect reports: the call to {meta.Target.Method} succeeded without issue.", depth);
                }
                catch (Exception ex)
                {
                        mainFormRef.WriteToStatusBox($"Aspect reports: the call to {meta.Target.Method} resulted in an exception: " + ex.Message, depth);
                        // Logic to handle the exception would go here.
                        meta.Return();
                }
            }
            return null;
        }
    }
}
