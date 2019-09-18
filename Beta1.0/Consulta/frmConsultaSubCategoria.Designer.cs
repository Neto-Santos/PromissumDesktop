namespace Beta1._0.Consulta
{
    partial class frmConsultaSubCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaSubCategoria));
            this.dgSubCategoria = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CodigoSubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubCategoria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgSubCategoria
            // 
            this.dgSubCategoria.AllowUserToAddRows = false;
            this.dgSubCategoria.AllowUserToDeleteRows = false;
            this.dgSubCategoria.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgSubCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSubCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgSubCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoSubCategoria,
            this.Categoria,
            this.SubCategoria});
            this.dgSubCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgSubCategoria.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgSubCategoria.Location = new System.Drawing.Point(0, 0);
            this.dgSubCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgSubCategoria.Name = "dgSubCategoria";
            this.dgSubCategoria.ReadOnly = true;
            this.dgSubCategoria.RowHeadersVisible = false;
            this.dgSubCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSubCategoria.Size = new System.Drawing.Size(527, 228);
            this.dgSubCategoria.TabIndex = 5;
            this.dgSubCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoria_CellContentClick);
            this.dgSubCategoria.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoria_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(512, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(100, 21);
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
            this.button1.Location = new System.Drawing.Point(7, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "INCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CodigoSubCategoria
            // 
            this.CodigoSubCategoria.DataPropertyName = "CodigoSubCategoria";
            this.CodigoSubCategoria.HeaderText = "Codigo";
            this.CodigoSubCategoria.Name = "CodigoSubCategoria";
            this.CodigoSubCategoria.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Tipo";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 210;
            // 
            // SubCategoria
            // 
            this.SubCategoria.DataPropertyName = "SubCategoria";
            this.SubCategoria.HeaderText = "Modelo";
            this.SubCategoria.Name = "SubCategoria";
            this.SubCategoria.ReadOnly = true;
            this.SubCategoria.Width = 210;
            // 
            // frmConsultaSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(527, 278);
            this.Controls.Add(this.dgSubCategoria);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo";
            this.Activated += new System.EventHandler(this.frmConsultaSubCategoria_Activated);
            this.Load += new System.EventHandler(this.frmConsultaSubCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSubCategoria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgSubCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSubCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategoria;
    }
}