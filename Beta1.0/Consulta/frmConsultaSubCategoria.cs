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
using System.Runtime.InteropServices;

namespace Beta1._0.Consulta
{
    public partial class frmConsultaSubCategoria : Form
    {

        public frmConsultaSubCategoria()
        {
            InitializeComponent();
        }
        promissumServicoEntities contexto = new promissumServicoEntities();
        string codigo;
        void abrirFormularioCadastroOrcamento(string codigo = null)
        {
            frmCadSubCategoria frmCadSubCategoria = new frmCadSubCategoria(codigo);
            if ((Application.OpenForms["frmCadSubCategoria"] as frmCadSubCategoria) != null)
            {
                frmCadSubCategoria.BringToFront();
                frmCadSubCategoria.Focus();
            }
            else
            {
                frmCadSubCategoria.MdiParent = this.MdiParent;
                frmCadSubCategoria.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormularioCadastroOrcamento();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormularioCadastroOrcamento(codigo);
        }

        private void dgCategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dgSubCategoria.Rows[e.RowIndex].Cells["scat_cod"].Value.ToString();
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = dgSubCategoria.Rows[e.RowIndex].Cells["scat_cod"].Value.ToString();
            }
            catch (Exception) { }
        }

        private void frmConsultaSubCategoria_Load(object sender, EventArgs e)
        {

        }

        private void frmConsultaSubCategoria_Activated(object sender, EventArgs e)
        {
            dgSubCategoria.DataSource = contexto.subcategoria.Include("categoria").Select(s => new
            {
                s.scat_cod,
                s.scat_nome,
                s.categoria.cat_nome,
                s.scat_cadastro,
                s.scat_status
            }).ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgSubCategoria.DataSource = contexto.subcategoria.Include("categoria").Select(s => new
            {
                s.scat_cod,
                s.scat_nome,
                s.categoria.cat_nome,
                s.scat_cadastro,
                s.scat_status
            }).Where(s=>s.cat_nome.Contains(textBox1.Text)).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (codigo != null)
            {
                var confirma = MessageBox.Show("Tem certeza que deseja cancelar o item selecionado?", "Aviso", MessageBoxButtons.YesNo);

                if (confirma == DialogResult.Yes)
                {
                    var codCliente = int.Parse(codigo);
                    var _subCategoria = contexto.subcategoria.Find(codCliente);

                    if (_subCategoria.scat_status == "Cancelado")
                    {
                        _subCategoria.scat_status = "Ativo";
                    }
                    else
                    {
                        _subCategoria.scat_status = "Cancelado";
                    }
                    contexto.Entry(_subCategoria).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();

                    frmConsultaSubCategoria_Activated(sender, e);
                    codigo = null;
                }
            }
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
