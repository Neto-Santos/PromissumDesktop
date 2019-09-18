namespace Beta1._0.Relatorio.Os
{
    partial class frmRelatorioOs
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
            this.crvOs = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvOs
            // 
            this.crvOs.ActiveViewIndex = -1;
            this.crvOs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvOs.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvOs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvOs.EnableDrillDown = false;
            this.crvOs.Location = new System.Drawing.Point(0, 0);
            this.crvOs.Name = "crvOs";
            this.crvOs.ShowCloseButton = false;
            this.crvOs.ShowGroupTreeButton = false;
            this.crvOs.ShowLogo = false;
            this.crvOs.ShowParameterPanelButton = false;
            this.crvOs.ShowRefreshButton = false;
            this.crvOs.ShowTextSearchButton = false;
            this.crvOs.Size = new System.Drawing.Size(768, 503);
            this.crvOs.TabIndex = 0;
            this.crvOs.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorioOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 503);
            this.Controls.Add(this.crvOs);
            this.Name = "frmRelatorioOs";
            this.Text = "frmRelatorioOs";
            this.Load += new System.EventHandler(this.frmRelatorioOs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvOs;
    }
}