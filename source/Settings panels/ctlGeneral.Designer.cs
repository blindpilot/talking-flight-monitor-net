﻿namespace tfm
{
    partial class ctlGeneral
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGeonames = new System.Windows.Forms.Label();
            this.grpUserInterfaceMode = new System.Windows.Forms.GroupBox();
            this.radPropertyGrid = new System.Windows.Forms.RadioButton();
            this.radSimplified = new System.Windows.Forms.RadioButton();
            this.txtGeonames = new System.Windows.Forms.TextBox();
            this.chkMetric = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpUserInterfaceMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblGeonames, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGeonames, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkMetric, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpUserInterfaceMode, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblGeonames
            // 
            this.lblGeonames.AutoSize = true;
            this.lblGeonames.Location = new System.Drawing.Point(3, 0);
            this.lblGeonames.Name = "lblGeonames";
            this.lblGeonames.Size = new System.Drawing.Size(61, 26);
            this.lblGeonames.TabIndex = 0;
            this.lblGeonames.Text = "Geonames username: ";
            // 
            // grpUserInterfaceMode
            // 
            this.grpUserInterfaceMode.Controls.Add(this.radPropertyGrid);
            this.grpUserInterfaceMode.Controls.Add(this.radSimplified);
            this.grpUserInterfaceMode.Location = new System.Drawing.Point(103, 43);
            this.grpUserInterfaceMode.Name = "grpUserInterfaceMode";
            this.grpUserInterfaceMode.Size = new System.Drawing.Size(94, 34);
            this.grpUserInterfaceMode.TabIndex = 3;
            this.grpUserInterfaceMode.TabStop = false;
            this.grpUserInterfaceMode.Text = "avionics panel mode";
            // 
            // radPropertyGrid
            // 
            this.radPropertyGrid.AutoSize = true;
            this.radPropertyGrid.Location = new System.Drawing.Point(3, 16);
            this.radPropertyGrid.Name = "radPropertyGrid";
            this.radPropertyGrid.Size = new System.Drawing.Size(83, 17);
            this.radPropertyGrid.TabIndex = 1;
            this.radPropertyGrid.TabStop = true;
            this.radPropertyGrid.Text = "property grid";
            this.radPropertyGrid.UseVisualStyleBackColor = true;
            this.radPropertyGrid.CheckedChanged += new System.EventHandler(this.avionicsRadioButton_CheckedChanged);
            // 
            // radSimplified
            // 
            this.radSimplified.AutoSize = true;
            this.radSimplified.Location = new System.Drawing.Point(3, 16);
            this.radSimplified.Name = "radSimplified";
            this.radSimplified.Size = new System.Drawing.Size(67, 17);
            this.radSimplified.TabIndex = 0;
            this.radSimplified.TabStop = true;
            this.radSimplified.Text = "simplified";
            this.radSimplified.UseVisualStyleBackColor = true;
            this.radSimplified.CheckedChanged += new System.EventHandler(this.avionicsRadioButton_CheckedChanged);
            // 
            // txtGeonames
            // 
            this.txtGeonames.AccessibleName = "Geonames username";
            this.txtGeonames.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::tfm.Properties.Settings.Default, "GeonamesUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGeonames.Location = new System.Drawing.Point(103, 3);
            this.txtGeonames.Name = "txtGeonames";
            this.txtGeonames.Size = new System.Drawing.Size(94, 20);
            this.txtGeonames.TabIndex = 1;
            this.txtGeonames.Text = global::tfm.Properties.Settings.Default.GeonamesUsername;
            // 
            // chkMetric
            // 
            this.chkMetric.AutoSize = true;
            this.chkMetric.Checked = global::tfm.Properties.Settings.Default.UseMetric;
            this.chkMetric.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::tfm.Properties.Settings.Default, "UseMetric", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkMetric.Location = new System.Drawing.Point(3, 43);
            this.chkMetric.Name = "chkMetric";
            this.chkMetric.Size = new System.Drawing.Size(94, 17);
            this.chkMetric.TabIndex = 2;
            this.chkMetric.Text = "Use metric measurements";
            this.chkMetric.UseVisualStyleBackColor = true;
            // 
            // ctlGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ctlGeneral";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpUserInterfaceMode.ResumeLayout(false);
            this.grpUserInterfaceMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblGeonames;
        private System.Windows.Forms.TextBox txtGeonames;
        private System.Windows.Forms.CheckBox chkMetric;
        private System.Windows.Forms.GroupBox grpUserInterfaceMode;
        private System.Windows.Forms.RadioButton radPropertyGrid;
        private System.Windows.Forms.RadioButton radSimplified;
    }
}
