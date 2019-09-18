using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidade;
using BLL;
using DAL;
using Ferramentas;
namespace Beta1._0.Os
{
    partial class frmCadastroOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroOrcamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsultaProduto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbProduto = new System.Windows.Forms.Label();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.lbCodProduto = new System.Windows.Forms.Label();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.rbAberto = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtDataSaida = new System.Windows.Forms.DateTimePicker();
            this.dtHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.dtHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOperacao = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvItensVenda = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbValores = new System.Windows.Forms.GroupBox();
            this.txtTotalProduto = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtDescontoReal = new System.Windows.Forms.TextBox();
            this.txtVlrBase = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnConfirmaOrcamento = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbLembreteEnviado = new System.Windows.Forms.RadioButton();
            this.rbLembretePendente = new System.Windows.Forms.RadioButton();
            this.nupdDiasEmail = new System.Windows.Forms.NumericUpDown();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtServicoEfetuado = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDefeitoApresentado = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbValores.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDiasEmail)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnConsultaProduto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbProduto);
            this.groupBox1.Controls.Add(this.txtkm);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtCodProduto);
            this.groupBox1.Controls.Add(this.lbCodProduto);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(7, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1104, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Image = global::Promissum.Properties.Resources.car_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(950, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lançar Veículo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsultaProduto
            // 
            this.btnConsultaProduto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultaProduto.Image = global::Promissum.Properties.Resources.lupa;
            this.btnConsultaProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaProduto.Location = new System.Drawing.Point(113, 12);
            this.btnConsultaProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultaProduto.Name = "btnConsultaProduto";
            this.btnConsultaProduto.Size = new System.Drawing.Size(98, 28);
            this.btnConsultaProduto.TabIndex = 2;
            this.btnConsultaProduto.Text = "Pesquisar";
            this.btnConsultaProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultaProduto.UseVisualStyleBackColor = false;
            this.btnConsultaProduto.Click += new System.EventHandler(this.btnConsultaProduto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(217, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Produto";
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduto.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbProduto.Location = new System.Drawing.Point(288, 16);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(65, 20);
            this.lbProduto.TabIndex = 1;
            this.lbProduto.Text = "Produto";
            // 
            // txtkm
            // 
            this.txtkm.BackColor = System.Drawing.Color.Cornsilk;
            this.txtkm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkm.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtkm.Location = new System.Drawing.Point(635, 15);
            this.txtkm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(108, 23);
            this.txtkm.TabIndex = 1;
            this.txtkm.Visible = false;
            this.txtkm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkm_KeyPress);
            this.txtkm.Leave += new System.EventHandler(this.txtkm_Leave);
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.Cornsilk;
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaca.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtPlaca.Location = new System.Drawing.Point(825, 15);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(89, 23);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.Visible = false;
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label20.Location = new System.Drawing.Point(600, 16);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "KM";
            this.label20.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label19.Location = new System.Drawing.Point(775, 16);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Placa";
            this.label19.Visible = false;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCodProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodProduto.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtCodProduto.Location = new System.Drawing.Point(50, 15);
            this.txtCodProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(57, 23);
            this.txtCodProduto.TabIndex = 1;
            // 
            // lbCodProduto
            // 
            this.lbCodProduto.AutoSize = true;
            this.lbCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodProduto.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbCodProduto.Location = new System.Drawing.Point(6, 16);
            this.lbCodProduto.Name = "lbCodProduto";
            this.lbCodProduto.Size = new System.Drawing.Size(38, 20);
            this.lbCodProduto.TabIndex = 0;
            this.lbCodProduto.Text = "Cod";
            // 
            // rbFinalizado
            // 
            this.rbFinalizado.AutoSize = true;
            this.rbFinalizado.Location = new System.Drawing.Point(595, 60);
            this.rbFinalizado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFinalizado.Name = "rbFinalizado";
            this.rbFinalizado.Size = new System.Drawing.Size(83, 20);
            this.rbFinalizado.TabIndex = 2;
            this.rbFinalizado.Text = "Finalizado";
            this.rbFinalizado.UseVisualStyleBackColor = true;
            this.rbFinalizado.Click += new System.EventHandler(this.rbFinalizado_Click);
            // 
            // rbAberto
            // 
            this.rbAberto.AutoSize = true;
            this.rbAberto.Checked = true;
            this.rbAberto.Location = new System.Drawing.Point(595, 31);
            this.rbAberto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAberto.Name = "rbAberto";
            this.rbAberto.Size = new System.Drawing.Size(64, 20);
            this.rbAberto.TabIndex = 1;
            this.rbAberto.TabStop = true;
            this.rbAberto.Text = "Aberto";
            this.rbAberto.UseVisualStyleBackColor = true;
            this.rbAberto.Click += new System.EventHandler(this.rbAberto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFinalizado);
            this.groupBox2.Controls.Add(this.rbAberto);
            this.groupBox2.Controls.Add(this.dtDataSaida);
            this.groupBox2.Controls.Add(this.dtHoraSaida);
            this.groupBox2.Controls.Add(this.dtHoraEntrada);
            this.groupBox2.Controls.Add(this.dtDataEntrada);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtCodCliente);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbCliente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1104, 101);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dtDataSaida
            // 
            this.dtDataSaida.Enabled = false;
            this.dtDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataSaida.Location = new System.Drawing.Point(763, 60);
            this.dtDataSaida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtDataSaida.Name = "dtDataSaida";
            this.dtDataSaida.Size = new System.Drawing.Size(122, 26);
            this.dtDataSaida.TabIndex = 3;
            this.dtDataSaida.ValueChanged += new System.EventHandler(this.dtDataSaida_ValueChanged);
            // 
            // dtHoraSaida
            // 
            this.dtHoraSaida.Enabled = false;
            this.dtHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraSaida.Location = new System.Drawing.Point(961, 60);
            this.dtHoraSaida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtHoraSaida.Name = "dtHoraSaida";
            this.dtHoraSaida.Size = new System.Drawing.Size(122, 26);
            this.dtHoraSaida.TabIndex = 3;
            // 
            // dtHoraEntrada
            // 
            this.dtHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraEntrada.Location = new System.Drawing.Point(961, 23);
            this.dtHoraEntrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtHoraEntrada.Name = "dtHoraEntrada";
            this.dtHoraEntrada.Size = new System.Drawing.Size(122, 26);
            this.dtHoraEntrada.TabIndex = 3;
            // 
            // dtDataEntrada
            // 
            this.dtDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataEntrada.Location = new System.Drawing.Point(765, 22);
            this.dtDataEntrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtDataEntrada.Name = "dtDataEntrada";
            this.dtDataEntrada.Size = new System.Drawing.Size(122, 26);
            this.dtDataEntrada.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(901, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Hora";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(10, 34);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(76, 26);
            this.txtCodCliente.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(901, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Hora";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(698, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Saída";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Image = global::Promissum.Properties.Resources.lupa;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(96, 34);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 28);
            this.button5.TabIndex = 0;
            this.button5.Text = "Pesquisar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(679, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Entrada";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(190, 38);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(58, 20);
            this.lbCliente.TabIndex = 1;
            this.lbCliente.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "OS";
            // 
            // cbOperacao
            // 
            this.cbOperacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbOperacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOperacao.BackColor = System.Drawing.Color.Cornsilk;
            this.cbOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperacao.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbOperacao.FormattingEnabled = true;
            this.cbOperacao.Location = new System.Drawing.Point(8, 54);
            this.cbOperacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbOperacao.Name = "cbOperacao";
            this.cbOperacao.Size = new System.Drawing.Size(290, 24);
            this.cbOperacao.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label18.Location = new System.Drawing.Point(2, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "Operação";
            // 
            // dgvItensVenda
            // 
            this.dgvItensVenda.AllowUserToAddRows = false;
            this.dgvItensVenda.AllowUserToDeleteRows = false;
            this.dgvItensVenda.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvItensVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.Ref,
            this.Operacao,
            this.Produto,
            this.Quantidade,
            this.ValorBase,
            this.Desconto,
            this.ValorUn,
            this.Total,
            this.CodOperacao});
            this.dgvItensVenda.Location = new System.Drawing.Point(7, 271);
            this.dgvItensVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvItensVenda.Name = "dgvItensVenda";
            this.dgvItensVenda.ReadOnly = true;
            this.dgvItensVenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvItensVenda.RowHeadersVisible = false;
            this.dgvItensVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensVenda.Size = new System.Drawing.Size(1104, 259);
            this.dgvItensVenda.TabIndex = 5;
            this.dgvItensVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItensVenda_CellDoubleClick);
            // 
            // cod
            // 
            this.cod.HeaderText = "Codigo";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 50;
            // 
            // Ref
            // 
            this.Ref.HeaderText = "Ref";
            this.Ref.Name = "Ref";
            this.Ref.ReadOnly = true;
            // 
            // Operacao
            // 
            this.Operacao.HeaderText = "Operação";
            this.Operacao.Name = "Operacao";
            this.Operacao.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 300;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ValorBase
            // 
            this.ValorBase.HeaderText = "Valor Un";
            this.ValorBase.Name = "ValorBase";
            this.ValorBase.ReadOnly = true;
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            this.Desconto.ReadOnly = true;
            // 
            // ValorUn
            // 
            this.ValorUn.HeaderText = "ValorUn";
            this.ValorUn.Name = "ValorUn";
            this.ValorUn.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 150;
            // 
            // CodOperacao
            // 
            this.CodOperacao.HeaderText = "CodOperacao";
            this.CodOperacao.Name = "CodOperacao";
            this.CodOperacao.ReadOnly = true;
            this.CodOperacao.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(754, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Cornsilk;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTotal.Location = new System.Drawing.Point(815, 533);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(287, 26);
            this.txtTotal.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1129, 592);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbValores);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgvItensVenda);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.btnConfirmaOrcamento);
            this.tabPage1.Controls.Add(this.txtTotal);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1121, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbValores
            // 
            this.gbValores.Controls.Add(this.cbOperacao);
            this.gbValores.Controls.Add(this.txtTotalProduto);
            this.gbValores.Controls.Add(this.btnExcluir);
            this.gbValores.Controls.Add(this.txtDescontoReal);
            this.gbValores.Controls.Add(this.txtVlrBase);
            this.gbValores.Controls.Add(this.txtPrecoUnitario);
            this.gbValores.Controls.Add(this.btnAddProduto);
            this.gbValores.Controls.Add(this.txtQuantidade);
            this.gbValores.Controls.Add(this.txtDesconto);
            this.gbValores.Controls.Add(this.label10);
            this.gbValores.Controls.Add(this.label17);
            this.gbValores.Controls.Add(this.label12);
            this.gbValores.Controls.Add(this.label9);
            this.gbValores.Controls.Add(this.label18);
            this.gbValores.Controls.Add(this.label8);
            this.gbValores.Controls.Add(this.label6);
            this.gbValores.Enabled = false;
            this.gbValores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbValores.Location = new System.Drawing.Point(7, 174);
            this.gbValores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbValores.Name = "gbValores";
            this.gbValores.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbValores.Size = new System.Drawing.Size(1104, 95);
            this.gbValores.TabIndex = 2;
            this.gbValores.TabStop = false;
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.BackColor = System.Drawing.Color.Cornsilk;
            this.txtTotalProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalProduto.Enabled = false;
            this.txtTotalProduto.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtTotalProduto.Location = new System.Drawing.Point(860, 55);
            this.txtTotalProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.Size = new System.Drawing.Size(125, 23);
            this.txtTotalProduto.TabIndex = 6;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluir.Image = global::Promissum.Properties.Resources.deletee;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(993, 59);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 32);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtDescontoReal
            // 
            this.txtDescontoReal.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDescontoReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescontoReal.Enabled = false;
            this.txtDescontoReal.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDescontoReal.Location = new System.Drawing.Point(503, 55);
            this.txtDescontoReal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescontoReal.Name = "txtDescontoReal";
            this.txtDescontoReal.Size = new System.Drawing.Size(76, 23);
            this.txtDescontoReal.TabIndex = 3;
            this.txtDescontoReal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoUnitario_KeyPress);
            // 
            // txtVlrBase
            // 
            this.txtVlrBase.BackColor = System.Drawing.Color.Cornsilk;
            this.txtVlrBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVlrBase.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtVlrBase.Location = new System.Drawing.Point(589, 55);
            this.txtVlrBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVlrBase.Name = "txtVlrBase";
            this.txtVlrBase.Size = new System.Drawing.Size(125, 23);
            this.txtVlrBase.TabIndex = 4;
            this.txtVlrBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoUnitario_KeyPress);
            this.txtVlrBase.Leave += new System.EventHandler(this.txtVlrBase_Leave);
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.BackColor = System.Drawing.Color.Cornsilk;
            this.txtPrecoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoUnitario.Enabled = false;
            this.txtPrecoUnitario.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtPrecoUnitario.Location = new System.Drawing.Point(724, 55);
            this.txtPrecoUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(125, 23);
            this.txtPrecoUnitario.TabIndex = 5;
            this.txtPrecoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoUnitario_KeyPress);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddProduto.Image = global::Promissum.Properties.Resources.confirmm1;
            this.btnAddProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduto.Location = new System.Drawing.Point(993, 20);
            this.btnAddProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(100, 32);
            this.btnAddProduto.TabIndex = 7;
            this.btnAddProduto.Text = "Confirmar";
            this.btnAddProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduto.UseVisualStyleBackColor = false;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.Cornsilk;
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtQuantidade.Location = new System.Drawing.Point(304, 55);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(89, 23);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtDesconto.Location = new System.Drawing.Point(404, 55);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(89, 23);
            this.txtDesconto.TabIndex = 2;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Location = new System.Drawing.Point(868, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Total Produto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label17.Location = new System.Drawing.Point(617, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 27;
            this.label17.Text = "Vlr Base";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label12.Location = new System.Drawing.Point(509, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "DescR$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(730, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Preço Unitário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(406, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Desconto%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(301, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Quantidade";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button9.Location = new System.Drawing.Point(244, 532);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 28);
            this.button9.TabIndex = 13;
            this.button9.Text = "Sair";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(128, 532);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 28);
            this.button8.TabIndex = 13;
            this.button8.Text = "Imprimir";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnConfirmaOrcamento
            // 
            this.btnConfirmaOrcamento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConfirmaOrcamento.Image = global::Promissum.Properties.Resources.confirmm;
            this.btnConfirmaOrcamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaOrcamento.Location = new System.Drawing.Point(13, 532);
            this.btnConfirmaOrcamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmaOrcamento.Name = "btnConfirmaOrcamento";
            this.btnConfirmaOrcamento.Size = new System.Drawing.Size(87, 28);
            this.btnConfirmaOrcamento.TabIndex = 13;
            this.btnConfirmaOrcamento.Text = "Confirmar";
            this.btnConfirmaOrcamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmaOrcamento.UseVisualStyleBackColor = false;
            this.btnConfirmaOrcamento.Click += new System.EventHandler(this.btnConfirmaOrcamento_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1121, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Observações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(12, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(1098, 210);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AVISO";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbLembreteEnviado);
            this.groupBox5.Controls.Add(this.rbLembretePendente);
            this.groupBox5.Controls.Add(this.nupdDiasEmail);
            this.groupBox5.Controls.Add(this.txtEmail);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.Location = new System.Drawing.Point(156, 22);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(810, 181);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // rbLembreteEnviado
            // 
            this.rbLembreteEnviado.AutoSize = true;
            this.rbLembreteEnviado.Location = new System.Drawing.Point(553, 43);
            this.rbLembreteEnviado.Name = "rbLembreteEnviado";
            this.rbLembreteEnviado.Size = new System.Drawing.Size(128, 20);
            this.rbLembreteEnviado.TabIndex = 8;
            this.rbLembreteEnviado.Text = "Lembrete Enviado";
            this.rbLembreteEnviado.UseVisualStyleBackColor = true;
            // 
            // rbLembretePendente
            // 
            this.rbLembretePendente.AutoSize = true;
            this.rbLembretePendente.Checked = true;
            this.rbLembretePendente.Location = new System.Drawing.Point(410, 43);
            this.rbLembretePendente.Name = "rbLembretePendente";
            this.rbLembretePendente.Size = new System.Drawing.Size(137, 20);
            this.rbLembretePendente.TabIndex = 7;
            this.rbLembretePendente.TabStop = true;
            this.rbLembretePendente.Text = "Lembrete Pendente";
            this.rbLembretePendente.UseVisualStyleBackColor = true;
            // 
            // nupdDiasEmail
            // 
            this.nupdDiasEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupdDiasEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdDiasEmail.Location = new System.Drawing.Point(169, 39);
            this.nupdDiasEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nupdDiasEmail.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupdDiasEmail.Name = "nupdDiasEmail";
            this.nupdDiasEmail.Size = new System.Drawing.Size(88, 26);
            this.nupdDiasEmail.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(9, 121);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(784, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Email a Ser Enviado o Aviso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dias depois";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Próxima Manutenção";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtServicoEfetuado);
            this.groupBox7.Location = new System.Drawing.Point(9, 384);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(1104, 160);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Histórico do Serviço Efetuado";
            // 
            // txtServicoEfetuado
            // 
            this.txtServicoEfetuado.BackColor = System.Drawing.Color.Cornsilk;
            this.txtServicoEfetuado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServicoEfetuado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServicoEfetuado.Location = new System.Drawing.Point(3, 20);
            this.txtServicoEfetuado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServicoEfetuado.Name = "txtServicoEfetuado";
            this.txtServicoEfetuado.Size = new System.Drawing.Size(1098, 136);
            this.txtServicoEfetuado.TabIndex = 0;
            this.txtServicoEfetuado.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDefeitoApresentado);
            this.groupBox3.Location = new System.Drawing.Point(9, 221);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1104, 159);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Defeito/Problema Apresentado";
            // 
            // txtDefeitoApresentado
            // 
            this.txtDefeitoApresentado.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDefeitoApresentado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDefeitoApresentado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefeitoApresentado.Location = new System.Drawing.Point(3, 20);
            this.txtDefeitoApresentado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDefeitoApresentado.Name = "txtDefeitoApresentado";
            this.txtDefeitoApresentado.Size = new System.Drawing.Size(1098, 135);
            this.txtDefeitoApresentado.TabIndex = 0;
            this.txtDefeitoApresentado.Text = "";
            // 
            // frmCadastroOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1129, 592);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCadastroOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento";
            this.Load += new System.EventHandler(this.frmCadastroOrcamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbValores.ResumeLayout(false);
            this.gbValores.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDiasEmail)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultaProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItensVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtDefeitoApresentado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbValores;
        private System.Windows.Forms.TextBox txtTotalProduto;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox txtServicoEfetuado;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnConfirmaOrcamento;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label lbCodProduto;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker dtDataSaida;
        private System.Windows.Forms.DateTimePicker dtHoraSaida;
        private System.Windows.Forms.DateTimePicker dtHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtDataEntrada;
        private System.Windows.Forms.NumericUpDown nupdDiasEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbFinalizado;
        private System.Windows.Forms.RadioButton rbAberto;
        private System.Windows.Forms.TextBox txtDescontoReal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVlrBase;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbOperacao;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodOperacao;
        private RadioButton rbLembreteEnviado;
        private RadioButton rbLembretePendente;
        private Button button1;
        private TextBox txtPlaca;
        private Label label19;
        private TextBox txtkm;
        private Label label20;
    }
}