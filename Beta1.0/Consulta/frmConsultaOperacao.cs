using Beta1._0.Cadastro;
using BLL;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta1._0.Consulta
{
    public partial class frmConsultaOperacao : Form
    {

        public frmConsultaOperacao()
        {
            InitializeComponent();
        }
        promissumServicoEntities contexto = new promissumServicoEntities();
        string codigo;
        void abrirFormularioCadastroOrcamento(string codigo = null)
        {
            frmCadOperacao frmCadOperacao = new frmCadOperacao(codigo);
            if ((Application.OpenForms["frmCadOperacao"] as frmCadOperacao) != null)
            {
                frmCadOperacao.BringToFront();
                frmCadOperacao.Focus();
            }
            else
            {
                frmCadOperacao.MdiParent = this.MdiParent;
                frmCadOperacao.Show();
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

        private void dgOperaca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = dgOperacao.Rows[e.RowIndex].Cells["op_cod"].Value.ToString();
            }
            catch (Exception) { }
        }

        private void frmConsultaOperacao_Load(object sender, EventArgs e)
        {

        }

        private void frmConsultaOperacao_Activated(object sender, EventArgs e)
        {
            dgOperacao.DataSource = contexto.operacao.Select(o=>new {o.op_cod,o.op_nome,o.op_cadastro,o.op_status }).ToList();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            contexto.operacao.Select(o => new { o.op_cod, o.op_nome, o.op_cadastro,o.op_status }).Where(o=>o.op_nome.Contains(textBox1.Text)).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (codigo != null)
            {
                var confirma = MessageBox.Show("Tem certeza que deseja cancelar o item selecionado?", "Aviso", MessageBoxButtons.YesNo);

                if (confirma == DialogResult.Yes)
                {
                    var codCliente = int.Parse(codigo);
                    var _operacao = contexto.operacao.Find(codCliente);

                    if (_operacao.op_status == "Cancelado")
                    {
                        _operacao.op_status = "Ativo";
                    }
                    else
                    {
                        _operacao.op_status = "Cancelado";
                    }
                    contexto.Entry(_operacao).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();

                    frmConsultaOperacao_Activated(sender, e);
                    codigo = null;
                }
            }
        }
    }
}
