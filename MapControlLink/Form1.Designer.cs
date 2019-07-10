namespace MapControlLink
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.rightMapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axTOCControl2 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.leftMapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axToolbarControl2 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(23, 404);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 0;
            // 
            // rightMapControl
            // 
            this.rightMapControl.Location = new System.Drawing.Point(620, 48);
            this.rightMapControl.Name = "rightMapControl";
            this.rightMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rightMapControl.OcxState")));
            this.rightMapControl.Size = new System.Drawing.Size(435, 542);
            this.rightMapControl.TabIndex = 2;
            this.rightMapControl.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.rightMapControl_OnMouseMove);
            this.rightMapControl.OnViewRefreshed += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnViewRefreshedEventHandler(this.rightMapControl_OnViewRefreshed);
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Location = new System.Drawing.Point(13, 48);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(160, 542);
            this.axTOCControl1.TabIndex = 4;
            // 
            // axTOCControl2
            // 
            this.axTOCControl2.Location = new System.Drawing.Point(1061, 48);
            this.axTOCControl2.Name = "axTOCControl2";
            this.axTOCControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl2.OcxState")));
            this.axTOCControl2.Size = new System.Drawing.Size(160, 542);
            this.axTOCControl2.TabIndex = 5;
            // 
            // leftMapControl
            // 
            this.leftMapControl.Location = new System.Drawing.Point(179, 48);
            this.leftMapControl.Name = "leftMapControl";
            this.leftMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("leftMapControl.OcxState")));
            this.leftMapControl.Size = new System.Drawing.Size(435, 542);
            this.leftMapControl.TabIndex = 8;
            this.leftMapControl.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.leftMapControl_OnMouseMove);
            this.leftMapControl.OnViewRefreshed += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnViewRefreshedEventHandler(this.leftMapControl_OnViewRefreshed);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Location = new System.Drawing.Point(179, 14);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(265, 28);
            this.axToolbarControl1.TabIndex = 9;
            // 
            // axToolbarControl2
            // 
            this.axToolbarControl2.Location = new System.Drawing.Point(790, 14);
            this.axToolbarControl2.Name = "axToolbarControl2";
            this.axToolbarControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl2.OcxState")));
            this.axToolbarControl2.Size = new System.Drawing.Size(265, 28);
            this.axToolbarControl2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 597);
            this.Controls.Add(this.axToolbarControl2);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.leftMapControl);
            this.Controls.Add(this.axTOCControl2);
            this.Controls.Add(this.axTOCControl1);
            this.Controls.Add(this.rightMapControl);
            this.Controls.Add(this.axLicenseControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxMapControl rightMapControl;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl2;
        private ESRI.ArcGIS.Controls.AxMapControl leftMapControl;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl2;
    }
}

