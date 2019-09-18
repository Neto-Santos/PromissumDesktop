namespace Beta1._0.Relatorio.Fornecedor
{
    partial class frmRelatorioFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioFornecedor));
            this.crvFornecedor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvFornecedor
            // 
            this.crvFornecedor.ActiveViewIndex = -1;
            this.crvFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvFornecedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvFornecedor.Location = new System.Drawing.Point(0, 0);
            this.crvFornecedor.Name = "crvFornecedor";
            this.crvFornecedor.ShowCloseButton = false;
            this.crvFornecedor.ShowGroupTreeButton = false;
            this.crvFornecedor.ShowLogo = false;
            this.crvFornecedor.ShowParameterPanelButton = false;
            this.crvFornecedor.Size = new System.Drawing.Size(839, 485);
            this.crvFornecedor.TabIndex = 0;
            this.crvFornecedor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorioFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 485);
            this.Controls.Add(this.crvFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorioFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Fornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioFornecedor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvFornecedor;
    }
}