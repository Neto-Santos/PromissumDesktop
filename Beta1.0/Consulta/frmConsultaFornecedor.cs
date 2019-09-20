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
using DAL.EntityFramework;
using BLL;
namespace Beta1._0.Consulta
{
    public partial class frmConsultaFornecedor : Form
    {
        public frmConsultaFornecedor()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        promissumServicoEntities contexto = new promissumServicoEntities();

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
            dgvFornecedor.DataSource = contexto.fornecedor.ToList();
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
                var confirma = MessageBox.Show("Tem certeza que deseja excluir o item selecionado?", "Aviso", MessageBoxButtons.YesNo);
                if (confirma == DialogResult.Yes)
                {
                    int codFornecedor = int.Parse(codigo);
                    var fornecedor = contexto.fornecedor.Find(codFornecedor);
                    contexto.fornecedor.Remove(fornecedor);
                    contexto.SaveChanges();

                    this.frmConsultaFornecedor_Load(sender, e);

                    codigo = null;
                }
            }
        }

        private void frmConsultaFornecedor_Activated(object sender, EventArgs e)
        {

            dgvFornecedor.DataSource = contexto.fornecedor.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (rbCnpj.Checked)
            {
                dgvFornecedor.DataSource = contexto.fornecedor.Where(f => f.for_cnpj.Contains(textBox1.Text)).ToList();
            }
            if (rbCodigo.Checked)
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    dgvFornecedor.DataSource = contexto.fornecedor.Where(f => f.for_cod.Equals(textBox1.Text)).ToList();
                }
                
            }
            if (rbNome.Checked)
            {
                dgvFornecedor.DataSource = contexto.fornecedor.Where(f => f.for_nome.Contains(textBox1.Text)).ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Relatorio.Fornecedor.frmFiltroFornecedor frm = new Relatorio.Fornecedor.frmFiltroFornecedor();
            frm.ShowDialog();
        }
    }
}
