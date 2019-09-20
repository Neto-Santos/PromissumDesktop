using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DAL.EntityFramework;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Promissum.Relatorio_Atualizado.Orcamento
{
    public partial class frmRelatorioVenda : Form
    {
        promissumServicoEntities contexto = new promissumServicoEntities();

        public frmRelatorioVenda()
        {
            InitializeComponent();

            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
        }

        private void frmRelatorioVenda_Load(object sender, EventArgs e)
        {
            var caminhoRelatorio = "Promissum.Relatorio_Atualizado.Orcamento.rptOrcamentoAnalitico.rdlc";

            string caminhoImagem = Ferramentas.xmlConfig.config.retornaLogo();

            DataTable tabela = new DataTable();
            tabela.Columns.Add("ven_cod", typeof(int));
            tabela.Columns.Add("ven_cadastro", typeof(DateTime));
            tabela.Columns.Add("ven_status", typeof(string));
            tabela.Columns.Add("ven_total", typeof(decimal));
            tabela.Columns.Add("itv_valorBase", typeof(decimal));
            tabela.Columns.Add("itv_valor", typeof(decimal));
            tabela.Columns.Add("itv_qtde", typeof(string));
            tabela.Columns.Add("itv_desconto", typeof(decimal));
            tabela.Columns.Add("op_nome", typeof(string));
            tabela.Columns.Add("pro_nome", typeof(string));
            tabela.Columns.Add("cli_nome", typeof(string));
            tabela.Columns.Add("cli_cpfcnpj", typeof(string));

            var lista = contexto.itensvenda.Include("venda").Include("operacao").Include("ClienteProduto").ToList();


            foreach (var item in lista)
            {
                tabela.Rows.Add(item.ven_cod, item.venda.ven_data, item.venda.ven_status, item.venda.ven_total
                    , item.itv_valorBase, item.itv_valor, item.itv_qtde, item.itv_desconto, item.operacao.op_nome,
                    item.ClienteProduto.produto.pro_nome, item.ClienteProduto.cliente.cli_nome, item.ClienteProduto.cliente.cli_cpfcnpj);
            }

            reportViewer1.LocalReport.ReportEmbeddedResource = caminhoRelatorio;
            ReportDataSource rpt = new ReportDataSource("dsVendaAnalitico", tabela);
            reportViewer1.LocalReport.DataSources.Add(rpt);
            reportViewer1.LocalReport.EnableExternalImages = true;

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("logo", caminhoImagem));
            //Carregando dados da empresa no relatório =======================================
           this.reportViewer1.LocalReport.SetParameters(new ReportParameter("empresa", "teste"));
           this.reportViewer1.LocalReport.SetParameters(new ReportParameter("cnpj", "teste"));
           this.reportViewer1.LocalReport.SetParameters(new ReportParameter("uf", "teste"));
           this.reportViewer1.LocalReport.SetParameters(new ReportParameter("cidade", "teste"));
           this.reportViewer1.LocalReport.SetParameters(new ReportParameter("telefone", "teste"));
           this.reportViewer1.LocalReport.SetParameters(new ReportParameter("email", "teste"));
           this.reportViewer1.LocalReport.SetParameters(new ReportParameter("dtInicio", "teste"));
           this.reportViewer1.LocalReport.SetParameters(new ReportParameter("dtFim", "teste"));

            this.reportViewer1.RefreshReport();

        }
    }
}
