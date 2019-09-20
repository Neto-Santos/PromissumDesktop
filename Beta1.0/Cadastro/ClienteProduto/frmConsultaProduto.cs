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
using DAL.EntityFramework;
using BLL;

namespace Beta1._0.Consulta.ClienteProduto
{
    public partial class frmConsultaProduto : Form
    {
        promissumServicoEntities contexto = new promissumServicoEntities();
        public frmConsultaProduto()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public string codigo;
        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btnFiltrar_Click(sender, e);
        }

        private void dgProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dgvProduto.Rows[e.RowIndex].Cells["pro_cod"].Value.ToString();
        }

        private void dgProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dgvProduto.Rows[e.RowIndex].Cells["pro_cod"].Value.ToString();
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (rbReferencia.Checked)
            {
               
                try
                {
                    dgvProduto.DataSource = contexto.produto.Where(p => p.pro_ref.Contains(txtPesquisa.Text)).ToList();
                }
                catch (Exception)
                {
                    throw new Exception();
                }

            }
            if (rbCod.Checked)
            {
               
                try
                {
                    if (!String.IsNullOrEmpty(txtPesquisa.Text))
                    {
                        dgvProduto.DataSource = contexto.produto.Where(p => p.pro_cod.Equals(txtPesquisa.Text)).ToList();
                    }

                }
                catch (Exception)
                { }
            }
            if (rbProduto.Checked)
            {
               
                try
                {
                    dgvProduto.DataSource = contexto.produto.Where(p => p.pro_nome.Contains(txtPesquisa.Text)).ToList();
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }
    }
}
