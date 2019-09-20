using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta1._0.Relatorio.Produto.ClienteProduto
{
    public partial class frmFiltroClienteProduto : Form
    {
        public frmFiltroClienteProduto(DalConexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        DalConexao conexao;
        public int codVenda;

        //Variável será utilizada no momento em que for imprimir uma listagem dos produtos.
        public int codProduto { get; set; }
        public int contadorProduto = 0;
        private string formato;

        //int alturaPagina = 0;
        //int y = 50;

        //Variável muito importante no momento de quebra de páginas.
        //int i = 0;

        private void frmFiltroClienteProduto_Load(object sender, EventArgs e)
        {
            Ferramentas.impressao objferra = new Ferramentas.impressao();
            //objferra.CarregarListaDeImpressoras(cbImpressora);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Relatorio_Atualizado.ClienteProdutos.frmClienteProdutos frm = new Relatorio_Atualizado.ClienteProdutos.frmClienteProdutos();
            frm.ShowDialog();

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //imprimiA4Sintetico(e);
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            this.formato = "pdf";
            Relatorio_Atualizado.ClienteProdutos.frmClienteProdutos frm = new Relatorio_Atualizado.ClienteProdutos.frmClienteProdutos();
            frm.ShowDialog();
        }
    }
}
