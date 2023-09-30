using Microsoft.Xrm.Sdk;
using System.Collections.Generic;

namespace PowerApps.DataSync.Tool.Models
{
    static internal class RecordMatcher
    {
        static internal Entity FindEntity(Entity sourceRecord, List<Entity> targetRecords)
        {
            foreach (var targetRecord in targetRecords)
            {
                if (sourceRecord.Id == targetRecord.Id)
                {
                    return targetRecord;
                }
            }
            return null;
        }
    }
}
