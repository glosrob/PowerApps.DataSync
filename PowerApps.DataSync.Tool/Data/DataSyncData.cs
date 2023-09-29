using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;

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

        internal bool IsSourceConnected => ConnDetail != null;

        internal void SetDetails(IOrganizationService source, ConnectionDetail sourceDetail)
        {
            Service = source;
            ConnDetail = sourceDetail;
        }

    }
}
