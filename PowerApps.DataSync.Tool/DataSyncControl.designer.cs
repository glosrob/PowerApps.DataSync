namespace PowerApps.DataSync.Tool
{
    partial class DataSyncControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvResults = new System.Windows.Forms.TreeView();
            this.gbConnections = new System.Windows.Forms.GroupBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.btnTarget = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnSource = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.ssMainLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbConnections.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvResults
            // 
            this.tvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvResults.Location = new System.Drawing.Point(3, 91);
            this.tvResults.MinimumSize = new System.Drawing.Size(300, 4);
            this.tvResults.Name = "tvResults";
            this.tvResults.Size = new System.Drawing.Size(300, 511);
            this.tvResults.TabIndex = 1;
            // 
            // gbConnections
            // 
            this.gbConnections.Controls.Add(this.lblTarget);
            this.gbConnections.Controls.Add(this.btnTarget);
            this.gbConnections.Controls.Add(this.lblSource);
            this.gbConnections.Controls.Add(this.btnSource);
            this.gbConnections.Location = new System.Drawing.Point(3, 3);
            this.gbConnections.Name = "gbConnections";
            this.gbConnections.Size = new System.Drawing.Size(357, 82);
            this.gbConnections.TabIndex = 2;
            this.gbConnections.TabStop = false;
            this.gbConnections.Text = "Connections";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(54, 50);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(202, 13);
            this.lblTarget.TabIndex = 4;
            this.lblTarget.Text = "Please connect to the target environment";
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(6, 45);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(42, 23);
            this.btnTarget.TabIndex = 5;
            this.btnTarget.Text = "To";
            this.btnTarget.UseVisualStyleBackColor = true;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(54, 24);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(207, 13);
            this.lblSource.TabIndex = 3;
            this.lblSource.Text = "Please connect to the source environment";
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(6, 19);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(42, 23);
            this.btnSource.TabIndex = 3;
            this.btnSource.Text = "From";
            this.btnSource.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.btnConfig);
            this.gbOptions.Controls.Add(this.btnGo);
            this.gbOptions.Location = new System.Drawing.Point(366, 3);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(206, 82);
            this.gbOptions.TabIndex = 3;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(6, 45);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Start";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(6, 19);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssMainLabel});
            this.ssMain.Location = new System.Drawing.Point(0, 605);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1079, 22);
            this.ssMain.TabIndex = 4;
            this.ssMain.Text = "statusStrip1";
            // 
            // ssMainLabel
            // 
            this.ssMainLabel.Name = "ssMainLabel";
            this.ssMainLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // DataSyncControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbConnections);
            this.Controls.Add(this.tvResults);
            this.Name = "DataSyncControl";
            this.Size = new System.Drawing.Size(1079, 627);
            this.gbConnections.ResumeLayout(false);
            this.gbConnections.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView tvResults;
        private System.Windows.Forms.GroupBox gbConnections;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel ssMainLabel;
    }
}
