namespace Promissum.NFS_e
{
    partial class frmNFSe
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCertificado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulário Para teste de Implementação NFS-e";
            // 
            // cbCertificado
            // 
            this.cbCertificado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCertificado.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCertificado.FormattingEnabled = true;
            this.cbCertificado.Location = new System.Drawing.Point(24, 88);
            this.cbCertificado.Name = "cbCertificado";
            this.cbCertificado.Size = new System.Drawing.Size(170, 24);
            this.cbCertificado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Certificados";
            // 
            // frmNFSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 346);
            this.Controls.Add(this.cbCertificado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNFSe";
            this.Text = "frmNFSe";
            this.Load += new System.EventHandler(this.frmNFSe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCertificado;
        private System.Windows.Forms.Label label2;
    }
}