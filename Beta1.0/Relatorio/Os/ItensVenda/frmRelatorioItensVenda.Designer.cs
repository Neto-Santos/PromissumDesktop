namespace Beta1._0.Relatorio.Os.ItensVenda
{
    partial class frmRelatorioItensVenda
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
            this.crvItensVenda = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvItensVenda
            // 
            this.crvItensVenda.ActiveViewIndex = -1;
            this.crvItensVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvItensVenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvItensVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvItensVenda.EnableDrillDown = false;
            this.crvItensVenda.Location = new System.Drawing.Point(0, 0);
            this.crvItensVenda.Name = "crvItensVenda";
            this.crvItensVenda.ShowCloseButton = false;
            this.crvItensVenda.ShowGroupTreeButton = false;
            this.crvItensVenda.ShowLogo = false;
            this.crvItensVenda.ShowParameterPanelButton = false;
            this.crvItensVenda.ShowRefreshButton = false;
            this.crvItensVenda.Size = new System.Drawing.Size(691, 474);
            this.crvItensVenda.TabIndex = 0;
            this.crvItensVenda.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorioItensVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 474);
            this.Controls.Add(this.crvItensVenda);
            this.Name = "frmRelatorioItensVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioItensVenda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvItensVenda;
    }
}