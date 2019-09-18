namespace Beta1._0
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRelatorios = new System.Windows.Forms.ComboBox();
            this.cbVendas = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnConsultaRapida = new System.Windows.Forms.Button();
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.cbFinanceiro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusUsuario,
            this.statusDataHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1258, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.LawnGreen;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 19);
            this.toolStripStatusLabel1.Text = "Licença Validada";
            // 
            // statusUsuario
            // 
            this.statusUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.statusUsuario.ForeColor = System.Drawing.Color.LawnGreen;
            this.statusUsuario.Name = "statusUsuario";
            this.statusUsuario.Size = new System.Drawing.Size(68, 19);
            this.statusUsuario.Text = "Usuário: ";
            // 
            // statusDataHora
            // 
            this.statusDataHora.BackColor = System.Drawing.Color.Transparent;
            this.statusDataHora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusDataHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusDataHora.Margin = new System.Windows.Forms.Padding(800, 3, 0, 2);
            this.statusDataHora.Name = "statusDataHora";
            this.statusDataHora.Size = new System.Drawing.Size(58, 19);
            this.statusDataHora.Text = "dataHora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.cbFinanceiro);
            this.panel1.Controls.Add(this.cbRelatorios);
            this.panel1.Controls.Add(this.cbVendas);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 483);
            this.panel1.TabIndex = 5;
            // 
            // cbRelatorios
            // 
            this.cbRelatorios.BackColor = System.Drawing.Color.DodgerBlue;
            this.cbRelatorios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRelatorios.ForeColor = System.Drawing.Color.White;
            this.cbRelatorios.FormattingEnabled = true;
            this.cbRelatorios.Items.AddRange(new object[] {
            "CADASTRO",
            "CLIENTE",
            "PRODUTO",
            "UNIDADE",
            "CATEGORIA",
            "SUBCATEGORIA"});
            this.cbRelatorios.Location = new System.Drawing.Point(3, 75);
            this.cbRelatorios.Name = "cbRelatorios";
            this.cbRelatorios.Size = new System.Drawing.Size(190, 24);
            this.cbRelatorios.TabIndex = 4;
            this.cbRelatorios.Tag = "";
            this.cbRelatorios.SelectedIndexChanged += new System.EventHandler(this.cbRelatorios_SelectedIndexChanged);
            // 
            // cbVendas
            // 
            this.cbVendas.BackColor = System.Drawing.Color.DodgerBlue;
            this.cbVendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVendas.ForeColor = System.Drawing.Color.White;
            this.cbVendas.FormattingEnabled = true;
            this.cbVendas.Items.AddRange(new object[] {
            "CADASTRO",
            "CLIENTE",
            "PRODUTO",
            "UNIDADE",
            "CATEGORIA",
            "SUBCATEGORIA"});
            this.cbVendas.Location = new System.Drawing.Point(3, 45);
            this.cbVendas.Name = "cbVendas";
            this.cbVendas.Size = new System.Drawing.Size(190, 24);
            this.cbVendas.TabIndex = 2;
            this.cbVendas.Tag = "";
            this.cbVendas.SelectedIndexChanged += new System.EventHandler(this.cbVendas_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "CADASTRO",
            "CLIENTE",
            "PRODUTO",
            "UNIDADE",
            "CATEGORIA",
            "SUBCATEGORIA"});
            this.comboBox2.Location = new System.Drawing.Point(3, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(190, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Tag = "";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(355, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bloquear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.Transparent;
            this.btnSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSobre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(277, 3);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 31);
            this.btnSobre.TabIndex = 3;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(433, 3);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 31);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(511, 3);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 31);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnConsultaRapida
            // 
            this.btnConsultaRapida.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultaRapida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultaRapida.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultaRapida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaRapida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaRapida.Location = new System.Drawing.Point(199, 3);
            this.btnConsultaRapida.Name = "btnConsultaRapida";
            this.btnConsultaRapida.Size = new System.Drawing.Size(75, 31);
            this.btnConsultaRapida.TabIndex = 3;
            this.btnConsultaRapida.Text = "Consulta Rápida";
            this.btnConsultaRapida.UseVisualStyleBackColor = false;
            this.btnConsultaRapida.Click += new System.EventHandler(this.btnConsultaRapida_Click);
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.BackColor = System.Drawing.Color.Goldenrod;
            this.pnCabecalho.Controls.Add(this.label1);
            this.pnCabecalho.Controls.Add(this.btnFechar);
            this.pnCabecalho.Controls.Add(this.btnMaximizar);
            this.pnCabecalho.Controls.Add(this.btnMinimizar);
            this.pnCabecalho.Controls.Add(this.btnSobre);
            this.pnCabecalho.Controls.Add(this.btnConsultaRapida);
            this.pnCabecalho.Controls.Add(this.button1);
            this.pnCabecalho.Controls.Add(this.btnConfig);
            this.pnCabecalho.Controls.Add(this.btnBackup);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(1258, 39);
            this.pnCabecalho.TabIndex = 7;
            this.pnCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseMove);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImage = global::Promissum.Properties.Resources.icone_fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1192, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(62, 38);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Promissum.Properties.Resources.icone_maximizar;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(1120, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(75, 30);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::Promissum.Properties.Resources.icone_minimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(1075, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(39, 23);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // cbFinanceiro
            // 
            this.cbFinanceiro.BackColor = System.Drawing.Color.DodgerBlue;
            this.cbFinanceiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFinanceiro.ForeColor = System.Drawing.Color.White;
            this.cbFinanceiro.FormattingEnabled = true;
            this.cbFinanceiro.Items.AddRange(new object[] {
            "CADASTRO",
            "CLIENTE",
            "PRODUTO",
            "UNIDADE",
            "CATEGORIA",
            "SUBCATEGORIA"});
            this.cbFinanceiro.Location = new System.Drawing.Point(3, 105);
            this.cbFinanceiro.Name = "cbFinanceiro";
            this.cbFinanceiro.Size = new System.Drawing.Size(190, 24);
            this.cbFinanceiro.TabIndex = 5;
            this.cbFinanceiro.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "PromissumSystem";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnCabecalho);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promissum";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel statusUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel statusDataHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbVendas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbRelatorios;
        private System.Windows.Forms.Button btnConsultaRapida;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Panel pnCabecalho;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.ComboBox cbFinanceiro;
        private System.Windows.Forms.Label label1;
    }
}

