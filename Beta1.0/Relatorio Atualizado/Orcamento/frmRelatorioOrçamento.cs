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
using BLL;
using DAL;

namespace Beta1._0.Relatorio_Atualizado.Orcamento
{
    public partial class frmRelatorioOrçamento : Form
    {
        public frmRelatorioOrçamento()
        {
            InitializeComponent();
           
            this.formato = formato;
        }

        public string formato { get; set; }
        DalConexao conexao;
        int codVenda;
        string tipo;
        string cliente, rsocial, cidade, uf, status, defeito, servico, cnpj;
        DateTime inicio, fim;

        private void frmRelatorioOrçamento_Load(object sender, EventArgs e)
        {
            if (formato=="PDF")
            {
                this.Hide();
            }

            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            string caminhoImagem = Ferramentas.xmlConfig.config.retornaLogo();

            var empresa = new BllEmpresa(conexao).CarregaModeloEmpresa(1);

            if (tipo == "Sintetico")
            {
                string caminhoRelatorio = "Promissum.Relatorio_Atualizado.Orcamento.rptOrcamento.rdlc";
                var tableAdapter = new Promissum.Relatorio_Atualizado.Orcamento.dsOrcamentoTableAdapters.dsOrcamentoTableAdapter();

                var tabela = tableAdapter.GetData(codVenda);

                ReportDataSource rpt = new ReportDataSource("dsOrcamento", tabela.Rows);
                reportViewer1.LocalReport.DataSources.Add(rpt);
                reportViewer1.LocalReport.ReportEmbeddedResource = caminhoRelatorio;

                if (formato == "PDF")
                {
                    LocalReport report = new LocalReport();

                    report.ReportEmbeddedResource = caminhoRelatorio;

                    report.DataSources.Add(rpt);

                    report.EnableExternalImages = true;

                    report.SetParameters(new ReportParameter("logo", caminhoImagem));
                    //Carregando dados da empresa no relatório =======================================
                    report.SetParameters(new ReportParameter("empresa", empresa.nome));
                    report.SetParameters(new ReportParameter("cnpj", empresa.cpfcnpj));
                    report.SetParameters(new ReportParameter("uf", empresa.estado));
                    report.SetParameters(new ReportParameter("cidade", empresa.cidade));
                    report.SetParameters(new ReportParameter("telefone", empresa.telefone));
                    report.SetParameters(new ReportParameter("email", empresa.email));
                    report.SetParameters(new ReportParameter("dtInicio", inicio.ToShortDateString()));
                    report.SetParameters(new ReportParameter("dtFim", fim.ToShortDateString()));

                    Ferramentas.relatorio.exportarRelatorio(report, "PDF");
                }
            }
            else
            {
                var tableAdapter = new Promissum.Relatorio_Atualizado.Orcamento.dsOrcamentoTableAdapters.dsOrcamentoTableAdapter();

                var tabela = tableAdapter.GetDataAnalitico(cliente, rsocial, cidade, uf, status, defeito, servico, cnpj, inicio.ToShortDateString(), fim.ToShortDateString());
                string caminhoRelatorio = "Promissum.Relatorio_Atualizado.Orcamento.rptOrcamentoAnalitico.rdlc";

                ReportDataSource rpt = new ReportDataSource("dsOrcamento", tabela.Rows);

                reportViewer1.LocalReport.DataSources.Add(rpt);
                reportViewer1.LocalReport.ReportEmbeddedResource = caminhoRelatorio;

                if (formato == "PDF")
                {
                    LocalReport report = new LocalReport();

                    report.ReportEmbeddedResource = caminhoRelatorio;

                    report.DataSources.Add(rpt);

                    report.EnableExternalImages = true;

                    report.SetParameters(new ReportParameter("logo", caminhoImagem));


                    //Carregando dados da empresa no relatório =======================================
                    report.SetParameters(new ReportParameter("empresa", empresa.nome));
                    report.SetParameters(new ReportParameter("cnpj", empresa.cpfcnpj));
                    report.SetParameters(new ReportParameter("uf", empresa.estado));
                    report.SetParameters(new ReportParameter("cidade", empresa.cidade));
                    report.SetParameters(new ReportParameter("telefone", empresa.telefone));
                    report.SetParameters(new ReportParameter("email", empresa.email));
                    report.SetParameters(new ReportParameter("dtInicio", inicio.ToShortDateString()));
                    report.SetParameters(new ReportParameter("dtFim", fim.ToShortDateString()));

                    Ferramentas.relatorio.exportarRelatorio(report, "PDF");
                }
            }

            reportViewer1.LocalReport.EnableExternalImages = true;

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("logo", caminhoImagem));

            //Carregando dados da empresa no relatório =======================================
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("empresa", empresa.nome));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("cnpj", empresa.cpfcnpj));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("uf", empresa.estado));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("cidade", empresa.cidade));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("telefone", empresa.telefone));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("email", empresa.email));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("dtInicio", inicio.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("dtFim", fim.ToShortDateString()));

            //reportViewer1.LocalReport.DataSources.Add(rpt);
            this.reportViewer1.RefreshReport();
            //this.reportViewer1.LocalReport.DataSources.Add(rptDataSource);

        }

        private void reportViewer1_Print(object sender, ReportPrintEventArgs e)
        {
            e.PrinterSettings.DefaultPageSettings.Margins.Right = 0;
            e.PrinterSettings.DefaultPageSettings.Margins.Left = 0;
            e.PrinterSettings.DefaultPageSettings.Margins.Top = 0;
            e.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0;
        }
    }
}
