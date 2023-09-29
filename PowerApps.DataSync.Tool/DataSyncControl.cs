using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using PowerApps.DataSync.Tool.Controllers;
using PowerApps.DataSync.Tool.Models;
using System;
using System.Collections.Specialized;
using XrmToolBox.Extensibility;

namespace PowerApps.DataSync.Tool
{
    public partial class DataSyncControl : MultipleConnectionsPluginControlBase
    {
        // Controllers

        /// <summary>
        /// Default controller.
        /// </summary>
        public DataSyncControl()
        {
            InitializeComponent();

            // Pass the WorkAsync helper back to the controller
            // This lets us keep data access away from the view.
            Controller = new MainController(this);

            // When the control loads, check for settings
            this.Load += delegate (object sender, EventArgs e)
            {
                if (!SettingsManager.Instance.TryLoad(GetType(), out AppSettings))
                {
                    AppSettings = new Settings();
                }
                Controller.Load(AppSettings);

                // Event handlers - buttons
                btnSource.Click += BtnSource_Click;
                btnTarget.Click += BtnTarget_Click;
                btnGo.Click += BtnGo_Click; ;
            };
        }

        // Properties

        private MainController Controller { get; set; }

        private Settings AppSettings;

        // Methods

        /// <summary>
        /// Called when the user changes the connection - ask the controller to handle.
        /// </summary>
        /// <param name="newService">The new service that has been connected to.</param>
        /// <param name="detail">The detail of the connection made.</param>
        /// <param name="actionName">The action taken.</param>
        /// <param name="parameter">Additional parameters.</param>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            if (actionName == "AdditionalOrganization")
            {
                Controller.SetTarget(detail, newService);
            }
            else
            {
                Controller.SetSource(detail, newService);
            }
        }

        private void BtnSource_Click(object sender, EventArgs e)
        {
            base.RaiseRequestConnectionEvent(new RequestConnectionEventArgs
            {
                ActionName = "BtnSource_Click",
                Control = this
            });
        }

        private void BtnTarget_Click(object sender, EventArgs e)
        {
            AddAdditionalOrganization();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            btnGo.Invoke(() =>
            {
                Controller.Go();
            });
        }

        // Form Methods

        protected override void ConnectionDetailsUpdated(NotifyCollectionChangedEventArgs e)
        {

        }

        internal void SetSourceDetails(string name)
        {
            lblSource.Invoke(() =>
            {
                lblSource.Text = name;
            });
        }

        internal void SetTargetDetails(string name)
        {
            lblTarget.Invoke(() =>
            {
                lblTarget.Text = name;
            });
        }

        //private void MyPluginControl_Load(object sender, EventArgs e)
        //{
        //    ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

        //    // Loads or creates the settings for the plugin
        //    if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
        //    {
        //        mySettings = new Settings();

        //        LogWarning("Settings not found => a new settings file has been created!");
        //    }
        //    else
        //    {
        //        LogInfo("Settings found and loaded");
        //    }
        //}

        //private void tsbClose_Click(object sender, EventArgs e)
        //{
        //    CloseTool();
        //}

        //private void tsbSample_Click(object sender, EventArgs e)
        //{
        //    // The ExecuteMethod method handles connecting to an
        //    // organization if XrmToolBox is not yet connected
        //    ExecuteMethod(GetAccounts);
        //}

        //private void GetAccounts()
        //{
        //    WorkAsync(new WorkAsyncInfo
        //    {
        //        Message = "Getting accounts",
        //        Work = (worker, args) =>
        //        {
        //            args.Result = Service.RetrieveMultiple(new QueryExpression("account")
        //            {
        //                TopCount = 50
        //            });
        //        },
        //        PostWorkCallBack = (args) =>
        //        {
        //            if (args.Error != null)
        //            {
        //                MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            var result = args.Result as EntityCollection;
        //            if (result != null)
        //            {
        //                MessageBox.Show($"Found {result.Entities.Count} accounts");
        //            }
        //        }
        //    });
        //}

        ///// <summary>
        ///// This event occurs when the plugin is closed
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        //{
        //    // Before leaving, save the settings
        //    SettingsManager.Instance.Save(GetType(), mySettings);
        //}

        ///// <summary>
        ///// This event occurs when the connection has been updated in XrmToolBox
        ///// </summary>
        //public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        //{
        //    base.UpdateConnection(newService, detail, actionName, parameter);

        //    if (mySettings != null && detail != null)
        //    {
        //        mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
        //        LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
        //    }
        //}
    }
}