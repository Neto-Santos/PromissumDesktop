namespace Promissum.Relatorio_Atualizado.Operacao
{
    partial class frmFiltroOperacao
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNs = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(238, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 50;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Cliente";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(59, 12);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(100, 20);
            this.dtInicio.TabIndex = 45;
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Location = new System.Drawing.Point(60, 72);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(256, 20);
            this.txtCliente.TabIndex = 43;
            // 
            // txtServico
            // 
            this.txtServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServico.Location = new System.Drawing.Point(60, 150);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(256, 20);
            this.txtServico.TabIndex = 42;
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(188, 12);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(100, 20);
            this.dtFim.TabIndex = 44;
            // 
            // btnGerarPdf
            // 
            this.btnGerarPdf.BackColor = System.Drawing.Color.Red;
            this.btnGerarPdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGerarPdf.Location = new System.Drawing.Point(187, 41);
            this.btnGerarPdf.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(117, 23);
            this.btnGerarPdf.TabIndex = 49;
            this.btnGerarPdf.Text = "GERAR PDF";
            this.btnGerarPdf.UseVisualStyleBackColor = false;
            this.btnGerarPdf.Click += new System.EventHandler(this.btnGerarPdf_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Item";
            // 
            // txtItem
            // 
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem.Location = new System.Drawing.Point(59, 98);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(256, 20);
            this.txtItem.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "NS";
            // 
            // txtNs
            // 
            this.txtNs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNs.Location = new System.Drawing.Point(59, 124);
            this.txtNs.Name = "txtNs";
            this.txtNs.Size = new System.Drawing.Size(256, 20);
            this.txtNs.TabIndex = 53;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Finalizado",
            "Aberto",
            "Cancelado"});
            this.cbStatus.Location = new System.Drawing.Point(59, 177);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(257, 21);
            this.cbStatus.TabIndex = 55;
            // 
            // frmFiltroOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 242);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.btnGerarPdf);
            this.Name = "frmFiltroOperacao";
            this.Text = "Operação VS Cliente";
            this.Load += new System.EventHandler(this.frmFiltroOperacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Button btnGerarPdf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNs;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}