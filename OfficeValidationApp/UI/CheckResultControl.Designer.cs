﻿namespace OfficeValidationApp.UI
{
    partial class CheckResultControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelLogPanelChecks = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxChecks = new System.Windows.Forms.GroupBox();
            this.treeListViewChecks = new BrightIdeasSoftware.TreeListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBoxViolations = new System.Windows.Forms.GroupBox();
            this.objectListViewViolations = new BrightIdeasSoftware.ObjectListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLog = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanelLogPanelChecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxChecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListViewChecks)).BeginInit();
            this.groupBoxViolations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewViolations)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelLogPanelChecks
            // 
            this.tableLayoutPanelLogPanelChecks.ColumnCount = 1;
            this.tableLayoutPanelLogPanelChecks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLogPanelChecks.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanelLogPanelChecks.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanelLogPanelChecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLogPanelChecks.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLogPanelChecks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelLogPanelChecks.Name = "tableLayoutPanelLogPanelChecks";
            this.tableLayoutPanelLogPanelChecks.RowCount = 2;
            this.tableLayoutPanelLogPanelChecks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanelLogPanelChecks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 692F));
            this.tableLayoutPanelLogPanelChecks.Size = new System.Drawing.Size(989, 748);
            this.tableLayoutPanelLogPanelChecks.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 44);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxChecks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxViolations);
            this.splitContainer1.Size = new System.Drawing.Size(981, 699);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxChecks
            // 
            this.groupBoxChecks.Controls.Add(this.treeListViewChecks);
            this.groupBoxChecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxChecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxChecks.Location = new System.Drawing.Point(0, 0);
            this.groupBoxChecks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxChecks.Name = "groupBoxChecks";
            this.groupBoxChecks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxChecks.Size = new System.Drawing.Size(336, 699);
            this.groupBoxChecks.TabIndex = 0;
            this.groupBoxChecks.TabStop = false;
            this.groupBoxChecks.Text = "Проверки";
            // 
            // treeListViewChecks
            // 
            this.treeListViewChecks.AllColumns.Add(this.olvColumnName);
            this.treeListViewChecks.CellEditUseWholeCell = false;
            this.treeListViewChecks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName});
            this.treeListViewChecks.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListViewChecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListViewChecks.FullRowSelect = true;
            this.treeListViewChecks.HideSelection = false;
            this.treeListViewChecks.Location = new System.Drawing.Point(4, 21);
            this.treeListViewChecks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeListViewChecks.Name = "treeListViewChecks";
            this.treeListViewChecks.ShowGroups = false;
            this.treeListViewChecks.ShowImagesOnSubItems = true;
            this.treeListViewChecks.Size = new System.Drawing.Size(328, 673);
            this.treeListViewChecks.TabIndex = 6;
            this.treeListViewChecks.UseCompatibleStateImageBehavior = false;
            this.treeListViewChecks.UseFiltering = true;
            this.treeListViewChecks.View = System.Windows.Forms.View.Details;
            this.treeListViewChecks.VirtualMode = true;
            this.treeListViewChecks.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.TreeListViewChecks_FormatRow);
            this.treeListViewChecks.SelectedIndexChanged += new System.EventHandler(this.TreeListViewChecks_SelectedIndexChanged);
            // 
            // olvColumnName
            // 
            this.olvColumnName.FillsFreeSpace = true;
            this.olvColumnName.Text = "Имя";
            this.olvColumnName.Width = 200;
            // 
            // groupBoxViolations
            // 
            this.groupBoxViolations.Controls.Add(this.objectListViewViolations);
            this.groupBoxViolations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxViolations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxViolations.Location = new System.Drawing.Point(0, 0);
            this.groupBoxViolations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxViolations.Name = "groupBoxViolations";
            this.groupBoxViolations.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxViolations.Size = new System.Drawing.Size(639, 699);
            this.groupBoxViolations.TabIndex = 1;
            this.groupBoxViolations.TabStop = false;
            this.groupBoxViolations.Text = "Нарушения";
            // 
            // objectListViewViolations
            // 
            this.objectListViewViolations.AllowColumnReorder = true;
            this.objectListViewViolations.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.objectListViewViolations.CellEditEnterChangesRows = true;
            this.objectListViewViolations.CellEditUseWholeCell = false;
            this.objectListViewViolations.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewViolations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewViolations.EmptyListMsg = "Проверка пройдена";
            this.objectListViewViolations.FullRowSelect = true;
            this.objectListViewViolations.GridLines = true;
            this.objectListViewViolations.HideSelection = false;
            this.objectListViewViolations.Location = new System.Drawing.Point(4, 21);
            this.objectListViewViolations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListViewViolations.Name = "objectListViewViolations";
            this.objectListViewViolations.ShowGroups = false;
            this.objectListViewViolations.Size = new System.Drawing.Size(631, 673);
            this.objectListViewViolations.TabIndex = 6;
            this.objectListViewViolations.UseCompatibleStateImageBehavior = false;
            this.objectListViewViolations.UseFiltering = true;
            this.objectListViewViolations.View = System.Windows.Forms.View.Details;
            this.objectListViewViolations.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.ObjectListViewViolations_FormatRow);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLog});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(989, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonLog
            // 
            this.toolStripButtonLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLog.Image = global::OfficeValidationApp.Properties.Resources.log;
            this.toolStripButtonLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLog.Name = "toolStripButtonLog";
            this.toolStripButtonLog.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLog.Text = "toolStripButton1";
            this.toolStripButtonLog.Click += new System.EventHandler(this.ToolStripButtonLog_Click);
            // 
            // CheckResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelLogPanelChecks);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckResultControl";
            this.Size = new System.Drawing.Size(989, 748);
            this.tableLayoutPanelLogPanelChecks.ResumeLayout(false);
            this.tableLayoutPanelLogPanelChecks.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxChecks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListViewChecks)).EndInit();
            this.groupBoxViolations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewViolations)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLogPanelChecks;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxChecks;
        private System.Windows.Forms.GroupBox groupBoxViolations;
        private BrightIdeasSoftware.TreeListView treeListViewChecks;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.ObjectListView objectListViewViolations;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonLog;
    }
}
