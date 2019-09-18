using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Beta1._0.Cadastro;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
namespace Beta1._0.Consulta
{
    public partial class frmConsultaFornecedor : Form
    {
        public frmConsultaFornecedor()
        {
            InitializeComponent();
            conexao = new DalConexao(DadosConexao.stringConexao);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        DalConexao conexao;
        string codigo;
        void abrirFormularioCadastroOrcamento(string codigo = null)
        {
            frmCadFornecedor frmCadFornecedor = new frmCadFornecedor(codigo);
            if ((Application.OpenForms["frmCadFornecedor"] as frmCadFornecedor) != null)
            {
                frmCadFornecedor.BringToFront();
                frmCadFornecedor.Focus();
            }
            else
            {
                frmCadFornecedor.MdiParent = this.MdiParent;
                frmCadFornecedor.Show();
            }
        }
        public void atualiarDgFornecedor()
        {
            dgvFornecedor.DataSource = null;
            BLLFornecedor bll = new BLLFornecedor(conexao);
            dgvFornecedor.DataSource = bll.LocalizarFornecedorPorNome("");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormularioCadastroOrcamento();
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                codigo = dgvFornecedor.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
           
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                abrirFormularioCadastroOrcamento(codigo);
            }
        }

        private void frmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            Ferramentas.impressao objferra = new Ferramentas.impressao();
            objferra.CarregarListaDeImpressoras(cbImpressora);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (codigo != null)
            {
                var confirma = MessageBox.Show("Tem certeza que deseja excluir o cliente selecionado?", "Aviso", MessageBoxButtons.YesNo);
                if (confirma == DialogResult.Yes)
                {
                    BLLFornecedor bll = new BLLFornecedor(conexao);
                    bll.Excluir(Convert.ToInt32(codigo));
                    this.frmConsultaFornecedor_Load(sender, e);
                    codigo = null;
                }
            }
        }

        private void frmConsultaFornecedor_Activated(object sender, EventArgs e)
        {
            BLLFornecedor bll = new BLLFornecedor(conexao);
            dgvFornecedor.DataSource = bll.LocalizarFornecedorPorNome("");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BLLFornecedor bll = new BLLFornecedor(conexao);
            if (rbCnpj.Checked)
            {
                dgvFornecedor.DataSource = bll.LocalizarFornecedorPorCnpj(textBox1.Text);
            }
            if (rbCodigo.Checked)
            {
                dgvFornecedor.DataSource = bll.LocalizarFornecedorPorCodigo(textBox1.Text);
            }
            if (rbNome.Checked)
            {
                dgvFornecedor.DataSource = bll.LocalizarFornecedorPorNome(textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Relatorio.Fornecedor.frmFiltroFornecedor frm = new Relatorio.Fornecedor.frmFiltroFornecedor(conexao);
            frm.ShowDialog();
        }
    }
}
