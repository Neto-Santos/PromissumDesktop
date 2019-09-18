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
    public partial class frmConsultaCategoria : Form
    {
        promissumServicoEntities contexto = new promissumServicoEntities();
        public frmConsultaCategoria()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            codigo = dgCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
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
            codigo = dgCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
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
            dgCategoria.DataSource = contexto.categoria.ToList();
        }
    }
}
