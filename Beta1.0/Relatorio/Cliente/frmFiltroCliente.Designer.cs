namespace Beta1._0.Relatorio.Cliente
{
    partial class frmFiltroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroCliente));
            this.rbAnalitico = new System.Windows.Forms.RadioButton();
            this.rbSintetico = new System.Windows.Forms.RadioButton();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtServiço = new System.Windows.Forms.TextBox();
            this.txtDefeito = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbCancelado = new System.Windows.Forms.RadioButton();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.rbAberto = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.preVisualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.cbImpressora = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAnalitico
            // 
            this.rbAnalitico.AutoSize = true;
            this.rbAnalitico.Location = new System.Drawing.Point(5, 10);
            this.rbAnalitico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAnalitico.Name = "rbAnalitico";
            this.rbAnalitico.Size = new System.Drawing.Size(74, 20);
            this.rbAnalitico.TabIndex = 0;
            this.rbAnalitico.TabStop = true;
            this.rbAnalitico.Text = "Analítico";
            this.rbAnalitico.UseVisualStyleBackColor = true;
            // 
            // rbSintetico
            // 
            this.rbSintetico.AutoSize = true;
            this.rbSintetico.Location = new System.Drawing.Point(5, 39);
            this.rbSintetico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSintetico.Name = "rbSintetico";
            this.rbSintetico.Size = new System.Drawing.Size(75, 20);
            this.rbSintetico.TabIndex = 0;
            this.rbSintetico.TabStop = true;
            this.rbSintetico.Text = "Sintético";
            this.rbSintetico.UseVisualStyleBackColor = true;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(12, 33);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(118, 23);
            this.dtInicio.TabIndex = 1;
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(138, 33);
            this.dtFim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(118, 23);
            this.dtFim.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFim);
            this.groupBox1.Controls.Add(this.dtInicio);
            this.groupBox1.Location = new System.Drawing.Point(85, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(269, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entre as datas de cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Início";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(310, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "FILTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtServiço);
            this.groupBox2.Controls.Add(this.txtDefeito);
            this.groupBox2.Controls.Add(this.txtRef);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(5, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(382, 301);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // txtServiço
            // 
            this.txtServiço.Location = new System.Drawing.Point(9, 267);
            this.txtServiço.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServiço.Name = "txtServiço";
            this.txtServiço.Size = new System.Drawing.Size(365, 23);
            this.txtServiço.TabIndex = 13;
            // 
            // txtDefeito
            // 
            this.txtDefeito.Location = new System.Drawing.Point(9, 208);
            this.txtDefeito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDefeito.Name = "txtDefeito";
            this.txtDefeito.Size = new System.Drawing.Size(365, 23);
            this.txtDefeito.TabIndex = 13;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(243, 153);
            this.txtRef.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(134, 23);
            this.txtRef.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbTodos);
            this.groupBox3.Controls.Add(this.rbCancelado);
            this.groupBox3.Controls.Add(this.rbFinalizado);
            this.groupBox3.Controls.Add(this.rbAberto);
            this.groupBox3.Location = new System.Drawing.Point(9, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(132, 154);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status Orçamento";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(22, 113);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(61, 20);
            this.rbTodos.TabIndex = 1;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbCancelado
            // 
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Location = new System.Drawing.Point(22, 85);
            this.rbCancelado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCancelado.Name = "rbCancelado";
            this.rbCancelado.Size = new System.Drawing.Size(85, 20);
            this.rbCancelado.TabIndex = 0;
            this.rbCancelado.Text = "Cancelado";
            this.rbCancelado.UseVisualStyleBackColor = true;
            // 
            // rbFinalizado
            // 
            this.rbFinalizado.AutoSize = true;
            this.rbFinalizado.Location = new System.Drawing.Point(22, 57);
            this.rbFinalizado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFinalizado.Name = "rbFinalizado";
            this.rbFinalizado.Size = new System.Drawing.Size(83, 20);
            this.rbFinalizado.TabIndex = 0;
            this.rbFinalizado.Text = "Finalizado";
            this.rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // rbAberto
            // 
            this.rbAberto.AutoSize = true;
            this.rbAberto.Location = new System.Drawing.Point(22, 28);
            this.rbAberto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAberto.Name = "rbAberto";
            this.rbAberto.Size = new System.Drawing.Size(64, 20);
            this.rbAberto.TabIndex = 0;
            this.rbAberto.Text = "Aberto";
            this.rbAberto.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Serviço/Correção Efeutado(a)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Defeito/Problema Apresentado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Referência";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(147, 153);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(76, 23);
            this.txtEstado.TabIndex = 6;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(143, 105);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(234, 23);
            this.txtCidade.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(143, 52);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(234, 23);
            this.txtNome.TabIndex = 8;
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
            this.cbImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImpressora.FormattingEnabled = true;
            this.cbImpressora.Location = new System.Drawing.Point(183, 81);
            this.cbImpressora.Name = "cbImpressora";
            this.cbImpressora.Size = new System.Drawing.Size(199, 24);
            this.cbImpressora.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Impressora";
            // 
            // frmFiltroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(391, 448);
            this.Controls.Add(this.cbImpressora);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbSintetico);
            this.Controls.Add(this.rbAnalitico);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiltroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtragem Cliente";
            this.Load += new System.EventHandler(this.frmFiltroCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAnalitico;
        private System.Windows.Forms.RadioButton rbSintetico;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbCancelado;
        private System.Windows.Forms.RadioButton rbFinalizado;
        private System.Windows.Forms.RadioButton rbAberto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtServiço;
        private System.Windows.Forms.TextBox txtDefeito;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.PrintPreviewDialog preVisualizacao;
        private System.Windows.Forms.ComboBox cbImpressora;
        private System.Windows.Forms.Label label9;
    }
}