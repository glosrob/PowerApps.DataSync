using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using PowerApps.DataSync.Tool.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerApps.DataSync.Tool.Data
{
    /// <summary>
    /// Retrieves data from the connected Dataverse instance.
    /// </summary>
    internal class DataSyncData
    {
        // Constructors

        /// <summary>
        /// Default contructor.
        /// </summary>
        public DataSyncData()
        {

        }

        // Properties

        private IOrganizationService Service { get; set; }

        private ConnectionDetail ConnDetail { get; set; }

        // Methods

        internal string OrgName => ConnDetail == null ? "" : ConnDetail.ConnectionName;

        internal bool IsConnected => ConnDetail != null;

        internal void SetDetails(IOrganizationService source, ConnectionDetail sourceDetail)
        {
            Service = source;
            ConnDetail = sourceDetail;
        }

        internal List<Entity> GetRecords(TableConfig config)
        {
            var fetchXml = $"<fetch nolock='true'>";
            fetchXml += $"<entity name='{config.Schema}'>";
            foreach(var field in config.Fields)
            {
                fetchXml += $"<attribute name='{field}' />";
            }
            if (!string.IsNullOrEmpty(config.Filter))
            {
                fetchXml += config.Filter;
            }
            fetchXml += "</entity>";
            fetchXml += "</fetch>";

            var query = new FetchExpression(fetchXml);
            var results = Service.RetrieveMultiple(query).Entities;

            return results.ToList() ?? new List<Entity>();
        }
    }
}
