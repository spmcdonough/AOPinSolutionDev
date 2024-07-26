#region Namespace Imports


using MetalamaBaby.Forms;
using MetalamaBaby.Plumbing;
using Metalama.Framework.Aspects;
using System;
using System.Runtime.CompilerServices;

#endregion Namespace Imports


namespace MetalamaBaby.Aspects
{


    /// <summary>
    /// Metalama's way of implementing aspects is a bit different than PostSharp's.
    /// The end result is roughly the same, but it's the implementation details that
    /// are the most interesting.
    /// </summary>
    internal class LoggingToStatusTextBoxAttribute: OverrideMethodAspect
    {


        /// <summary>
        /// Like the OnMethodBoundaryAspect of PostSharp, Metalama's OverrideMethod()
        /// is where our aspect gets implemented. We still attach the aspect to a method
        /// with an attribute at the method, class, or assembly level. Everything else is
        /// different and cool to see in action.
        /// </summary>
        public override dynamic? OverrideMethod()
        {
            Int32 depth = 2;
            StatusBoxSupport statusBoxRef = MainForm.StatusBoxSupportRef;
            statusBoxRef.WriteToStatusBox($"Entering {meta.Target.Method} method.");
            if (meta.Target.Method.ToString().Contains("TopLevel"))
            {
                depth = 0;
            }
            else if (meta.Target.Method.ToString().Contains("MidLevel"))
            {
                depth = 1;
            }
            else if (meta.Target.Method.ToString().Contains("LowLevel"))
            {
                depth = 2;
            }
            else if (meta.Target.Method.ToString().Contains(".ctor"))
            {
                depth = -1;
            }
            try
            {
                var result = meta.Proceed();
                if (depth > -1)
                {
                    statusBoxRef.WriteToStatusBox($"The call to {meta.Target.Method} succeeded without issue.", depth + 1);
                }
            }
            catch
            {
                if (depth > -1)
                {
                    statusBoxRef.WriteToStatusBox($"The call to {meta.Target.Method} resulted in an exception.", depth + 1);
                }
                throw;
            }
        }
    }
}
