namespace Beta1._0.Impressao
{
    partial class frmImpressao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpressao));
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.btnPrever = new System.Windows.Forms.Button();
            this.pre_visualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.documento_PrintPage);
            // 
            // btnPrever
            // 
            this.btnPrever.Location = new System.Drawing.Point(497, 228);
            this.btnPrever.Name = "btnPrever";
            this.btnPrever.Size = new System.Drawing.Size(73, 32);
            this.btnPrever.TabIndex = 0;
            this.btnPrever.Text = "Preview";
            this.btnPrever.UseVisualStyleBackColor = true;
            this.btnPrever.Click += new System.EventHandler(this.btnPrever_Click);
            // 
            // pre_visualizacao
            // 
            this.pre_visualizacao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pre_visualizacao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pre_visualizacao.ClientSize = new System.Drawing.Size(400, 300);
            this.pre_visualizacao.Enabled = true;
            this.pre_visualizacao.Icon = ((System.Drawing.Icon)(resources.GetObject("pre_visualizacao.Icon")));
            this.pre_visualizacao.Name = "pre_visualizacao";
            this.pre_visualizacao.Visible = false;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // frmImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 272);
            this.Controls.Add(this.btnPrever);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmImpressao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão";
            this.Load += new System.EventHandler(this.frmImpressao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.Button btnPrever;
        private System.Windows.Forms.PrintPreviewDialog pre_visualizacao;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}