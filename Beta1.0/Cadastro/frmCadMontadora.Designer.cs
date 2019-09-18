namespace Promissum.Cadastro
{
    partial class frmCadMontadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadMontadora));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtMontadora = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbMontadora = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAnoFinal = new System.Windows.Forms.TextBox();
            this.txtAnoInicial = new System.Windows.Forms.TextBox();
            this.txtCodModelo = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(401, 201);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnSair);
            this.tabPage1.Controls.Add(this.btnConfirmar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSigla);
            this.tabPage1.Controls.Add(this.txtMontadora);
            this.tabPage1.Controls.Add(this.txtCod);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(393, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mnt-Montadora";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(300, 127);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 36);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(201, 127);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(92, 36);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sigla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Montadora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod";
            // 
            // txtSigla
            // 
            this.txtSigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSigla.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.Location = new System.Drawing.Point(302, 66);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(64, 23);
            this.txtSigla.TabIndex = 0;
            // 
            // txtMontadora
            // 
            this.txtMontadora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontadora.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontadora.Location = new System.Drawing.Point(12, 66);
            this.txtMontadora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMontadora.Name = "txtMontadora";
            this.txtMontadora.Size = new System.Drawing.Size(284, 23);
            this.txtMontadora.TabIndex = 0;
            // 
            // txtCod
            // 
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(44, 7);
            this.txtCod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(79, 23);
            this.txtCod.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.cbMontadora);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtModelo);
            this.tabPage2.Controls.Add(this.txtAnoFinal);
            this.tabPage2.Controls.Add(this.txtAnoInicial);
            this.tabPage2.Controls.Add(this.txtCodModelo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(393, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mnt-Modelo";
            // 
            // cbMontadora
            // 
            this.cbMontadora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbMontadora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMontadora.BackColor = System.Drawing.Color.Cornsilk;
            this.cbMontadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMontadora.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbMontadora.FormattingEnabled = true;
            this.cbMontadora.Location = new System.Drawing.Point(132, 23);
            this.cbMontadora.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbMontadora.Name = "cbMontadora";
            this.cbMontadora.Size = new System.Drawing.Size(255, 24);
            this.cbMontadora.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(300, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(201, 127);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Montadora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ano Final";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ano Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cod";
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(10, 67);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(375, 23);
            this.txtModelo.TabIndex = 2;
            // 
            // txtAnoFinal
            // 
            this.txtAnoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnoFinal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoFinal.Location = new System.Drawing.Point(91, 116);
            this.txtAnoFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnoFinal.Name = "txtAnoFinal";
            this.txtAnoFinal.Size = new System.Drawing.Size(79, 23);
            this.txtAnoFinal.TabIndex = 4;
            // 
            // txtAnoInicial
            // 
            this.txtAnoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnoInicial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoInicial.Location = new System.Drawing.Point(6, 116);
            this.txtAnoInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnoInicial.Name = "txtAnoInicial";
            this.txtAnoInicial.Size = new System.Drawing.Size(79, 23);
            this.txtAnoInicial.TabIndex = 4;
            // 
            // txtCodModelo
            // 
            this.txtCodModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodModelo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodModelo.Location = new System.Drawing.Point(42, 14);
            this.txtCodModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodModelo.Name = "txtCodModelo";
            this.txtCodModelo.Size = new System.Drawing.Size(79, 23);
            this.txtCodModelo.TabIndex = 4;
            // 
            // frmCadMontadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 201);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadMontadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Montadoras-Modelo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtMontadora;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCodModelo;
        private System.Windows.Forms.ComboBox cbMontadora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAnoFinal;
        private System.Windows.Forms.TextBox txtAnoInicial;
    }
}