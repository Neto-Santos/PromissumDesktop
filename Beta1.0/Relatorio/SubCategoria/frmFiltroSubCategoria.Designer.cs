namespace Beta1._0.Relatorio.SubCategoria
{
    partial class frmFiltroSubCategoria
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
            this.Produto = new System.Windows.Forms.GroupBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.rbSintetico = new System.Windows.Forms.RadioButton();
            this.rbAnalitico = new System.Windows.Forms.RadioButton();
            this.SubCategoria = new System.Windows.Forms.GroupBox();
            this.txtSubCategoria = new System.Windows.Forms.TextBox();
            this.Produto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SubCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // Produto
            // 
            this.Produto.Controls.Add(this.txtProduto);
            this.Produto.Location = new System.Drawing.Point(8, 271);
            this.Produto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Produto.Name = "Produto";
            this.Produto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Produto.Size = new System.Drawing.Size(516, 66);
            this.Produto.TabIndex = 17;
            this.Produto.TabStop = false;
            this.Produto.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(9, 23);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(499, 23);
            this.txtProduto.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCategoria);
            this.groupBox2.Location = new System.Drawing.Point(8, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(516, 69);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(9, 23);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(499, 23);
            this.txtCategoria.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(421, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 41);
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
            this.groupBox1.Location = new System.Drawing.Point(97, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(299, 98);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entre as datas de cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Início";
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(155, 48);
            this.dtFim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(118, 23);
            this.dtFim.TabIndex = 2;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(29, 48);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(118, 23);
            this.dtInicio.TabIndex = 1;
            // 
            // rbSintetico
            // 
            this.rbSintetico.AutoSize = true;
            this.rbSintetico.Location = new System.Drawing.Point(14, 63);
            this.rbSintetico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSintetico.Name = "rbSintetico";
            this.rbSintetico.Size = new System.Drawing.Size(75, 20);
            this.rbSintetico.TabIndex = 13;
            this.rbSintetico.TabStop = true;
            this.rbSintetico.Text = "Sintético";
            this.rbSintetico.UseVisualStyleBackColor = true;
            // 
            // rbAnalitico
            // 
            this.rbAnalitico.AutoSize = true;
            this.rbAnalitico.Location = new System.Drawing.Point(14, 34);
            this.rbAnalitico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAnalitico.Name = "rbAnalitico";
            this.rbAnalitico.Size = new System.Drawing.Size(74, 20);
            this.rbAnalitico.TabIndex = 14;
            this.rbAnalitico.TabStop = true;
            this.rbAnalitico.Text = "Analítico";
            this.rbAnalitico.UseVisualStyleBackColor = true;
            // 
            // SubCategoria
            // 
            this.SubCategoria.Controls.Add(this.txtSubCategoria);
            this.SubCategoria.Location = new System.Drawing.Point(8, 121);
            this.SubCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubCategoria.Name = "SubCategoria";
            this.SubCategoria.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubCategoria.Size = new System.Drawing.Size(516, 66);
            this.SubCategoria.TabIndex = 18;
            this.SubCategoria.TabStop = false;
            this.SubCategoria.Text = "Modelo";
            // 
            // txtSubCategoria
            // 
            this.txtSubCategoria.Location = new System.Drawing.Point(9, 23);
            this.txtSubCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubCategoria.Name = "txtSubCategoria";
            this.txtSubCategoria.Size = new System.Drawing.Size(499, 23);
            this.txtSubCategoria.TabIndex = 7;
            // 
            // frmFiltroSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(530, 348);
            this.Controls.Add(this.SubCategoria);
            this.Controls.Add(this.Produto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbSintetico);
            this.Controls.Add(this.rbAnalitico);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFiltroSubCategoria";
            this.Text = "Filtro Modelo/Tipo";
            this.Produto.ResumeLayout(false);
            this.Produto.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SubCategoria.ResumeLayout(false);
            this.SubCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Produto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.RadioButton rbSintetico;
        private System.Windows.Forms.RadioButton rbAnalitico;
        private System.Windows.Forms.GroupBox SubCategoria;
        private System.Windows.Forms.TextBox txtSubCategoria;
    }
}