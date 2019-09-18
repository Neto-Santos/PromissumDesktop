namespace Beta1._0.Relatorio.Categoria
{
    partial class frmFiltroCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroCategoria));
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.rbSintetico = new System.Windows.Forms.RadioButton();
            this.rbAnalitico = new System.Windows.Forms.RadioButton();
            this.txtSubCategoria = new System.Windows.Forms.TextBox();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.preVisualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.cbImpressora = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Location = new System.Drawing.Point(9, 96);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(296, 23);
            this.txtCategoria.TabIndex = 8;
            // 
            // txtProduto
            // 
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.Location = new System.Drawing.Point(9, 190);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(296, 23);
            this.txtProduto.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(238, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "FILTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFim);
            this.groupBox1.Controls.Add(this.dtInicio);
            this.groupBox1.Location = new System.Drawing.Point(83, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(232, 64);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entre as datas de cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Início";
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(118, 34);
            this.dtFim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(103, 23);
            this.dtFim.TabIndex = 2;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(9, 34);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(103, 23);
            this.dtInicio.TabIndex = 1;
            // 
            // rbSintetico
            // 
            this.rbSintetico.AutoSize = true;
            this.rbSintetico.Location = new System.Drawing.Point(6, 38);
            this.rbSintetico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSintetico.Name = "rbSintetico";
            this.rbSintetico.Size = new System.Drawing.Size(75, 20);
            this.rbSintetico.TabIndex = 8;
            this.rbSintetico.TabStop = true;
            this.rbSintetico.Text = "Sintético";
            this.rbSintetico.UseVisualStyleBackColor = true;
            this.rbSintetico.Visible = false;
            // 
            // rbAnalitico
            // 
            this.rbAnalitico.AutoSize = true;
            this.rbAnalitico.Location = new System.Drawing.Point(6, 10);
            this.rbAnalitico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAnalitico.Name = "rbAnalitico";
            this.rbAnalitico.Size = new System.Drawing.Size(74, 20);
            this.rbAnalitico.TabIndex = 9;
            this.rbAnalitico.TabStop = true;
            this.rbAnalitico.Text = "Analítico";
            this.rbAnalitico.UseVisualStyleBackColor = true;
            this.rbAnalitico.Visible = false;
            // 
            // txtSubCategoria
            // 
            this.txtSubCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubCategoria.Location = new System.Drawing.Point(9, 143);
            this.txtSubCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubCategoria.Name = "txtSubCategoria";
            this.txtSubCategoria.Size = new System.Drawing.Size(296, 23);
            this.txtSubCategoria.TabIndex = 8;
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.documento_PrintPage);
            // 
            // preVisualizacao
            // 
            this.preVisualizacao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.preVisualizacao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.preVisualizacao.ClientSize = new System.Drawing.Size(400, 300);
            this.preVisualizacao.Enabled = true;
            this.preVisualizacao.Icon = ((System.Drawing.Icon)(resources.GetObject("preVisualizacao.Icon")));
            this.preVisualizacao.Name = "preVisualizacao";
            this.preVisualizacao.Visible = false;
            // 
            // cbImpressora
            // 
            this.cbImpressora.BackColor = System.Drawing.SystemColors.Control;
            this.cbImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImpressora.FormattingEnabled = true;
            this.cbImpressora.Location = new System.Drawing.Point(77, 225);
            this.cbImpressora.Name = "cbImpressora";
            this.cbImpressora.Size = new System.Drawing.Size(155, 24);
            this.cbImpressora.TabIndex = 21;
            this.cbImpressora.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Impressora";
            this.label9.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Produto";
            // 
            // btnGerarPdf
            // 
            this.btnGerarPdf.BackColor = System.Drawing.Color.Red;
            this.btnGerarPdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGerarPdf.Location = new System.Drawing.Point(187, 69);
            this.btnGerarPdf.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(117, 23);
            this.btnGerarPdf.TabIndex = 22;
            this.btnGerarPdf.Text = "GERAR PDF";
            this.btnGerarPdf.UseVisualStyleBackColor = false;
            this.btnGerarPdf.Click += new System.EventHandler(this.btnGerarPdf_Click);
            // 
            // frmFiltroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(320, 252);
            this.Controls.Add(this.btnGerarPdf);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtSubCategoria);
            this.Controls.Add(this.cbImpressora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbSintetico);
            this.Controls.Add(this.rbAnalitico);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiltroCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro Tipo/Modelo";
            this.Load += new System.EventHandler(this.frmFiltroCategoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.RadioButton rbSintetico;
        private System.Windows.Forms.RadioButton rbAnalitico;
        private System.Windows.Forms.TextBox txtSubCategoria;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.PrintPreviewDialog preVisualizacao;
        private System.Windows.Forms.ComboBox cbImpressora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGerarPdf;
    }
}