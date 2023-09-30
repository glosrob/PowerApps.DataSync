using Microsoft.Xrm.Sdk;

namespace PowerApps.DataSync.Tool.Models
{
    static internal class ValueComparer
    {
        static internal bool Compare(Entity source, Entity target, string attributeName)
        {
            if (!source.Contains(attributeName) && !target.Contains(attributeName))
            {
                return true;
            }

            var sourceDisplay = source.GetDisplayValue(attributeName);
            var targetDisplay = target.GetDisplayValue(attributeName);
            return sourceDisplay == targetDisplay;
        }
    }
}
