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

namespace Beta1._0.Consulta
{
    public partial class frmConsultaSubCategoria : Form
    {
        
        public frmConsultaSubCategoria()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            codigo = dgSubCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = dgSubCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception) { }
        }

        private void frmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
          
        }

        private void frmConsultaSubCategoria_Activated(object sender, EventArgs e)
        {
            dgSubCategoria.DataSource = contexto.subcategoria.ToList();

        }
    }
}
