namespace Promissum.Relatorio_Atualizado.Operacao
{
    partial class frmRelatorioOperacao
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
            this.components = new System.ComponentModel.Container();
            this.dsOperacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOperacao = new Promissum.Relatorio_Atualizado.Operacao.dsOperacao();
            this.dsOperacaoTableAdapter = new Promissum.Relatorio_Atualizado.Operacao.dsOperacaoTableAdapters.dsOperacaoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dsOperacaoBindingSource
            // 
            this.dsOperacaoBindingSource.DataMember = "dsOperacao";
            this.dsOperacaoBindingSource.DataSource = this.dsOperacao;
            // 
            // dsOperacao
            // 
            this.dsOperacao.DataSetName = "dsOperacao";
            this.dsOperacao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsOperacaoTableAdapter
            // 
            this.dsOperacaoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(990, 651);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmRelatorioOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 651);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.Name = "frmRelatorioOperacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operação VS Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioOperacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsOperacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dsOperacaoBindingSource;
        private dsOperacao dsOperacao;
        private dsOperacaoTableAdapters.dsOperacaoTableAdapter dsOperacaoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}