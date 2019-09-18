using Beta1._0.Relatorio.Produto;
using DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Promissum.Relatorio_Atualizado.Produtos;
using System.Windows.Forms;

namespace Beta1._0.Relatorio_Atualizado.Produtos
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio(string nome,string _ref,string subCategoria,string categoria,string tipo,string inicio,string fim,DalConexao conexao,string formato="")
        {
            InitializeComponent();
            this.conexao = conexao;
            this.nome = nome;
            this._ref = _ref;
            this.subCategoria = subCategoria;
            this.categoria = categoria;
            this.tipo = tipo;
            this.inicio = inicio;
            this.fim = fim;
            this.formato = formato;
        }

        string nome, _ref, inicio, fim, subCategoria, categoria, tipo, formato;  
              
        DalConexao conexao;        
        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;

            string caminhoImagem = Ferramentas.xmlConfig.config.retornaLogo();
            var tabela = new Promissum.Relatorio_Atualizado.Produtos.dsProduto.dsProdutoSinteticoDataTable();
            var ta = new Promissum.Relatorio_Atualizado.Produtos.dsProdutoTableAdapters.dsProdutoSinteticoTableAdapter();
            tabela = ta.GetData(nome, _ref, subCategoria, categoria, inicio, fim);
            var caminhoRelatorio = "Promissum.Relatorio_Atualizado.Produtos.reportProduto.rdlc";
            ReportDataSource rpt = new ReportDataSource("dsProdutoSintetico", tabela.Rows);

            if (tipo == "sintetico")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = caminhoRelatorio;
            }
            else
            {
              
            }
      
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
                reportViewer1.LocalReport.DataSources.Add(rpt);

                reportViewer1.LocalReport.EnableExternalImages = true;

                this.reportViewer1.LocalReport.SetParameters(new ReportParameter("logo", caminhoImagem));

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
