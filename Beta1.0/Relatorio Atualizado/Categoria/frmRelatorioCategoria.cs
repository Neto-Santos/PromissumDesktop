using DAL.EntityFramework;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Beta1._0.Relatorio_Atualizado.Categoria
{
    public partial class frmRelatorioCategoria : Form
    {
        public frmRelatorioCategoria()
        {
            InitializeComponent();

        }
        promissumServicoEntities contexto = new promissumServicoEntities();
        private void frmRelatorioCategoria_Load(object sender, EventArgs e)
        {

            var lista = contexto.subcategoria.ToList();
            DataTable tabela = new DataTable();

            tabela.Columns.Add("scat_cod", typeof(int));
            tabela.Columns.Add("scat_nome",typeof(string));
            tabela.Columns.Add("scat_cadastro",typeof(DateTime));
            tabela.Columns.Add("cat_cod", typeof(int));

            foreach (var item in lista)
            {
                tabela.Rows.Add(item.scat_cod, item.scat_nome, item.scat_cadastro, item.cat_cod);
            }

            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;


            string caminhoRelatorio = "Promissum.Relatorio_Atualizado.Categoria.rptCategoria.rdlc";

            ReportDataSource rpt = new ReportDataSource("dsSubCategoria", tabela);
            string caminhoImagem = Ferramentas.xmlConfig.config.retornaLogo();


            reportViewer1.LocalReport.ReportEmbeddedResource = caminhoRelatorio;

            reportViewer1.LocalReport.DataSources.Add(rpt);

            reportViewer1.LocalReport.EnableExternalImages = true;

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("logo", caminhoImagem));
            
            this.reportViewer1.RefreshReport();
        }
    }
}
