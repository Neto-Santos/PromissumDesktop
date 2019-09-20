using Microsoft.Reporting.WinForms;
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

namespace Beta1._0.Relatorio_Atualizado.ClienteProdutos
{
    public partial class frmClienteProdutos : Form
    {

        promissumServicoEntities contexto = new promissumServicoEntities();
        public frmClienteProdutos()
        {
            InitializeComponent();

            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
        }
        string cliente, referencia, produto, formato;
        private void frmClienteProdutos_Load(object sender, EventArgs e)
        {
            var caminhoRelatorio = "Promissum.Relatorio_Atualizado.ClienteProdutos.rptClienteProduto.rdlc";
            string caminhoImagem = Ferramentas.xmlConfig.config.retornaLogo();

            DataTable tabela = new DataTable();
            tabela.Columns.Add("cod", typeof(int));
            tabela.Columns.Add("cli_nome", typeof(string));
            tabela.Columns.Add("referencia", typeof(string));
            tabela.Columns.Add("pro_nome", typeof(string));
            tabela.Columns.Add("pro_valorpago", typeof(decimal));
            tabela.Columns.Add("pro_valorvenda", typeof(decimal));
            tabela.Columns.Add("cat_nome", typeof(string));
            tabela.Columns.Add("scat_nome", typeof(string));

            var lista = contexto.ClienteProduto.Include("cliente").Include("produto").ToList();


            foreach (var item in lista)
            {
                tabela.Rows.Add(item.cod, item.cliente.cli_nome, item.referencia,
                    item.produto.pro_nome, item.produto.pro_valorpago, item.produto.pro_valorvenda,
                    item.produto.categoria.cat_nome, item.produto.subcategoria.scat_nome);
            }

            if (formato == "pdf")
            {
                this.Hide();
                LocalReport report = new LocalReport();

                report.ReportEmbeddedResource = caminhoRelatorio;

                //report.DataSources.Add(rpt);

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
                ReportDataSource rpt = new ReportDataSource("dsClienteProduto", tabela);
                reportViewer1.LocalReport.DataSources.Add(rpt);
                reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("logo", caminhoImagem));
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
