namespace Beta1._0.Consulta
{
    partial class frmConsultaOperacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaOperacao));
            this.dgOperacao = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOperacao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgOperacao
            // 
            this.dgOperacao.AllowUserToAddRows = false;
            this.dgOperacao.AllowUserToDeleteRows = false;
            this.dgOperacao.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgOperacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgOperacao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgOperacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgOperacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.Operacao});
            this.dgOperacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgOperacao.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgOperacao.Location = new System.Drawing.Point(0, 0);
            this.dgOperacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgOperacao.Name = "dgOperacao";
            this.dgOperacao.ReadOnly = true;
            this.dgOperacao.RowHeadersVisible = false;
            this.dgOperacao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgOperacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOperacao.Size = new System.Drawing.Size(406, 217);
            this.dgOperacao.TabIndex = 5;
            this.dgOperacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOperaca_CellContentClick);
            // 
            // cod
            // 
            this.cod.DataPropertyName = "Codigo";
            this.cod.HeaderText = "Código";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 72;
            // 
            // Operacao
            // 
            this.Operacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Operacao.DataPropertyName = "Operacao";
            this.Operacao.HeaderText = "Operação";
            this.Operacao.Name = "Operacao";
            this.Operacao.ReadOnly = true;
            this.Operacao.Width = 330;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 211);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(406, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(99, 16);
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
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(6, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "INCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmConsultaOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 266);
            this.Controls.Add(this.dgOperacao);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaOperacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Operações";
            this.Activated += new System.EventHandler(this.frmConsultaOperacao_Activated);
            this.Load += new System.EventHandler(this.frmConsultaOperacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOperacao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgOperacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacao;
    }
}