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
using Beta1._0.Relatorio.Produto;
using System.Runtime.InteropServices;

namespace Beta1._0.Consulta
{
    public partial class frmConsultaProduto : Form
    {
        public frmConsultaProduto()
        {
            InitializeComponent();
            this.codigo = null;
        }

        promissumServicoEntities contexto = new promissumServicoEntities();

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
                codigo = dgProduto.Rows[e.RowIndex].Cells["pro_cod"].Value.ToString();
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
            try
            {
                if (rbCategoria.Checked)
                {
                    dgProduto.DataSource = contexto.produto.Include("categoria").Include("subcategoria").Select(p => new
                    {
                        p.pro_cod,
                        p.pro_nome,
                        p.pro_ref,
                        p.subcategoria.scat_nome,
                        p.categoria.cat_nome,
                        p.localizacao,
                        p.pro_cadastro,
                        p.pro_valorpago,
                        p.pro_valorvenda
                    }).Where(x => x.scat_nome.Contains(txtPesquisa.Text)).ToList();

                }
                if (rbCod.Checked)
                {
                    if (!String.IsNullOrEmpty(txtPesquisa.Text))
                    {
                        dgProduto.DataSource = contexto.produto.Include("categoria").Include("subcategoria").Select(p => new
                        {
                            p.pro_cod,
                            p.pro_nome,
                            p.pro_ref,
                            p.pro_qtde,
                            p.umed,                            
                            p.subcategoria.scat_nome,
                            p.categoria.cat_nome,
                            p.localizacao,
                            p.pro_cadastro,
                            p.pro_valorpago,
                            p.pro_valorvenda
                        }).Where(x => x.cat_nome.Contains(txtPesquisa.Text)).ToList();
                    }
                }
                if (rbProduto.Checked)
                {
                    dgProduto.DataSource = contexto.produto.Include("categoria").Include("subcategoria").Select(p => new
                    {
                        p.pro_cod,
                        p.pro_nome,
                        p.pro_ref,
                        p.subcategoria.scat_nome,
                        p.categoria.cat_nome,
                        p.localizacao,
                        p.pro_cadastro,
                        p.pro_valorpago,
                        p.pro_valorvenda
                    }).Where(x => x.pro_nome.Contains(txtPesquisa.Text)).ToList();

                }
                if (rbSubCategoria.Checked)
                {
                    dgProduto.DataSource = contexto.produto.Include("categoria").Include("subcategoria").Select(p => new
                    {
                        p.pro_cod,
                        p.pro_nome,
                        p.pro_ref,
                        p.subcategoria.scat_nome,
                        p.categoria.cat_nome,
                        p.localizacao,
                        p.pro_cadastro,
                        p.pro_valorpago,
                        p.pro_valorvenda
                    }).Where(x => x.scat_nome.Contains(txtPesquisa.Text)).ToList();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ops. Parece que algo deu errado. Verifique se o campo foi preenchido corretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.codigo != null)
            {
                var dlg = MessageBox.Show("Deseja Realmento Excluir este item?", "", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    var codProduto = int.Parse(codigo);
                    var _produto = contexto.produto.Find(codProduto);

                    if (_produto.pro_status == "Cancelado")
                    {
                        _produto.pro_status = "Ativo";
                    }
                    else
                    {
                        _produto.pro_status = "Cancelado";
                    }
                    contexto.Entry(_produto).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();

                    btnFiltrar_Click(sender, e);
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }

        public const int WM_NCLMUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();

        private void pnCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLMUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
