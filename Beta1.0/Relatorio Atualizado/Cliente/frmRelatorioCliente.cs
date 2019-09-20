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
using DAL.EntityFramework;

namespace Beta1._0.Relatorio_Atualizado.Cliente
{
    public partial class frmRelatorioCliente : Form
    {
        promissumServicoEntities contexto = new promissumServicoEntities();
        public frmRelatorioCliente()
        {
            InitializeComponent();
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


        private void frmRelatorioCliente_Load(object sender, EventArgs e)
        {
            if (formato == "pdf")
            {
                this.Hide();
            }
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            string caminhoRelatorio = null;

            if (tipo == "Analitico")
            {

                caminhoRelatorio = "Promissum.Relatorio_Atualizado.Cliente.rptClienteAnalitico.rdlc";

                DataTable dsClienteSintetico = new DataTable();
                dsClienteSintetico.Columns.Add("cli_cod", typeof(int));
                dsClienteSintetico.Columns.Add("cli_nome", typeof(string));
                dsClienteSintetico.Columns.Add("cli_cpfcnpj", typeof(string));
                dsClienteSintetico.Columns.Add("cli_rgie", typeof(string));
                dsClienteSintetico.Columns.Add("cli_rsocial", typeof(string));
                dsClienteSintetico.Columns.Add("cli_tipo", typeof(string));
                dsClienteSintetico.Columns.Add("cli_cep", typeof(string));
                dsClienteSintetico.Columns.Add("cli_endereco", typeof(string));
                dsClienteSintetico.Columns.Add("cli_bairro", typeof(string));
                dsClienteSintetico.Columns.Add("cli_fone", typeof(string));
                dsClienteSintetico.Columns.Add("cli_cel", typeof(string));
                dsClienteSintetico.Columns.Add("cli_email", typeof(string));
                dsClienteSintetico.Columns.Add("cli_endnumero", typeof(string));
                dsClienteSintetico.Columns.Add("cli_cidade", typeof(string));
                dsClienteSintetico.Columns.Add("cli_estado", typeof(string));
                dsClienteSintetico.Columns.Add("cli_observacao", typeof(string));
                dsClienteSintetico.Columns.Add("cli_cadastro", typeof(DateTime));

                var lista = contexto.cliente.Select(c => new
                {
                    c.cli_cod,
                    c.cli_nome,
                    c.cli_cpfcnpj,
                    c.cli_rgie,
                    c.cli_rsocial,
                    c.cli_tipo,
                    c.cli_cep,
                    c.cli_endereco,
                    c.cli_bairro,
                    c.cli_fone,
                    c.cli_cel,
                    c.cli_email,
                    c.cli_endnumero,
                    c.cli_cidade,
                    c.cli_estado,
                    c.cli_observacao,
                    c.cli_cadastro
                }).Where(c => c.cli_cadastro.Value > dataInicio && c.cli_cadastro.Value <= dataFim &&
                 c.cli_nome.Contains(nome) &&
                c.cli_cidade.Contains(cidade) && c.cli_estado.Contains(estado)).ToList();

            }
            else
            {
                DataTable dsClienteSintetico = new DataTable();
                dsClienteSintetico.Columns.Add("cli_cod", typeof(int));
                dsClienteSintetico.Columns.Add("cli_nome", typeof(string));
                dsClienteSintetico.Columns.Add("cli_cpfcnpj", typeof(string));
                dsClienteSintetico.Columns.Add("cli_rgie", typeof(string));
                dsClienteSintetico.Columns.Add("cli_rsocial", typeof(string));
                dsClienteSintetico.Columns.Add("cli_tipo", typeof(string));
                dsClienteSintetico.Columns.Add("cli_cep", typeof(string));
                dsClienteSintetico.Columns.Add("cli_endereco", typeof(string));
                dsClienteSintetico.Columns.Add("cli_bairro", typeof(string));
                dsClienteSintetico.Columns.Add("cli_fone", typeof(string));
                dsClienteSintetico.Columns.Add("cli_cel", typeof(string));
                dsClienteSintetico.Columns.Add("cli_email", typeof(string));
                dsClienteSintetico.Columns.Add("cli_endnumero", typeof(string));
                dsClienteSintetico.Columns.Add("cli_cidade", typeof(string));
                dsClienteSintetico.Columns.Add("cli_estado", typeof(string));
                dsClienteSintetico.Columns.Add("cli_observacao", typeof(string));
                dsClienteSintetico.Columns.Add("cli_cadastro", typeof(DateTime));

                var dataInicio = Convert.ToDateTime(dataInicial);
                var dataFim = Convert.ToDateTime(dataFinal);

                var lista = contexto.cliente.Select(c => new
                {
                    c.cli_cod,
                    c.cli_nome,
                    c.cli_cpfcnpj,
                    c.cli_rgie,
                    c.cli_rsocial,
                    c.cli_tipo,
                    c.cli_cep,
                    c.cli_endereco,
                    c.cli_bairro,
                    c.cli_fone,
                    c.cli_cel,
                    c.cli_email,
                    c.cli_endnumero,
                    c.cli_cidade,
                    c.cli_estado,
                    c.cli_observacao,
                    c.cli_cadastro
                }).Where(c => c.cli_cadastro.Value > dataInicio && c.cli_cadastro.Value <= dataFim &&
                 c.cli_nome.Contains(nome) &&
                c.cli_cidade.Contains(cidade) && c.cli_estado.Contains(estado)).ToList();

                foreach (var item in lista)
                {
                    dsClienteSintetico.Rows.Add(item.cli_cod, item.cli_nome, item.cli_cpfcnpj, item.cli_rgie, item.cli_rsocial, item.cli_tipo, item.cli_cep,
                        item.cli_endereco, item.cli_bairro, item.cli_fone, item.cli_cel,item.cli_email,item.cli_endnumero,item.cli_cidade,item.cli_estado,item.cli_observacao,item.cli_cadastro);
                }


                caminhoRelatorio = "Promissum.Relatorio_Atualizado.Cliente.rptClienteSintetico.rdlc";

                ReportDataSource rpt = new ReportDataSource("dsClienteSintetico", dsClienteSintetico);
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
