namespace Beta1._0.Cadastro
{
    partial class frmCadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProduto));
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtUndMedida = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtlocalizacao = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMargemLucro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btnAddImagem = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(6, 88);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(346, 72);
            this.txtDescricao.TabIndex = 7;
            this.txtDescricao.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 410);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cód";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.Location = new System.Drawing.Point(7, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Nº Série";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label11.Location = new System.Drawing.Point(6, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "Descrição do Produto/Serviço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.Location = new System.Drawing.Point(6, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Und Medida";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label14.Location = new System.Drawing.Point(6, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 16);
            this.label14.TabIndex = 42;
            this.label14.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(94, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // txtCod
            // 
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtCod.Location = new System.Drawing.Point(8, 30);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(65, 23);
            this.txtCod.TabIndex = 1;
            // 
            // txtRef
            // 
            this.txtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRef.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtRef.Location = new System.Drawing.Point(7, 37);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(336, 23);
            this.txtRef.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(94, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(623, 23);
            this.txtNome.TabIndex = 1;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(6, 33);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(334, 24);
            this.cbCategoria.TabIndex = 9;
            this.cbCategoria.SelectedValueChanged += new System.EventHandler(this.cbCategoria_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Modelo";
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(6, 85);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(334, 24);
            this.cbSubCategoria.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(643, 398);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(79, 33);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(558, 398);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(79, 33);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRef);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Location = new System.Drawing.Point(8, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 167);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFornecedor);
            this.groupBox2.Controls.Add(this.txtUndMedida);
            this.groupBox2.Controls.Add(this.cbCategoria);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtlocalizacao);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbSubCategoria);
            this.groupBox2.Location = new System.Drawing.Point(372, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 269);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(104, 163);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(235, 24);
            this.cbFornecedor.TabIndex = 12;
            // 
            // txtUndMedida
            // 
            this.txtUndMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUndMedida.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtUndMedida.Location = new System.Drawing.Point(104, 126);
            this.txtUndMedida.MaxLength = 2;
            this.txtUndMedida.Name = "txtUndMedida";
            this.txtUndMedida.Size = new System.Drawing.Size(90, 23);
            this.txtUndMedida.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label12.Location = new System.Drawing.Point(6, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "Localização";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label10.Location = new System.Drawing.Point(6, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Fornecedor";
            // 
            // txtlocalizacao
            // 
            this.txtlocalizacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlocalizacao.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtlocalizacao.Location = new System.Drawing.Point(104, 210);
            this.txtlocalizacao.Name = "txtlocalizacao";
            this.txtlocalizacao.Size = new System.Drawing.Size(235, 23);
            this.txtlocalizacao.TabIndex = 3;
            // 
            // txtCusto
            // 
            this.txtCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCusto.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtCusto.Location = new System.Drawing.Point(12, 31);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(160, 23);
            this.txtCusto.TabIndex = 3;
            this.txtCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusto_KeyPress);
            this.txtCusto.Leave += new System.EventHandler(this.txtCusto_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Custo";
            // 
            // txtVenda
            // 
            this.txtVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVenda.Enabled = false;
            this.txtVenda.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtVenda.Location = new System.Drawing.Point(12, 78);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(160, 23);
            this.txtVenda.TabIndex = 3;
            this.txtVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenda_KeyPress);
            this.txtVenda.Leave += new System.EventHandler(this.txtVenda_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label7.Location = new System.Drawing.Point(12, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Venda";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtMargemLucro);
            this.groupBox3.Controls.Add(this.txtVenda);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCusto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(8, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Alterar Margem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMargemLucro
            // 
            this.txtMargemLucro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMargemLucro.Enabled = false;
            this.txtMargemLucro.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtMargemLucro.Location = new System.Drawing.Point(182, 31);
            this.txtMargemLucro.Name = "txtMargemLucro";
            this.txtMargemLucro.Size = new System.Drawing.Size(161, 23);
            this.txtMargemLucro.TabIndex = 0;
            this.txtMargemLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMargemLucro_KeyPress);
            this.txtMargemLucro.Leave += new System.EventHandler(this.txtMargemLucro_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label9.Location = new System.Drawing.Point(178, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Margem Lucro%";
            // 
            // pbImagem
            // 
            this.pbImagem.Enabled = false;
            this.pbImagem.Location = new System.Drawing.Point(590, 2);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(127, 14);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 68;
            this.pbImagem.TabStop = false;
            this.pbImagem.Visible = false;
            // 
            // btnAddImagem
            // 
            this.btnAddImagem.Enabled = false;
            this.btnAddImagem.Location = new System.Drawing.Point(558, 2);
            this.btnAddImagem.Name = "btnAddImagem";
            this.btnAddImagem.Size = new System.Drawing.Size(26, 24);
            this.btnAddImagem.TabIndex = 69;
            this.btnAddImagem.Text = "+";
            this.btnAddImagem.UseVisualStyleBackColor = true;
            this.btnAddImagem.Visible = false;
            this.btnAddImagem.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(733, 395);
            this.tabControl1.TabIndex = 70;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btnAddImagem);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pbImagem);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.txtCod);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(725, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 437);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Produtos/Serviços";
            this.Load += new System.EventHandler(this.frmCadProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button btnAddImagem;
        private System.Windows.Forms.TextBox txtUndMedida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMargemLucro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtlocalizacao;
    }
}