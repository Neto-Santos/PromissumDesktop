namespace Beta1._0.Relatorio.Fornecedor
{
    partial class frmFiltroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroFornecedor));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.rbSintetico = new System.Windows.Forms.RadioButton();
            this.rbAnalitico = new System.Windows.Forms.RadioButton();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.preVisualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 275);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnGerarPdf);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.rbSintetico);
            this.tabPage1.Controls.Add(this.rbAnalitico);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(359, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProduto);
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCnpj);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(8, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(345, 144);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fornecedor";
            // 
            // txtProduto
            // 
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.Location = new System.Drawing.Point(58, 111);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(231, 23);
            this.txtProduto.TabIndex = 15;
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(58, 78);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(130, 23);
            this.txtCpf.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "UF";
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(232, 80);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(103, 23);
            this.txtCnpj.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "CNPJ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome";
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Location = new System.Drawing.Point(268, 49);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(67, 23);
            this.txtEstado.TabIndex = 6;
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(58, 49);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(175, 23);
            this.txtCidade.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(58, 18);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 23);
            this.txtNome.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(264, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 16;
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
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(303, 44);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entre as datas de cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Início";
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(188, 17);
            this.dtFim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(105, 23);
            this.dtFim.TabIndex = 2;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(44, 17);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(103, 23);
            this.dtInicio.TabIndex = 1;
            // 
            // rbSintetico
            // 
            this.rbSintetico.AutoSize = true;
            this.rbSintetico.Checked = true;
            this.rbSintetico.Location = new System.Drawing.Point(183, 194);
            this.rbSintetico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSintetico.Name = "rbSintetico";
            this.rbSintetico.Size = new System.Drawing.Size(75, 20);
            this.rbSintetico.TabIndex = 13;
            this.rbSintetico.TabStop = true;
            this.rbSintetico.Text = "Sintético";
            this.rbSintetico.UseVisualStyleBackColor = true;
            this.rbSintetico.Visible = false;
            // 
            // rbAnalitico
            // 
            this.rbAnalitico.AutoSize = true;
            this.rbAnalitico.Location = new System.Drawing.Point(101, 194);
            this.rbAnalitico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAnalitico.Name = "rbAnalitico";
            this.rbAnalitico.Size = new System.Drawing.Size(74, 20);
            this.rbAnalitico.TabIndex = 14;
            this.rbAnalitico.Text = "Analítico";
            this.rbAnalitico.UseVisualStyleBackColor = true;
            this.rbAnalitico.Visible = false;
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
            // btnGerarPdf
            // 
            this.btnGerarPdf.BackColor = System.Drawing.Color.Red;
            this.btnGerarPdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGerarPdf.Location = new System.Drawing.Point(8, 218);
            this.btnGerarPdf.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(117, 23);
            this.btnGerarPdf.TabIndex = 23;
            this.btnGerarPdf.Text = "GERAR PDF";
            this.btnGerarPdf.UseVisualStyleBackColor = false;
            this.btnGerarPdf.Click += new System.EventHandler(this.btnGerarPdf_Click);
            // 
            // frmFiltroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(367, 275);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmFiltroFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro Fornecedor";
            this.Load += new System.EventHandler(this.frmFiltroFornecedor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.RadioButton rbSintetico;
        private System.Windows.Forms.RadioButton rbAnalitico;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label8;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.PrintPreviewDialog preVisualizacao;
        private System.Windows.Forms.Button btnGerarPdf;
    }
}