using Microsoft.Xrm.Sdk;
using System.Collections.Generic;

namespace PowerApps.DataSync.Tool.Models
{
    internal class TableComparer
    {
        // Properties

        internal TableConfig SourceConfig { get; set; }

        internal List<Entity> SourceRecords { get; set; }

        internal List<Entity> TargetRecords { get; set; }

        // Methods

        internal List<ISyncIssue> CheckForIssues()
        {
            var issues = new List<ISyncIssue>();

            foreach(var sourceRecord in SourceRecords)
            {
                var targetRecord = RecordMatcher.FindEntity(sourceRecord, TargetRecords);
                if (targetRecord == null)
                {
                    issues.Add(ISyncIssue.CreateMissingInTargetIssue(SourceConfig, sourceRecord));
                    continue;
                }

                foreach(var field in SourceConfig.Fields)
                {
                    var matches = ValueComparer.Compare(sourceRecord, targetRecord, field);
                    if (!matches)
                    {
                        issues.Add(ISyncIssue.CreateValuesDoNotMatch(SourceConfig, field, sourceRecord, targetRecord));
                    }
                }
            }
            return issues;
        }
    }
}
