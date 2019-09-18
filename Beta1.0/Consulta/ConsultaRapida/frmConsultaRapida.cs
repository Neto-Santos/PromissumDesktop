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

namespace Beta1._0.Consulta.ConsultaRapida
{
    public partial class frmConsultaRapida : Form
    {
        promissumServicoEntities contexto = new promissumServicoEntities();
        public frmConsultaRapida()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            if (rbCategoria.Checked)
            {
               
                try
                {
                    dgProduto.DataSource = contexto.produto.Where(p => p.categoria.cat_nome.Contains(txtPesquisa.Text));
                }
                catch (Exception)
                {
                    throw new Exception();
                }

            }
            if (rbReferencia.Checked)
            {
               
                try
                {
                    dgProduto.DataSource = contexto.produto.Where(p => p.pro_ref.Contains(txtPesquisa.Text));
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
                    int codProduto = Convert.ToInt32(txtPesquisa.Text);
                    dgProduto.DataSource = contexto.produto.Where(p => p.pro_cod == codProduto);
                }
                catch (Exception)
                {
                    MessageBox.Show("Não informação concisa para que possamos realizar uma busca");
                }
            }
            if (rbProduto.Checked)
            {
                try
                {
                    dgProduto.DataSource = contexto.produto.Where(p => p.pro_nome.Contains(txtPesquisa.Text));
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
            if (rbSubCategoria.Checked)
            {
                try
                {
                    dgProduto.DataSource = contexto.produto.Where(p => p.subcategoria.scat_nome.Contains(txtPesquisa.Text));

                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dgProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbNome.Text = dgProduto.Rows[Convert.ToInt32(e.RowIndex)].Cells["nome"].Value.ToString();
                lbCusto.Text = dgProduto.Rows[Convert.ToInt32(e.RowIndex)].Cells["custo"].Value.ToString();
                lbVenda.Text = dgProduto.Rows[Convert.ToInt32(e.RowIndex)].Cells["venda"].Value.ToString();
                lbTipo.Text = dgProduto.Rows[Convert.ToInt32(e.RowIndex)].Cells["categoria"].Value.ToString();
                lbModelo.Text = dgProduto.Rows[Convert.ToInt32(e.RowIndex)].Cells["subcategoria"].Value.ToString();
                lbLocalizacao.Text = dgProduto.Rows[Convert.ToInt32(e.RowIndex)].Cells["Localização"].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void frmConsultaRapida_Load(object sender, EventArgs e)
        {

        }
    }
}
