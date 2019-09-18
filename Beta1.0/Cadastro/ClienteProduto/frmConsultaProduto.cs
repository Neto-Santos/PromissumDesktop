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

namespace Beta1._0.Consulta.ClienteProduto
{
    public partial class frmConsultaProduto : Form
    {
        public frmConsultaProduto()
        {
            InitializeComponent();
            conexao = new DalConexao(DadosConexao.stringConexao);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        DalConexao conexao;
        public string codigo;
        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btnFiltrar_Click(sender, e);
        }

        private void dgProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dgvProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dgvProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (rbReferencia.Checked)
            {
                BLLProduto bll = new BLLProduto(conexao);
                try
                {
                    dgvProduto.DataSource = bll.LocalizarProdutoReferencia(txtPesquisa.Text);
                }
                catch (Exception)
                {
                    throw new Exception();
                }

            }
            if (rbCod.Checked)
            {
                BLLProduto bll = new BLLProduto(conexao);
                try
                {
                    if (!String.IsNullOrEmpty(txtPesquisa.Text))
                    {
                        dgvProduto.DataSource = bll.LocalizarProdutoCodigo(txtPesquisa.Text);
                    }

                }
                catch (Exception)
                { }
            }
            if (rbProduto.Checked)
            {
                BLLProduto bll = new BLLProduto(conexao);
                try
                {
                    dgvProduto.DataSource = bll.Localizar(txtPesquisa.Text);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }
    }
}
