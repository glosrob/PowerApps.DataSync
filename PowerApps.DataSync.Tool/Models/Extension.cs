using Microsoft.Xrm.Sdk;
using System;
using System.Windows.Forms;

namespace PowerApps.DataSync.Tool.Models
{
    /// <summary>
    /// Extension methods for the app.
    /// </summary>
    internal static class Extensions
    {
        /// <summary>
        /// Thread safe invocation of a method on a control.
        /// </summary>
        /// <param name="c">The control to invoke the action against.</param>
        /// <param name="a">The action to be invoked.</param>
        internal static void Invoke(this Control c, Action a)
        {
            if (c.InvokeRequired)
            {
                c.Invoke(a);
            }
            else
            {
                a.Invoke();
            }
        }

        internal static string GetDisplayValue(this Entity entity, string attributeName)
        {
            if (entity.FormattedValues.Contains(attributeName))
            {
                return entity.FormattedValues[attributeName];
            }
            if (entity.Contains(attributeName))
            {
                return entity[attributeName].ToString();
            }
            return string.Empty;
        }
    }
}
