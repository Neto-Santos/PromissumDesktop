using CrystalDecisions.Shared;
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

namespace Beta1._0.Relatorio_Atualizado.Fornecedor
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio(string nome, string razao, string cnpj, string cidade, string uf,string inicio,string fim,string formato)
        {
            InitializeComponent();
            this.nome = nome;
            this.razao = razao;
            this.cnpj = cnpj;
            this.cidade = cidade;
            this.uf = uf;
            this.inicio = inicio;
            this.fim = fim;
            this.formato = formato;
        }
        string nome, razao, cnpj, cidade, uf, inicio, fim, formato;
        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;

            var tabela = new Promissum.Relatorio_Atualizado.Fornecedor.dsFornecedor.dsFornecedorDataTable();
            var ta = new Promissum.Relatorio_Atualizado.Fornecedor.dsFornecedorTableAdapters.dsFornecedorTableAdapter();
            var caminhoRelatorio = "Promissum.Relatorio_Atualizado.Fornecedor.rptFornecedor.rdlc";
            tabela = ta.GetData(nome, razao, cnpj, cidade, uf,inicio,fim);

            ReportDataSource rpt = new ReportDataSource("dsFornecedor", tabela.Rows);           

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
