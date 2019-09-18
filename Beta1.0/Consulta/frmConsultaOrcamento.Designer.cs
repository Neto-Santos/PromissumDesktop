namespace Beta1._0.Consulta
{
    partial class frmConsultaOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaOrcamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbImpressora = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbOperacao = new System.Windows.Forms.RadioButton();
            this.rbCancelado = new System.Windows.Forms.RadioButton();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.rbAberto = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgOrcamento = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.preVisualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamento)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerarPdf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbImpressora);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(628, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(233, 543);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Impressora";
            // 
            // cbImpressora
            // 
            this.cbImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImpressora.FormattingEnabled = true;
            this.cbImpressora.Location = new System.Drawing.Point(115, 525);
            this.cbImpressora.Name = "cbImpressora";
            this.cbImpressora.Size = new System.Drawing.Size(118, 24);
            this.cbImpressora.TabIndex = 4;
            this.cbImpressora.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOperacao);
            this.groupBox2.Controls.Add(this.rbCancelado);
            this.groupBox2.Controls.Add(this.rbFinalizado);
            this.groupBox2.Controls.Add(this.rbAberto);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(9, 120);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(218, 192);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PESQUISA";
            // 
            // rbOperacao
            // 
            this.rbOperacao.AutoSize = true;
            this.rbOperacao.Location = new System.Drawing.Point(7, 95);
            this.rbOperacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbOperacao.Name = "rbOperacao";
            this.rbOperacao.Size = new System.Drawing.Size(81, 20);
            this.rbOperacao.TabIndex = 3;
            this.rbOperacao.Text = "Operação";
            this.rbOperacao.UseVisualStyleBackColor = true;
            this.rbOperacao.Visible = false;
            // 
            // rbCancelado
            // 
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Location = new System.Drawing.Point(7, 47);
            this.rbCancelado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCancelado.Name = "rbCancelado";
            this.rbCancelado.Size = new System.Drawing.Size(85, 20);
            this.rbCancelado.TabIndex = 2;
            this.rbCancelado.Text = "Cancelado";
            this.rbCancelado.UseVisualStyleBackColor = true;
            // 
            // rbFinalizado
            // 
            this.rbFinalizado.AutoSize = true;
            this.rbFinalizado.Location = new System.Drawing.Point(7, 71);
            this.rbFinalizado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFinalizado.Name = "rbFinalizado";
            this.rbFinalizado.Size = new System.Drawing.Size(83, 20);
            this.rbFinalizado.TabIndex = 1;
            this.rbFinalizado.Text = "Finalizado";
            this.rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // rbAberto
            // 
            this.rbAberto.AutoSize = true;
            this.rbAberto.Checked = true;
            this.rbAberto.Location = new System.Drawing.Point(7, 23);
            this.rbAberto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAberto.Name = "rbAberto";
            this.rbAberto.Size = new System.Drawing.Size(64, 20);
            this.rbAberto.TabIndex = 0;
            this.rbAberto.TabStop = true;
            this.rbAberto.Text = "Aberto";
            this.rbAberto.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 123);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(202, 23);
            this.txtNome.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(122, 154);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "FILTRAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Promissum.Properties.Resources.print;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(122, 17);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 52);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(7, 84);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(7, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(7, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 572);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgOrcamento);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(609, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movimentações";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgOrcamento
            // 
            this.dgOrcamento.AllowUserToAddRows = false;
            this.dgOrcamento.AllowUserToDeleteRows = false;
            this.dgOrcamento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrcamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrcamento.Location = new System.Drawing.Point(3, 4);
            this.dgOrcamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgOrcamento.Name = "dgOrcamento";
            this.dgOrcamento.ReadOnly = true;
            this.dgOrcamento.RowHeadersVisible = false;
            this.dgOrcamento.Size = new System.Drawing.Size(603, 535);
            this.dgOrcamento.TabIndex = 6;
            this.dgOrcamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrcamento_CellClick);
            this.dgOrcamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrcamento_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvItens);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(609, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Itens";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.Location = new System.Drawing.Point(3, 4);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.Size = new System.Drawing.Size(603, 535);
            this.dgvItens.TabIndex = 0;
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
            this.btnGerarPdf.Location = new System.Drawing.Point(101, 87);
            this.btnGerarPdf.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(117, 23);
            this.btnGerarPdf.TabIndex = 19;
            this.btnGerarPdf.Text = "GERAR PDF";
            this.btnGerarPdf.UseVisualStyleBackColor = false;
            this.btnGerarPdf.Click += new System.EventHandler(this.btnGerarPdf_Click);
            // 
            // frmConsultaOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 572);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmConsultaOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            this.Load += new System.EventHandler(this.frmConsultaOrcamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrcamento)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCancelado;
        private System.Windows.Forms.RadioButton rbFinalizado;
        private System.Windows.Forms.RadioButton rbAberto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView dgOrcamento;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.RadioButton rbOperacao;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.PrintPreviewDialog preVisualizacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbImpressora;
        private System.Windows.Forms.Button btnGerarPdf;
    }
}