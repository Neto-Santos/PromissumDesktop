using DAL;
using Microsoft.Reporting.WinForms;
using Promissum.Relatorio_Atualizado.Cliente;
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
    public partial class frmRelatorioCliente : Form
    {
        public frmRelatorioCliente(DalConexao conexao, string formato = "")
        {
            InitializeComponent();
            this.conexao = conexao;
            this.formato = formato;
        }
        public string formato { get; set; }
        public string nome { get; set; }
        public string dataInicial { get; set; }
        public string dataFinal { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string status { get; set; }
        public string defeito { get; set; }
        public string solucao { get; set; }
        public string referencia { get; set; }
        public string tipo { get; set; }

        DalConexao conexao;
        private void frmRelatorioCliente_Load(object sender, EventArgs e)
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
                string caminhoRelatorio = "Promissum.Relatorio_Atualizado.Cliente.rptClienteSintetico.rdlc";
                var ta = new Promissum.Relatorio_Atualizado.Cliente.dsClienteTableAdapters.clienteTableAdapter();
                var tabela = new dsCliente.clienteDataTable();
                tabela = ta.GetData(nome, cidade, estado, "", dataInicial, dataFinal);
                ReportDataSource rpt = new ReportDataSource("dsCliente", tabela.Rows);
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
        }
    }
}
