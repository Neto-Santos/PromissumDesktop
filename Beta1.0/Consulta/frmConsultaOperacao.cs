using Beta1._0.Cadastro;
using BLL;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
                codigo = dgOperacao.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception) { }
        }

        private void frmConsultaOperacao_Load(object sender, EventArgs e)
        {

        }

        private void frmConsultaOperacao_Activated(object sender, EventArgs e)
        {
            dgOperacao.DataSource = contexto.operacao.ToList();
        }
    }
}
