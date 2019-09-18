using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Beta1._0.Cadastro;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace Beta1._0.Os.Consulta
{
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
            conexao = new DalConexao(DadosConexao.stringConexao);
        }

        DalConexao conexao;

        public string codigo;

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            BllCliente bll = new BllCliente(conexao);
            dgCliente.DataSource = bll.Localizar("");
        }

        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dgCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (codigo != null)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbNome.Checked)
            {
                BllCliente bll = new BllCliente(conexao);
                dgCliente.DataSource = bll.Localizar(txtPesquisa.Text);
            }
            else
            {
                BllCliente bll = new BllCliente(conexao);
                dgCliente.DataSource = bll.LocalizarPorCodigo(txtPesquisa.Text);
            }
        }
    }
}
