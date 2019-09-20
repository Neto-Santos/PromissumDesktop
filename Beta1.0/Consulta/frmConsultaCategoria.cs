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
    public partial class frmConsultaCategoria : Form
    {
        promissumServicoEntities contexto = new promissumServicoEntities();
        public frmConsultaCategoria()
        {
            InitializeComponent();
        }

        string codigo;

        void abrirFormularioCadastroOrcamento(string codigo = null)
        {
            frmCadCategoria frmCadCategoria = new frmCadCategoria(codigo);
            if ((Application.OpenForms["frmCadCategoria"] as frmCadCategoria) != null)
            {
                frmCadCategoria.BringToFront();
                frmCadCategoria.Focus();
            }
            else
            {
                frmCadCategoria.MdiParent = this.MdiParent;
                frmCadCategoria.Show();
            }
        }
        private void frmConsultaCategoria_Load(object sender, EventArgs e)
        {
         
        }

        private void dgCategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = dgCategoria.Rows[e.RowIndex].Cells["cat_cod"].Value.ToString();
            if (codigo != null)
            {
                abrirFormularioCadastroOrcamento(codigo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormularioCadastroOrcamento();
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = null;
            codigo = dgCategoria.Rows[e.RowIndex].Cells["cat_cod"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codigo != null)
            {
                abrirFormularioCadastroOrcamento(codigo);
            }
        }

        private void frmConsultaCategoria_Activated(object sender, EventArgs e)
        {
            dgCategoria.DataSource = contexto.categoria.Select(s => new
            {
                s.cat_cod,
                s.cat_nome,
                s.cat_cadastro
            }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (codigo != null)
            {
                var confirma = MessageBox.Show("Tem certeza que deseja cancelar o item selecionado?", "Aviso", MessageBoxButtons.YesNo);

                if (confirma == DialogResult.Yes)
                {
                    var codCategoria = int.Parse(codigo);
                    var _categoria = contexto.categoria.Find(codCategoria);

                    if (_categoria.cat_status == "Cancelado")
                    {
                        _categoria.cat_status = "Ativo";
                    }
                    else
                    {
                        _categoria.cat_status = "Cancelado";
                    }
                    contexto.Entry(_categoria).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();

                    frmConsultaCategoria_Activated(sender, e);
                    codigo = null;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgCategoria.DataSource = contexto.categoria.Select(s => new
            {
                s.cat_cod,
                s.cat_nome,
                s.cat_cadastro
            }).Where(s => s.cat_nome.Contains(textBox1.Text)).ToList();
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
