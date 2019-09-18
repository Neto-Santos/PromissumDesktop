namespace Beta1._0.Relatorio.Produto
{
    partial class frmFiltroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroProduto));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.rbSintetico = new System.Windows.Forms.RadioButton();
            this.rbAnalitico = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSubCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.pre_visualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(60, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 23);
            this.textBox1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFim);
            this.groupBox1.Controls.Add(this.dtInicio);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(329, 56);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entre as datas de cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Início";
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(201, 24);
            this.dtFim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(104, 23);
            this.dtFim.TabIndex = 2;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(59, 24);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(103, 23);
            this.dtInicio.TabIndex = 1;
            // 
            // rbSintetico
            // 
            this.rbSintetico.AutoSize = true;
            this.rbSintetico.Checked = true;
            this.rbSintetico.Location = new System.Drawing.Point(87, 213);
            this.rbSintetico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSintetico.Name = "rbSintetico";
            this.rbSintetico.Size = new System.Drawing.Size(75, 20);
            this.rbSintetico.TabIndex = 6;
            this.rbSintetico.TabStop = true;
            this.rbSintetico.Text = "Sintético";
            this.rbSintetico.UseVisualStyleBackColor = true;
            this.rbSintetico.Visible = false;
            // 
            // rbAnalitico
            // 
            this.rbAnalitico.AutoSize = true;
            this.rbAnalitico.Location = new System.Drawing.Point(7, 213);
            this.rbAnalitico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAnalitico.Name = "rbAnalitico";
            this.rbAnalitico.Size = new System.Drawing.Size(74, 20);
            this.rbAnalitico.TabIndex = 7;
            this.rbAnalitico.Text = "Analítico";
            this.rbAnalitico.UseVisualStyleBackColor = true;
            this.rbAnalitico.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGerarPdf);
            this.groupBox2.Controls.Add(this.txtSubCategoria);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtReferencia);
            this.groupBox2.Controls.Add(this.txtProduto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCategoria);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 55);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(329, 157);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // txtSubCategoria
            // 
            this.txtSubCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubCategoria.Location = new System.Drawing.Point(59, 68);
            this.txtSubCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubCategoria.Name = "txtSubCategoria";
            this.txtSubCategoria.Size = new System.Drawing.Size(264, 23);
            this.txtSubCategoria.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Modelo";
            // 
            // txtReferencia
            // 
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferencia.Location = new System.Drawing.Point(59, 127);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(264, 23);
            this.txtReferencia.TabIndex = 9;
            // 
            // txtProduto
            // 
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.Location = new System.Drawing.Point(59, 40);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(264, 23);
            this.txtProduto.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ref";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Location = new System.Drawing.Point(59, 96);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(264, 23);
            this.txtCategoria.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(241, 213);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "FILTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // btnGerarPdf
            // 
            this.btnGerarPdf.BackColor = System.Drawing.Color.Red;
            this.btnGerarPdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGerarPdf.Location = new System.Drawing.Point(204, 12);
            this.btnGerarPdf.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(117, 23);
            this.btnGerarPdf.TabIndex = 24;
            this.btnGerarPdf.Text = "GERAR PDF";
            this.btnGerarPdf.UseVisualStyleBackColor = false;
            this.btnGerarPdf.Click += new System.EventHandler(this.btnGerarPdf_Click);
            // 
            // frmFiltroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(333, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbSintetico);
            this.Controls.Add(this.rbAnalitico);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiltroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtragem Produto";
            this.Load += new System.EventHandler(this.frmFiltroProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.RadioButton rbSintetico;
        private System.Windows.Forms.RadioButton rbAnalitico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSubCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.PrintPreviewDialog pre_visualizacao;
        private System.Windows.Forms.Button btnGerarPdf;
    }
}