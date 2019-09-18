using DAL;
using Microsoft.Reporting.WinForms;
using Promissum;
using Promissum.Relatorio;
using Promissum.Relatorio_Atualizado.Categoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta1._0.Relatorio_Atualizado.Categoria
{
    public partial class frmRelatorioCategoria : Form
    {
        public frmRelatorioCategoria(string categoria, string subCategoria, DateTime inicio, DateTime fim, DalConexao conexao, string formato)
        {
            InitializeComponent();
            this.conexao = conexao;
            this.categoria = categoria;
            this.subCategoria = subCategoria;
            this.inicio = inicio;
            this.fim = fim;
            this.formato = formato;
        }
        public string formato { get; set; }
        DateTime inicio, fim;
        DalConexao conexao;
        string categoria;
        string subCategoria;
        private void frmRelatorioCategoria_Load(object sender, EventArgs e)
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

            var caminhoRelatorio = "Promissum.Relatorio_Atualizado.Categoria.rptCategoria.rdlc";

            var adapter = new Promissum.Relatorio_Atualizado.Categoria.dsSubCategoriaTableAdapters.dsCategoriaTableAdapter();
            var tabela = new dsSubCategoria.dsCategoriaDataTable();
            tabela = adapter.GetData(categoria, subCategoria, inicio.ToShortDateString(), fim.ToShortDateString());
            string caminhoImagem = Ferramentas.xmlConfig.config.retornaLogo();
            ReportDataSource rpt = new ReportDataSource("dsCategoria", tabela.Rows);

            if (formato == "pdf")
            {
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
