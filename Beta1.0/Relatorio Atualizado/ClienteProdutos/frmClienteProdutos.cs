using Microsoft.Reporting.WinForms;
using Promissum.Relatorio_Atualizado.ClienteProdutos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta1._0.Relatorio_Atualizado.ClienteProdutos
{
    public partial class frmClienteProdutos : Form
    {
        public frmClienteProdutos(string cliente, string referencia, string produto, string formato)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.referencia = referencia;
            this.produto = produto;
            this.formato = formato;
        }
        string cliente, referencia, produto, formato;
        private void frmClienteProdutos_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;

            var tabela = new dsClienteProduto.dsClienteProdutoDataTable();

            var ta = new Promissum.Relatorio_Atualizado.ClienteProdutos.dsClienteProdutoTableAdapters.dsClienteProdutoTableAdapter();

            var caminhoRelatorio = "Promissum.Relatorio_Atualizado.ClienteProdutos.rptClienteProduto.rdlc";

            tabela = ta.GetData(cliente, referencia, produto);

            ReportDataSource rpt = new ReportDataSource("dsClienteProduto", tabela.Rows);
            
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
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
