namespace IntegracaoDevApp.Views
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.reportView1 = new IntegracaoDevApp.SubViews.ReportView();
            this.SuspendLayout();
            // 
            // reportView1
            // 
            this.reportView1.BackColor = System.Drawing.SystemColors.Control;
            this.reportView1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reportView1.DotNetContainer = false;
            this.reportView1.KeyPreview = false;
            this.reportView1.Location = new System.Drawing.Point(0, 0);
            this.reportView1.Name = "reportView1";
            this.reportView1.OpenModal = false;
            this.reportView1.Parameters = ((System.Collections.Generic.IDictionary<string, object>)(resources.GetObject("reportView1.Parameters")));
            this.reportView1.Size = new System.Drawing.Size(600, 400);
            this.reportView1.StartPositionControl = null;
            this.reportView1.TabIndex = 0;
            this.reportView1.TabOrderScheme = dpLibrary05.TabOrderManager.TabScheme.None;
            this.reportView1.WindowSize = dpLibrary05.Infrastructure.UserControls.ucSymGen_ReportDialog.WindowSizeEnum.D590X415;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        private SubViews.ReportView reportView1;
    }
}