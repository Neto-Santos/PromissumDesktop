using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promissum.Relatorio_Atualizado.Operacao
{
    public partial class frmFiltroOperacao : Form
    {
        public frmFiltroOperacao()
        {
            InitializeComponent();
        }

        private void frmFiltroOperacao_Load(object sender, EventArgs e)
        {           
            
        }

        //Filtrar
        private void button1_Click(object sender, EventArgs e)
        {
            
                frmRelatorioOperacao frm = new frmRelatorioOperacao();

                frm.status = cbStatus.Text;
                frm.cliente = txtCliente.Text;
                frm.operacao = txtServico.Text;
                frm.dataInicio = dtInicio.Value.ToShortDateString();
                frm.dataFim = dtFim.Value.ToShortDateString();
                frm.ns = txtNs.Text;
                frm.produto = txtItem.Text;

                frm.ShowDialog();
                frm.Close();
                frm.Dispose();
           
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            
            frmRelatorioOperacao frm = new frmRelatorioOperacao();

            frm.formato = "pdf";
            frm.status = cbStatus.Text;
            frm.cliente = txtCliente.Text;
            frm.operacao = txtServico.Text;
            frm.dataInicio = dtInicio.Value.ToShortDateString();
            frm.dataFim = dtFim.Value.ToShortDateString();

            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }
    }
}
