namespace Beta1._0.Relatorio.Categoria
{
    partial class frmRelatorioCategoria
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
            this.crvCategoria = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCategoria
            // 
            this.crvCategoria.ActiveViewIndex = -1;
            this.crvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCategoria.EnableDrillDown = false;
            this.crvCategoria.Location = new System.Drawing.Point(0, 0);
            this.crvCategoria.Name = "crvCategoria";
            this.crvCategoria.ShowCloseButton = false;
            this.crvCategoria.ShowGroupTreeButton = false;
            this.crvCategoria.ShowLogo = false;
            this.crvCategoria.ShowParameterPanelButton = false;
            this.crvCategoria.ShowTextSearchButton = false;
            this.crvCategoria.Size = new System.Drawing.Size(701, 481);
            this.crvCategoria.TabIndex = 0;
            this.crvCategoria.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorioCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 481);
            this.Controls.Add(this.crvCategoria);
            this.Name = "frmRelatorioCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Tipo/Modelo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioCategoria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCategoria;
    }
}