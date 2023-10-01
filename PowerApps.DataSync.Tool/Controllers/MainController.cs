using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using PowerApps.DataSync.Tool.Data;
using PowerApps.DataSync.Tool.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        private ISyncIssue SelectedIssue { get; set; }

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
                        DisplayAttribute = "xrt_name",
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

            await Task.Run(() =>
            {
                var total = Config.Count;
                var ctr = 0;
                foreach (var config in Config)
                {
                    try
                    {
                        ctr++;
                        DataSync.UpdateStatus($"Checking {config.Name} - retrieving records");
                        var sourceRecords = Source.GetRecords(config);
                        var targetRecords = Target.GetRecords(config);

                        var allIssues = new List<ISyncIssue>();
                        DataSync.UpdateStatus($"Checking {config.Name} - comparing {ctr} of {total}");
                        var comparer = new TableComparer
                        {
                            SourceConfig = config,
                            SourceRecords = sourceRecords,
                            TargetRecords = targetRecords
                        };
                        allIssues.AddRange(comparer.CheckForIssues());
                        allIssues = allIssues
                            .OrderBy(x => x.Config.Name)
                            .ThenBy(x => x.SourceDisplay)
                            .ToList();

                        DataSync.DisplayIssues(allIssues);
                    }
                    catch (Exception ex)
                    {
                        DataSync.UpdateStatus($"Error checking for sync issues for {config.Name} ({ex.Message} [{ex.GetType().Name}])");
                        break;
                    }
                }
            });
        }

        internal void IssueClicked(ISyncIssue issue)
        {
            SelectedIssue = issue;
            if (issue == null)
            {
                DataSync.ResetSelectedIssue();
            }
            else
            {
                DataSync.DisplayIssueDetails(issue);
            }
        }

        internal void OpenTarget()
        {
            if (SelectedIssue == null)
            {
                return;
            }

            var url = $"{Target.OrgUrl}/main.aspx?etn={SelectedIssue.Config.Schema}&pagetype=entityrecord&id={SelectedIssue.TargetId}";
            Process.Start(url);
        }

        internal void OpenSource()
        {
            if (SelectedIssue == null)
            {
                return;
            }

            var url = $"{Source.OrgUrl}/main.aspx?etn={SelectedIssue.Config.Schema}&pagetype=entityrecord&id={SelectedIssue.SourceId}";
            Process.Start(url);
        }
    }
}
