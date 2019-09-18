namespace Beta1._0.Cadastro
{
    partial class frmCadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCliente));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbJuridico = new System.Windows.Forms.RadioButton();
            this.rbFisico = new System.Windows.Forms.RadioButton();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.RichTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.dtCadastro = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ckbBuscarCep = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(614, 411);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(79, 33);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(699, 411);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(79, 33);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 406);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.ckbBuscarCep);
            this.tabPage1.Controls.Add(this.rbJuridico);
            this.tabPage1.Controls.Add(this.rbFisico);
            this.tabPage1.Controls.Add(this.txtCelular);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtObservacao);
            this.tabPage1.Controls.Add(this.txtTelefone);
            this.tabPage1.Controls.Add(this.txtCnpj);
            this.tabPage1.Controls.Add(this.txtCpf);
            this.tabPage1.Controls.Add(this.txtCep);
            this.tabPage1.Controls.Add(this.dtCadastro);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCod);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.txtRg);
            this.tabPage1.Controls.Add(this.txtEstado);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(this.txtCidade);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            // 
            // rbJuridico
            // 
            this.rbJuridico.AutoSize = true;
            this.rbJuridico.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.rbJuridico.Location = new System.Drawing.Point(529, 21);
            this.rbJuridico.Name = "rbJuridico";
            this.rbJuridico.Size = new System.Drawing.Size(69, 20);
            this.rbJuridico.TabIndex = 61;
            this.rbJuridico.TabStop = true;
            this.rbJuridico.Text = "Jurídica";
            this.rbJuridico.UseVisualStyleBackColor = true;
            this.rbJuridico.Click += new System.EventHandler(this.rbJuridico_Click);
            // 
            // rbFisico
            // 
            this.rbFisico.AutoSize = true;
            this.rbFisico.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.rbFisico.Location = new System.Drawing.Point(469, 22);
            this.rbFisico.Name = "rbFisico";
            this.rbFisico.Size = new System.Drawing.Size(58, 20);
            this.rbFisico.TabIndex = 61;
            this.rbFisico.TabStop = true;
            this.rbFisico.Text = "Física";
            this.rbFisico.UseVisualStyleBackColor = true;
            this.rbFisico.Click += new System.EventHandler(this.rbFisico_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelular.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtCelular.Location = new System.Drawing.Point(271, 231);
            this.txtCelular.Mask = "(99) 9 9999-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(143, 23);
            this.txtCelular.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label15.Location = new System.Drawing.Point(267, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 59;
            this.label15.Text = "Celular";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtObservacao.Location = new System.Drawing.Point(6, 295);
            this.txtObservacao.MaxLength = 95;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(761, 71);
            this.txtObservacao.TabIndex = 13;
            this.txtObservacao.Text = "";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTelefone.Location = new System.Drawing.Point(106, 231);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(143, 23);
            this.txtTelefone.TabIndex = 10;
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnpj.Enabled = false;
            this.txtCnpj.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtCnpj.Location = new System.Drawing.Point(603, 72);
            this.txtCnpj.Mask = "99,999,999/9999-99";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(154, 23);
            this.txtCnpj.TabIndex = 3;
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Enabled = false;
            this.txtCpf.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtCpf.Location = new System.Drawing.Point(465, 72);
            this.txtCpf.Mask = "999,999,999-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(134, 23);
            this.txtCpf.TabIndex = 2;
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtCep.Location = new System.Drawing.Point(6, 231);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(94, 23);
            this.txtCep.TabIndex = 9;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // dtCadastro
            // 
            this.dtCadastro.Enabled = false;
            this.dtCadastro.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCadastro.Location = new System.Drawing.Point(641, 23);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Size = new System.Drawing.Size(129, 23);
            this.dtCadastro.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.Location = new System.Drawing.Point(636, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Cód";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.Location = new System.Drawing.Point(196, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Endereço";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label11.Location = new System.Drawing.Point(6, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Observação";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label10.Location = new System.Drawing.Point(102, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "Cep";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.Location = new System.Drawing.Point(702, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Estado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label12.Location = new System.Drawing.Point(420, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label13.Location = new System.Drawing.Point(6, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 44;
            this.label13.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label7.Location = new System.Drawing.Point(283, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Cidade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label14.Location = new System.Drawing.Point(599, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 16);
            this.label14.TabIndex = 42;
            this.label14.Text = "Cnpj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.Location = new System.Drawing.Point(465, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cpf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome";
            // 
            // txtCod
            // 
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtCod.Location = new System.Drawing.Point(6, 22);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(65, 23);
            this.txtCod.TabIndex = 0;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtEndereco.Location = new System.Drawing.Point(200, 125);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(488, 23);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtRg.Location = new System.Drawing.Point(6, 123);
            this.txtRg.MaxLength = 10;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(184, 23);
            this.txtRg.TabIndex = 4;
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtEstado.Location = new System.Drawing.Point(702, 177);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(65, 23);
            this.txtEstado.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(424, 231);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 23);
            this.txtEmail.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtBairro.Location = new System.Drawing.Point(6, 177);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(251, 23);
            this.txtBairro.TabIndex = 6;
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtCidade.Location = new System.Drawing.Point(287, 177);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(401, 23);
            this.txtCidade.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(6, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(448, 23);
            this.txtNome.TabIndex = 1;
            // 
            // ckbBuscarCep
            // 
            this.ckbBuscarCep.AutoSize = true;
            this.ckbBuscarCep.Location = new System.Drawing.Point(41, 209);
            this.ckbBuscarCep.Name = "ckbBuscarCep";
            this.ckbBuscarCep.Size = new System.Drawing.Size(59, 17);
            this.ckbBuscarCep.TabIndex = 62;
            this.ckbBuscarCep.Text = "Buscar";
            this.ckbBuscarCep.UseVisualStyleBackColor = true;
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Clientes";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox txtObservacao;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.DateTimePicker dtCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbJuridico;
        private System.Windows.Forms.RadioButton rbFisico;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ckbBuscarCep;
    }
}