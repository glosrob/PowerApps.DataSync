using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using PowerApps.DataSync.Tool.Data;
using PowerApps.DataSync.Tool.Models;
using System.Collections.Generic;

namespace PowerApps.DataSync.Tool.Controllers
{
    /// <summary>
    /// Takes care of react to form events and calling data layer to retrieve data.
    /// </summary>
    internal class MainController
    {
        // Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="powerFind">The form that the controller is orchestrating.</param>
        /// <param name="worker">Reference to the async worker to use for data operations.</param>
        internal MainController(DataSyncControl view)
        {
            DataSync = view;
            Source = new DataSyncData();
            Target = new DataSyncData();

            // Temp for testing
            Config = new List<TableConfig>();
            Config.Add(new TableConfig
            {
                Fields = new List<string> { "xrt_name", "xrt_value", "xrt_ishtml" },
            });
        }

        // Properties

        private DataSyncControl DataSync { get; set; }

        private DataSyncData Source { get; set; }

        private DataSyncData Target { get; set; }

        private Settings AppSettings { get; set; }

        private List<TableConfig> Config { get; set; }

        internal bool SourceIsConnected => Source.IsSourceConnected;

        internal bool TargetIsConnected => Target.IsSourceConnected;

        // Methods

        internal void Load(Settings appSettings)
        {
            AppSettings = appSettings;
        }

        internal void SetSource(ConnectionDetail detail, IOrganizationService newService)
        {
            Source.SetDetails(newService, detail);
            DataSync.SetSourceDetails(Source.OrgName);
        }

        internal void SetTarget(ConnectionDetail detail, IOrganizationService newService)
        {
            Target.SetDetails(newService, detail);
            DataSync.SetTargetDetails(Target.OrgName);
        }

        internal void Go()
        {

        }
    }
}
