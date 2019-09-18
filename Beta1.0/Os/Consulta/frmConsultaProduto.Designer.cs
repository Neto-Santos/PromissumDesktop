namespace Beta1._0.Os.Consulta
{
    partial class frmConsultaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProduto));
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.rbReferencia = new System.Windows.Forms.RadioButton();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scat_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(95, 21);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(78, 20);
            this.rbCodigo.TabIndex = 1;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "CODIGO";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(16, 21);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(63, 20);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(11, 49);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(472, 22);
            this.txtPesquisa.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(492, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgProduto
            // 
            this.dgProduto.AllowUserToAddRows = false;
            this.dgProduto.AllowUserToDeleteRows = false;
            this.dgProduto.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.scat_nome,
            this.pro_nome,
            this.referenciaa,
            this.cat_nome,
            this.codProduto,
            this.CodigoCliente,
            this.cli_nome});
            this.dgProduto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgProduto.Location = new System.Drawing.Point(0, 81);
            this.dgProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.ReadOnly = true;
            this.dgProduto.RowHeadersVisible = false;
            this.dgProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProduto.Size = new System.Drawing.Size(647, 246);
            this.dgProduto.TabIndex = 4;
            this.dgProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellClick);
            this.dgProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellDoubleClick);
            // 
            // rbReferencia
            // 
            this.rbReferencia.AutoSize = true;
            this.rbReferencia.Location = new System.Drawing.Point(192, 21);
            this.rbReferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbReferencia.Name = "rbReferencia";
            this.rbReferencia.Size = new System.Drawing.Size(92, 20);
            this.rbReferencia.TabIndex = 1;
            this.rbReferencia.TabStop = true;
            this.rbReferencia.Text = "Referência";
            this.rbReferencia.UseVisualStyleBackColor = true;
            // 
            // cod
            // 
            this.cod.DataPropertyName = "cod";
            this.cod.HeaderText = "cod";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Visible = false;
            // 
            // scat_nome
            // 
            this.scat_nome.DataPropertyName = "scat_nome";
            this.scat_nome.HeaderText = "SubCategoria";
            this.scat_nome.Name = "scat_nome";
            this.scat_nome.ReadOnly = true;
            // 
            // pro_nome
            // 
            this.pro_nome.DataPropertyName = "pro_nome";
            this.pro_nome.HeaderText = "Item";
            this.pro_nome.Name = "pro_nome";
            this.pro_nome.ReadOnly = true;
            // 
            // referenciaa
            // 
            this.referenciaa.DataPropertyName = "referencia";
            this.referenciaa.HeaderText = "Referencia";
            this.referenciaa.Name = "referenciaa";
            this.referenciaa.ReadOnly = true;
            // 
            // cat_nome
            // 
            this.cat_nome.DataPropertyName = "cat_nome";
            this.cat_nome.HeaderText = "Categoria";
            this.cat_nome.Name = "cat_nome";
            this.cat_nome.ReadOnly = true;
            // 
            // codProduto
            // 
            this.codProduto.DataPropertyName = "codProduto";
            this.codProduto.HeaderText = "codProduto";
            this.codProduto.Name = "codProduto";
            this.codProduto.ReadOnly = true;
            this.codProduto.Visible = false;
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.DataPropertyName = "codCliente";
            this.CodigoCliente.HeaderText = "Codigo Cliente";
            this.CodigoCliente.Name = "CodigoCliente";
            this.CodigoCliente.ReadOnly = true;
            this.CodigoCliente.Visible = false;
            // 
            // cli_nome
            // 
            this.cli_nome.DataPropertyName = "cli_nome";
            this.cli_nome.HeaderText = "Cliente";
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.ReadOnly = true;
            this.cli_nome.Width = 250;
            // 
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 327);
            this.Controls.Add(this.rbReferencia);
            this.Controls.Add(this.rbCodigo);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgProduto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produto";
            this.Load += new System.EventHandler(this.frmConsultaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgProduto;
        private System.Windows.Forms.RadioButton rbReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn scat_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
    }
}