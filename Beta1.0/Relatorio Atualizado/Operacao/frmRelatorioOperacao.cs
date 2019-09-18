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

namespace Promissum.Relatorio_Atualizado.Operacao
{
    public partial class frmRelatorioOperacao : Form
    {
        public frmRelatorioOperacao()
        {
            InitializeComponent();
        }
        public string status = " ";
        public string produto = " ";
        public string operacao = " ";
        public string cliente = " ";
        public string dataInicio;
        public string dataFim;
        public string formato = " ";
        public string ns = " ";
        public string tipo = " ";

        DAL.DalConexao conexao;
        private void frmRelatorioOperacao_Load(object sender, EventArgs e)
        {
            if (formato == "pdf")
            {
                //Esconde o formulário.
                this.Hide();
            }

            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;

            //var bll = new BLL.BllCliente(conexao);

            if (tipo == "Analitico")
            {
                //    ReportDataSource rpt = new ReportDataSource("dsCliente", bll.LocalizarRelatorioAnalitico(nome, dataInicial, dataFinal, cidade, estado, status, defeito, solucao, referencia));
                //    reportViewer1.LocalReport.ReportEmbeddedResource = "Beta1._0.Relatorio_Atualizado.Cliente.rptCliente.rdlc";
                //    reportViewer1.LocalReport.DataSources.Add(rpt);
            }
            else

            {
                string caminhoRelatorio = "Promissum.Relatorio_Atualizado.Operacao.rptOperacaoCliente.rdlc";

                var ta = new Promissum.Relatorio_Atualizado.Operacao.dsOperacaoTableAdapters.dsOperacaoTableAdapter();
               
                var tabela = new dsOperacao.dsOperacaoDataTable();
                tabela.Clear();
                
                tabela = ta.GetData(status,dataInicio, dataFim);

                ReportDataSource rpt = new ReportDataSource("dsOperacao", tabela.Rows);
                reportViewer1.LocalReport.DataSources.Add(rpt);
                string caminhoImagem = Ferramentas.xmlConfig.config.retornaLogo();

                if (formato == "pdf")
                {
                    this.Hide();
                    LocalReport report = new LocalReport();

                    report.ReportEmbeddedResource = caminhoRelatorio;

                    report.DataSources.Add(rpt);

                    report.EnableExternalImages = true;

                    report.SetParameters(new ReportParameter("logo", caminhoImagem));

                    try
                    {
                        Ferramentas.relatorio.exportarRelatorio(report, "PDF");
                        this.Close();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

                else
                {

                    reportViewer1.LocalReport.ReportEmbeddedResource = caminhoRelatorio;

                    reportViewer1.LocalReport.DataSources.Add(rpt);

                    reportViewer1.LocalReport.EnableExternalImages = true;

                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter("logo", caminhoImagem));
                }

            }

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
