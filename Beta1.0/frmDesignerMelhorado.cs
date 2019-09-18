using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Beta1._0.Consulta;

namespace Promissum
{
    public partial class frmDesignerMelhorado : Form
    {

        public const int WM_NCLMUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;
        public frmDesignerMelhorado()
        {
            InitializeComponent();
        }


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();

        public void AbrirFormNoPanel<Forms>() where Forms:Form, new()
        {
            Form formulario;
            formulario = pnPrincipal.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
              
                pnPrincipal.Controls.Add(formulario);
                pnPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                    formulario.BringToFront();
                }
            }
            
        }

        List<string> lista = new List<string>() { "Cadastro", "Produtos", "Clientes" };
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            comboBox2.DataSource = lista;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
            

        }

        private void pnCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLMUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Produtos")
            {
                AbrirFormNoPanel<frmConsultaProduto>();
            }
           
        }
    }
}
