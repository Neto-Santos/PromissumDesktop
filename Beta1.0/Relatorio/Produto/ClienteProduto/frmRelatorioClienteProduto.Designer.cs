namespace Beta1._0.Relatorio.Produto.ClienteProduto
{
    partial class frmRelatorioClienteProduto
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
            this.crvClienteProduto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvClienteProduto
            // 
            this.crvClienteProduto.ActiveViewIndex = -1;
            this.crvClienteProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvClienteProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvClienteProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvClienteProduto.Location = new System.Drawing.Point(0, 0);
            this.crvClienteProduto.Name = "crvClienteProduto";
            this.crvClienteProduto.ShowCloseButton = false;
            this.crvClienteProduto.ShowGroupTreeButton = false;
            this.crvClienteProduto.ShowLogo = false;
            this.crvClienteProduto.ShowParameterPanelButton = false;
            this.crvClienteProduto.Size = new System.Drawing.Size(708, 481);
            this.crvClienteProduto.TabIndex = 0;
            this.crvClienteProduto.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorioClienteProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 481);
            this.Controls.Add(this.crvClienteProduto);
            this.Name = "frmRelatorioClienteProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Cliente-Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioClienteProduto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvClienteProduto;
    }
}