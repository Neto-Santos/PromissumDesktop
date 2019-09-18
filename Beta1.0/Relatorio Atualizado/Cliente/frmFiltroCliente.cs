using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta1._0.Relatorio_Atualizado.Cliente
{
    public partial class frmFiltroCliente : Form
    {
        public frmFiltroCliente(string fomato = "")
        {
            InitializeComponent();

            this.formato = formato;
        }
        public string formato { get; set; }

        
        private void button1_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente frm = new frmRelatorioCliente(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            frm.nome = txtNome.Text;
            frm.dataInicial = dtInicio.Value.ToShortDateString();
            frm.dataFinal = dtFim.Value.ToShortDateString();
            frm.cidade = txtCidade.Text;
            frm.estado = txtEstado.Text;
            frm.tipo = rbSintetico.Checked ? "Sintetico" : "Analitico"; 
            //frm.status = rbAberto.Checked ? "Aberto" : "";
            //frm.status = rbCancelado.Checked ? "Cancelado" : "";
            //frm.status = rbFinalizado.Checked ? "Finalizado" : "";
            frm.defeito = txtDefeito.Text;
            frm.solucao = txtServiço.Text;
            frm.referencia = txtRef.Text;

            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            this.formato = "pdf";
            frmRelatorioCliente frm = new frmRelatorioCliente(new DAL.DalConexao(DAL.DadosConexao.stringConexao),formato);
            frm.nome = txtNome.Text;
            frm.dataInicial = dtInicio.Value.ToShortDateString();
            frm.dataFinal = dtFim.Value.ToShortDateString();
            frm.cidade = txtCidade.Text;
            frm.estado = txtEstado.Text;
            frm.tipo = rbSintetico.Checked ? "Sintetico" : "Analitico";
            //frm.status = rbAberto.Checked ? "Aberto" : "";
            //frm.status = rbCancelado.Checked ? "Cancelado" : "";
            //frm.status = rbFinalizado.Checked ? "Finalizado" : "";
            frm.defeito = txtDefeito.Text;
            frm.solucao = txtServiço.Text;
            frm.referencia = txtRef.Text;

            frm.ShowDialog();
            frm.Dispose();
        }
        
    }
}
