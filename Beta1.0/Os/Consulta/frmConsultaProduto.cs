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
    public partial class frmConsultaProduto : Form
    {
        public frmConsultaProduto()
        {
            InitializeComponent();
            conexao = new DalConexao(DadosConexao.stringConexao);            
        }
        public string codCliente;
        DalConexao conexao;
        public string codigo;
        public string referencia;
        public string codigoClienteProduto;
        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            BLLClienteProduto bll = new BLLClienteProduto(conexao);
            try
            {
                dgProduto.DataSource = bll.Localizar(codCliente);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        private void dgProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = dgProduto.Rows[e.RowIndex].Cells["codProduto"].Value.ToString();
                codigoClienteProduto = dgProduto.Rows[e.RowIndex].Cells["cod"].Value.ToString();
            }
            catch (Exception)
            {
                           
            }
           
        }

        private void dgProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dgProduto.Rows[e.RowIndex].Cells["codProduto"].Value.ToString();
            codigoClienteProduto = dgProduto.Rows[e.RowIndex].Cells["cod"].Value.ToString();
            referencia = dgProduto.Rows[e.RowIndex].Cells["referenciaa"].Value.ToString();
            if (!string.IsNullOrEmpty(codigo))
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbCodigo.Checked)
            {
                if (!String.IsNullOrEmpty(txtPesquisa.Text))
                {
                    BLLClienteProduto bll = new BLLClienteProduto(conexao);
                    try
                    {
                        dgProduto.DataSource = bll.LocalizarClienteProdutoCodProduto(this.codCliente, txtPesquisa.Text);
                    }
                    catch (Exception)
                    {

                    }
                }
                
            }
            if (rbNome.Checked)
            {
                BLLClienteProduto bll = new BLLClienteProduto(conexao);
                try
                {
                    dgProduto.DataSource = bll.LocalizarClienteProdutoNome(this.codCliente, txtPesquisa.Text);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
            if (rbReferencia.Checked)
            {
                BLLClienteProduto bll = new BLLClienteProduto(conexao);
                try
                {
                    dgProduto.DataSource = bll.LocalizarClienteProdutoReferencia(this.codCliente, txtPesquisa.Text);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }
    }
}
