using Microsoft.Xrm.Sdk;
using System;

namespace PowerApps.DataSync.Tool.Models
{
    internal class ISyncIssue
    {
        internal Guid Id { get; set; }

        internal Guid SourceId { get; set; }

        internal Guid TargetId { get; set; }

        internal TableConfig Config { get; set; }

        internal string SourceDisplay { get; set; }

        internal string TargetDisplay { get; set; }

        internal static ISyncIssue CreateMissingInTargetIssue(TableConfig config, Entity sourceRecord)
        {
            var newIssue = new MissingInTargetIssue
            {
                Id = Guid.NewGuid(),
                SourceId = sourceRecord.Id,
                Config = config,
                SourceDisplay = sourceRecord.GetDisplayValue(config.DisplayAttribute),
                TargetDisplay = string.Empty,
            };
            return newIssue;
        }

        internal static ISyncIssue CreateValuesDoNotMatch(TableConfig config, string attributeName, Entity sourceRecord, Entity targetRecord)
        {
            var newIssue = new ValueDoesNotMatchIssue
            {
                Id = Guid.NewGuid(),
                SourceId = sourceRecord.Id,
                TargetId = targetRecord.Id,
                Config = config,
                SourceDisplay = sourceRecord.GetDisplayValue(config.DisplayAttribute),
                TargetDisplay = targetRecord.GetDisplayValue(config.DisplayAttribute),
                FieldName = attributeName,
                SourceFieldValue = sourceRecord.Contains(attributeName) ? sourceRecord[attributeName] : null,
                SourceFieldValueDisplay = sourceRecord.GetDisplayValue(attributeName),
                TargetFieldValue = targetRecord.Contains(attributeName) ? targetRecord[attributeName] : null,
                TargetFieldValueDisplay = targetRecord.GetDisplayValue(attributeName),
            };
            return newIssue;
        }

        public override string ToString()
        {
            return $"{SourceDisplay}";
        }
    }

    internal class MissingInTargetIssue : ISyncIssue
    {

    }

    internal class ValueDoesNotMatchIssue : ISyncIssue
    {
        internal string FieldName { get; set; }

        internal object SourceFieldValue { get; set; }

        internal object TargetFieldValue { get; set; }

        internal string SourceFieldValueDisplay { get; set; }
        
        internal string TargetFieldValueDisplay { get; set; }
    }
}
