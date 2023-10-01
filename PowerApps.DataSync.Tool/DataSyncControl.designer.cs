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
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.ssMainLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpSource = new System.Windows.Forms.GroupBox();
            this.llViewSource = new System.Windows.Forms.LinkLabel();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.grpTarget = new System.Windows.Forms.GroupBox();
            this.llCopyFromSource = new System.Windows.Forms.LinkLabel();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.llViewTargetRecord = new System.Windows.Forms.LinkLabel();
            this.gbConnections.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.grpSource.SuspendLayout();
            this.grpTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvResults
            // 
            this.tvResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvResults.Location = new System.Drawing.Point(3, 91);
            this.tvResults.Name = "tvResults";
            this.tvResults.Size = new System.Drawing.Size(569, 511);
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
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(6, 19);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
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
            // grpSource
            // 
            this.grpSource.Controls.Add(this.llViewSource);
            this.grpSource.Controls.Add(this.txtSource);
            this.grpSource.Location = new System.Drawing.Point(578, 91);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(498, 245);
            this.grpSource.TabIndex = 5;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "Source";
            // 
            // llViewSource
            // 
            this.llViewSource.AutoSize = true;
            this.llViewSource.Enabled = false;
            this.llViewSource.Location = new System.Drawing.Point(7, 20);
            this.llViewSource.Name = "llViewSource";
            this.llViewSource.Size = new System.Drawing.Size(30, 13);
            this.llViewSource.TabIndex = 1;
            this.llViewSource.TabStop = true;
            this.llViewSource.Text = "View";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(6, 36);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(486, 203);
            this.txtSource.TabIndex = 0;
            // 
            // grpTarget
            // 
            this.grpTarget.Controls.Add(this.llViewTargetRecord);
            this.grpTarget.Controls.Add(this.llCopyFromSource);
            this.grpTarget.Controls.Add(this.txtTarget);
            this.grpTarget.Location = new System.Drawing.Point(578, 342);
            this.grpTarget.Name = "grpTarget";
            this.grpTarget.Size = new System.Drawing.Size(498, 260);
            this.grpTarget.TabIndex = 6;
            this.grpTarget.TabStop = false;
            this.grpTarget.Text = "Target";
            // 
            // llCopyFromSource
            // 
            this.llCopyFromSource.AutoSize = true;
            this.llCopyFromSource.Enabled = false;
            this.llCopyFromSource.Location = new System.Drawing.Point(43, 25);
            this.llCopyFromSource.Name = "llCopyFromSource";
            this.llCopyFromSource.Size = new System.Drawing.Size(91, 13);
            this.llCopyFromSource.TabIndex = 3;
            this.llCopyFromSource.TabStop = true;
            this.llCopyFromSource.Text = "Copy from Source";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(6, 41);
            this.txtTarget.Multiline = true;
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.ReadOnly = true;
            this.txtTarget.Size = new System.Drawing.Size(486, 213);
            this.txtTarget.TabIndex = 1;
            // 
            // llViewTargetRecord
            // 
            this.llViewTargetRecord.AutoSize = true;
            this.llViewTargetRecord.Enabled = false;
            this.llViewTargetRecord.Location = new System.Drawing.Point(7, 25);
            this.llViewTargetRecord.Name = "llViewTargetRecord";
            this.llViewTargetRecord.Size = new System.Drawing.Size(30, 13);
            this.llViewTargetRecord.TabIndex = 4;
            this.llViewTargetRecord.TabStop = true;
            this.llViewTargetRecord.Text = "View";
            // 
            // DataSyncControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpTarget);
            this.Controls.Add(this.grpSource);
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
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.grpTarget.ResumeLayout(false);
            this.grpTarget.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpSource;
        private System.Windows.Forms.GroupBox grpTarget;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.LinkLabel llViewSource;
        private System.Windows.Forms.LinkLabel llCopyFromSource;
        private System.Windows.Forms.LinkLabel llViewTargetRecord;
    }
}
