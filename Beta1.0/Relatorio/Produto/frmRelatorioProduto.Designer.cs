namespace Beta1._0.Relatorio.Produto
{
    partial class frmRelatorioProduto
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
            this.crViewerProduto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crViewerProduto
            // 
            this.crViewerProduto.ActiveViewIndex = -1;
            this.crViewerProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewerProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewerProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewerProduto.Location = new System.Drawing.Point(0, 0);
            this.crViewerProduto.Name = "crViewerProduto";
            this.crViewerProduto.ShowCloseButton = false;
            this.crViewerProduto.ShowGroupTreeButton = false;
            this.crViewerProduto.ShowLogo = false;
            this.crViewerProduto.ShowParameterPanelButton = false;
            this.crViewerProduto.ShowRefreshButton = false;
            this.crViewerProduto.Size = new System.Drawing.Size(710, 487);
            this.crViewerProduto.TabIndex = 0;
            this.crViewerProduto.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorioProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 487);
            this.Controls.Add(this.crViewerProduto);
            this.Name = "frmRelatorioProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioProduto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerProduto;
    }
}