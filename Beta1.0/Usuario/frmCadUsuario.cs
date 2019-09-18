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

namespace Beta1._0.Usuario
{
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();

        }
        DalConexao conexao = new DalConexao(DadosConexao.stringConexao);
        public int codUsuario { get; set; }

        void limpaCampos()
        {
            txtConfirma.Clear();
            txtSenha.Clear();
            txtUsuario.Clear();           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtSenha.Text) && !String.IsNullOrEmpty(txtConfirma.Text))
            {
                if (txtConfirma.Text == txtSenha.Text)
                {

                    BllUsuario bll = new BllUsuario(conexao);
                    ModeloUsuario modelo = new ModeloUsuario();

                    modelo.usu_nome = txtUsuario.Text;
                    modelo.usu_cadastro = DateTime.Now;
                    modelo.usu_senha = txtSenha.Text;

                    if (!bll.VerficaLoginCadastrado(txtUsuario.Text))
                    {
                        bll.Incluir(modelo);

                        MessageBox.Show("Usuário adcionado");

                        dgvUsuario.DataSource = null;
                        dgvUsuario.DataSource = bll.Localizar("");

                        limpaCampos();
                    }
                    else
                    {
                        MessageBox.Show("Ops. Parece que já existe alguém com este nome em nosso banco de dados");
                    }
                }
            }

        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            BllUsuario bll = new BllUsuario(conexao);
            dgvUsuario.DataSource = bll.Localizar("");
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.codUsuario = Convert.ToInt32(dgvUsuario.Rows[e.RowIndex].Cells[0].Value.ToString());
            BllUsuario BllUsuario = new BllUsuario(conexao);
            var modelo = BllUsuario.CarregaModeloUsuario(codUsuario);
            txtUsuario.Text = modelo.usu_nome;
            txtSenha.Text = modelo.usu_senha;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
