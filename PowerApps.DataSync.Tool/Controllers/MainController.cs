using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using PowerApps.DataSync.Tool.Data;
using PowerApps.DataSync.Tool.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            Config = new List<TableConfig>();
        }

        // Properties

        private DataSyncControl DataSync { get; set; }

        private DataSyncData Source { get; set; }

        private DataSyncData Target { get; set; }

        private Settings AppSettings { get; set; }

        private List<TableConfig> Config { get; set; }

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

        internal async Task LoadConfig()
        {
            await Task.Run(() =>
            {
                Config = new List<TableConfig>
                {
                    new TableConfig
                    {
                        Fields = new List<string> { "xrt_name", "xrt_value", "xrt_ishtml" },
                        Filter = "<filter type=\"and\"><condition attribute=\"statuscode\" operator=\"eq\" value=\"1\" /></filter>",
                        IdAttribute = "xrt_portalcontentid",
                        Schema = "xrt_portalcontent",
                        Name = "Portal Content",
                        Order = 1,
                        PrimaryField = "xrt_name",
                        SyncAttribute = "xrt_portalcontentid"
                    }
                };
                DataSync.DisplayConfigs(Config);
            });
        }

        internal async Task Go()
        {
            if (!Source.IsConnected || !Target.IsConnected)
            {
                DataSync.UpdateStatus($"You need to connect to a source and target environment.");
                return;
            }

            foreach(var config in Config)
            {
                try
                {
                    await Task.Run(() =>
                    {
                        DataSync.UpdateStatus($"Checking {config.Name} - retrieving records");
                        var sourceRecords = Source.GetRecords(config);
                        var targetRecords = Target.GetRecords(config);

                        var total = sourceRecords.Count;
                        var ctr = 0;
                        foreach(var sourceRecord in sourceRecords)
                        {
                            ctr++;
                            DataSync.UpdateStatus($"Checking {config.Name} - comparing {ctr} of {total}");


                        }
                    });
                }
                catch (Exception ex)
                {
                    DataSync.UpdateStatus($"Error checking for sync issues for {config.Name} ({ex.Message} [{ex.GetType().Name}])");
                }
            }
        }
    }
}
