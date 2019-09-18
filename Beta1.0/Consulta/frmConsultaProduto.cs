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
using Beta1._0.Relatorio.Produto;

namespace Beta1._0.Consulta
{
    public partial class frmConsultaProduto : Form
    {
        public frmConsultaProduto()
        {
            InitializeComponent();
            this.codigo = null;
            conexao = new DalConexao(DadosConexao.stringConexao);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

       

        DalConexao conexao;
        string codigo;
        void abrirFormularioCadastroOrcamento(string codigo = null)
        {
            frmCadProduto frmCadProduto = new frmCadProduto(codigo);
            if ((Application.OpenForms["frmCadProduto"] as frmCadProduto) != null)
            {
                frmCadProduto.BringToFront();
                frmCadProduto.Focus();
            }
            else
            {
                frmCadProduto.MdiParent = this.MdiParent;
                frmCadProduto.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormularioCadastroOrcamento();
        }
        private void dgProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = dgProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            { }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codigo != null)
            {
                abrirFormularioCadastroOrcamento(codigo);
            }
        }

        private void frmConsultaProduto_Load_1(object sender, EventArgs e)
        {
            Ferramentas.impressao objferra = new Ferramentas.impressao();
            objferra.CarregarListaDeImpressoras(cbImpressora);

            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (rbCategoria.Checked)
            {
                BLLProduto bll = new BLLProduto(conexao);
                try
                {
                    dgProduto.DataSource = bll.LocalizarProdutoCategoria(txtPesquisa.Text);
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
                        dgProduto.DataSource = bll.LocalizarProdutoCodigo(txtPesquisa.Text);
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
                    dgProduto.DataSource = bll.Localizar(txtPesquisa.Text);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
            if (rbSubCategoria.Checked)
            {
                BLLProduto bll = new BLLProduto(conexao);
                try
                {
                    dgProduto.DataSource = bll.LocalizarProdutoSubCategoria(txtPesquisa.Text);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.codigo != null)
            {
                var dlg = MessageBox.Show("Deseja Realmento Excluir este item?", "", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    BLLProduto bll = new BLLProduto(conexao);
                    bll.Excluir(Convert.ToInt32(this.codigo));
                    dgProduto.DataSource = bll.LocalizarProdutoSubCategoria("");
                }
            }
        }

        private void frmConsultaProduto_Activated(object sender, EventArgs e)
        {
            btnFiltrar_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFiltroProduto frm = new frmFiltroProduto(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
