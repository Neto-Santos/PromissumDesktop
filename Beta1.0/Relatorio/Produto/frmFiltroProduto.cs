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

namespace Beta1._0.Relatorio.Produto
{
    public partial class frmFiltroProduto : Form
    {
        public frmFiltroProduto(DalConexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        DalConexao conexao;
        //Variável será utilizada no momento em que for imprimir uma venda ou orçamento.
        public int codVenda;

        //Variável será utilizada no momento em que for imprimir uma listagem dos produtos.
        public int codProduto { get; set; }
        public int contadorProduto = 0;
        private string formato;

        //int alturaPagina = 0;
        //int y = 50;

        //Variável muito importante no momento de quebra de páginas.
        //int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo = rbSintetico.Checked ? "sintetico" : "analitico";
            Relatorio_Atualizado.Produtos.frmRelatorio frm = new Relatorio_Atualizado.Produtos.frmRelatorio(txtProduto.Text, txtReferencia.Text, txtSubCategoria.Text, txtCategoria.Text,tipo,dtInicio.Value.ToShortDateString(),dtFim.Value.ToShortDateString(), conexao);
            frm.ShowDialog();
        }
        //public void imprimiA4ProdutosSintetico(System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    //documento.PrinterSettings.PrinterName = cbImpressora.SelectedItem.ToString();
        //    int alturaPagina = 0;
        //    int y = 50;

        //    Rectangle posicao = new Rectangle(0, 50, (documento.DefaultPageSettings.Bounds.Width), 30);
        //    posicao.Y = y;
        //    alturaPagina = documento.DefaultPageSettings.Bounds.Height;
        //    int larguraPagina = documento.DefaultPageSettings.Bounds.Width;
        //    StringBuilder sb = new StringBuilder();

        //    var fonteArial16Regu = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
        //    var fonteLucida10Rege = new Font("Lucida Sans Unicode", 10, FontStyle.Regular, GraphicsUnit.Pixel);
        //    var fonteLucida12Bold = new Font("Lucida Sans Unicode", 12, FontStyle.Bold, GraphicsUnit.Pixel);
        //    var corpreta = new SolidBrush(Color.Black);

        //    decimal totalCusto = 0;
        //    decimal totalVenda = 0;

        //    #region variaveis de alinhamento
        //    var alinhamentodireita = new StringFormat
        //    {
        //        Alignment = StringAlignment.Far,
        //        LineAlignment = StringAlignment.Far
        //    };
        //    var alinhamentocentro = new StringFormat
        //    {
        //        Alignment = StringAlignment.Center,
        //        LineAlignment = StringAlignment.Center
        //    };
        //    var alinhamentoesquerda = new StringFormat
        //    {
        //        Alignment = StringAlignment.Near,
        //        LineAlignment = StringAlignment.Near
        //    };
        //    #endregion

        //    #region Logo do Sistema
        //    //Desenhando um Linha
        //    e.Graphics.DrawString("NG SYSTEM - SOLUÇÕES EM SISTEMAS  CONTATO = 75 9 8107 1164  EMAIL: NGSYSTEM@GMAIL.COM", fonteLucida10Rege, new SolidBrush(Color.Red), 2, 2);
        //    e.Graphics.DrawRectangle(new Pen(Color.Red), new Rectangle(2, 1, larguraPagina, 1));
        //    #endregion

        //    #region Título do Relatório           

        //    string Orçamento = "PRODUTOS";
        //    Rectangle linha = new Rectangle(0, 100, larguraPagina, 1);
        //    y += 20;
        //    posicao.Y = y;
        //    posicao.X = 0;
        //    posicao.Width = larguraPagina;
        //    e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), linha);
        //    e.Graphics.DrawString(Orçamento, fonteArial16Regu, corpreta, posicao, alinhamentocentro);
        //    var tamanholinha = e.Graphics.MeasureString(Orçamento, fonteArial16Regu);

        //    #endregion

        //    #region Listagem dos Itens


        //    var bllProduto = new BLL.BLLProduto(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
        //    var lista = bllProduto.RelatorioProdutoAnalitico(txtProduto.Text, dtInicio.Value.ToShortDateString(), dtFim.Value.ToShortDateString(), txtCategoria.Text, txtSubCategoria.Text, txtReferencia.Text);


        //    //Definindo a altura inicial da listagem dos produtos.
        //    y += 40;

        //    posicao.X = 10;
        //    posicao.Y = y;
        //    e.Graphics.DrawString("Descrição", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 200;
        //    e.Graphics.DrawString("Custo", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 250;
        //    e.Graphics.DrawString("Venda", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 300;
        //    e.Graphics.DrawString("QTD", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 350;
        //    e.Graphics.DrawString("Ref", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 400;
        //    e.Graphics.DrawString("Und", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 500;
        //    e.Graphics.DrawString("Categoria", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 600;
        //    e.Graphics.DrawString("SubCategoria", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 700;
        //    e.Graphics.DrawString("Localização", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);

        //    while (contadorProduto <= lista.Rows.Count)
        //    {
        //        if (contadorProduto == lista.Rows.Count)
        //        {
        //            break;
        //        }

        //        var valorPago = Convert.ToDecimal(lista.Rows[contadorProduto]["Custo"]);
        //        totalCusto += valorPago;

        //        var valorVenda = Convert.ToDecimal(lista.Rows[contadorProduto]["Venda"]);
        //        totalVenda += valorVenda;

        //        var referencia = lista.Rows[contadorProduto]["Referencia"].ToString();
        //        var und = lista.Rows[contadorProduto]["Und"].ToString();
        //        var categoria = lista.Rows[contadorProduto]["Categoria"].ToString();
        //        var subCategoria = lista.Rows[contadorProduto]["SubCategoria"].ToString();
        //        var localizacao = lista.Rows[contadorProduto]["Localização"].ToString();

        //        y += 20;

        //        posicao.Y =y;

        //        posicao.X = 10;
        //        e.Graphics.DrawString((lista.Rows[contadorProduto]["Produto"]).ToString(), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 200;
        //        e.Graphics.DrawString(valorPago.ToString("N2"), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 250;
        //        e.Graphics.DrawString(valorVenda.ToString("N2"), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 300;
        //        e.Graphics.DrawString(lista.Rows[contadorProduto]["Quantidade"].ToString(), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 350;
        //        e.Graphics.DrawString(referencia, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 400;
        //        e.Graphics.DrawString(und, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 500;
        //        e.Graphics.DrawString(categoria, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 600;
        //        e.Graphics.DrawString(subCategoria, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 700;
        //        e.Graphics.DrawString(localizacao, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);

        //        contadorProduto++;


        //        if (y >= alturaPagina - 50)
        //        {
        //            e.HasMorePages = true;
        //            y = 40;
        //            return;
        //        }


        //    }
        //    posicao.Y = y + 20;
           
        //    posicao.X = 20;
        //    e.Graphics.DrawString("Quantidade de Itens: " + contadorProduto.ToString(), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);

        //    posicao.Y = y + 30;
            
        //    e.Graphics.DrawString("Total em Custo Unitário: " + totalCusto.ToString("N2"), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);

        //    posicao.Y = y + 40;
            
        //    e.Graphics.DrawString("Total em Venda Unitário: " + totalVenda.ToString("N2"), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);

        //    #endregion

        //}
        //public void imprimiA4ProdutosAnalitico(System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    Rectangle posicao = new Rectangle(0, 50, (documento.DefaultPageSettings.Bounds.Width), 30);
        //    int alturaPagina = 0;
        //    int y = 50;
        //    posicao.Y = y;
        //    alturaPagina = documento.DefaultPageSettings.Bounds.Height;
        //    int larguraPagina = documento.DefaultPageSettings.Bounds.Width;
        //    StringBuilder sb = new StringBuilder();

        //    var fonteArial16Regu = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
        //    var fonteLucida10Rege = new Font("Lucida Sans Unicode", 10, FontStyle.Regular, GraphicsUnit.Pixel);
        //    var fonteLucida12Bold = new Font("Lucida Sans Unicode", 12, FontStyle.Bold, GraphicsUnit.Pixel);
        //    var corpreta = new SolidBrush(Color.Black);

        //    decimal totalCusto = 0;
        //    decimal totalVenda = 0;

        //    #region variaveis de alinhamento
        //    var alinhamentodireita = new StringFormat
        //    {
        //        Alignment = StringAlignment.Far,
        //        LineAlignment = StringAlignment.Far
        //    };
        //    var alinhamentocentro = new StringFormat
        //    {
        //        Alignment = StringAlignment.Center,
        //        LineAlignment = StringAlignment.Center
        //    };
        //    var alinhamentoesquerda = new StringFormat
        //    {
        //        Alignment = StringAlignment.Near,
        //        LineAlignment = StringAlignment.Near
        //    };
        //    #endregion

        //    #region Logo do Sistema
        //    //Desenhando um Linha
        //    e.Graphics.DrawString("NG SYSTEM - SOLUÇÕES EM SISTEMAS  CONTATO = 75 9 8107 1164  EMAIL: NGSYSTEM@GMAIL.COM", fonteLucida10Rege, new SolidBrush(Color.Red), 2, 2);
        //    e.Graphics.DrawRectangle(new Pen(Color.Red), new Rectangle(2, 1, larguraPagina, 1));
        //    #endregion

        //    #region Título do Relatório           

        //    string Orçamento = "PRODUTOS";
        //    Rectangle linha = new Rectangle(0, 100, larguraPagina, 1);
        //    y += 20;
        //    posicao.Y = y;
        //    posicao.X = 0;
        //    posicao.Width = larguraPagina;
        //    e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), linha);
        //    e.Graphics.DrawString(Orçamento, fonteArial16Regu, corpreta, posicao, alinhamentocentro);
        //    var tamanholinha = e.Graphics.MeasureString(Orçamento, fonteArial16Regu);

        //    #endregion

        //    #region Listagem dos Itens


        //    var bllProduto = new BLL.BLLProduto(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
        //    var lista = bllProduto.RelatorioProdutoAnalitico(txtProduto.Text, dtInicio.Value.ToShortDateString(), dtFim.Value.ToShortDateString(), txtCategoria.Text, txtSubCategoria.Text, txtReferencia.Text);


        //    //Definindo a altura inicial da listagem dos produtos.
        //    y += 40;

        //    posicao.X = 10;
        //    posicao.Y = y;
        //    e.Graphics.DrawString("Descrição", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 200;
        //    e.Graphics.DrawString("Custo", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 250;
        //    e.Graphics.DrawString("Venda", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 300;
        //    e.Graphics.DrawString("QTD", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 350;
        //    e.Graphics.DrawString("Ref", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 400;
        //    e.Graphics.DrawString("Und", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 500;
        //    e.Graphics.DrawString("Categoria", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 600;
        //    e.Graphics.DrawString("SubCategoria", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //    posicao.X = 700;
        //    e.Graphics.DrawString("Localização", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);

        //    while (contadorProduto <= lista.Rows.Count)
        //    {
        //        if (contadorProduto == lista.Rows.Count)
        //        {
        //            break;
        //        }

        //        var valorPago = Convert.ToDecimal(lista.Rows[contadorProduto]["Custo"]);
        //        totalCusto += valorPago;

        //        var valorVenda = Convert.ToDecimal(lista.Rows[contadorProduto]["Venda"]);
        //        totalVenda += valorVenda;

        //        var referencia = lista.Rows[contadorProduto]["Referencia"].ToString();
        //        var und = lista.Rows[contadorProduto]["Und"].ToString();
        //        var categoria = lista.Rows[contadorProduto]["Categoria"].ToString();
        //        var subCategoria = lista.Rows[contadorProduto]["SubCategoria"].ToString();
        //        var localizacao = lista.Rows[contadorProduto]["Localização"].ToString();

        //        y += 20;

        //        posicao.Y = y;

        //        posicao.X = 10;
        //        e.Graphics.DrawString((lista.Rows[contadorProduto]["Produto"]).ToString(), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 200;
        //        e.Graphics.DrawString(valorPago.ToString("N2"), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 250;
        //        e.Graphics.DrawString(valorVenda.ToString("N2"), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 300;
        //        e.Graphics.DrawString(lista.Rows[contadorProduto]["Quantidade"].ToString(), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 350;
        //        e.Graphics.DrawString(referencia, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 400;
        //        e.Graphics.DrawString(und, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 500;
        //        e.Graphics.DrawString(categoria, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 600;
        //        e.Graphics.DrawString(subCategoria, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
        //        posicao.X = 700;
        //        e.Graphics.DrawString(localizacao, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);

        //        contadorProduto++;


        //        if (y >= alturaPagina - 50)
        //        {
        //            e.HasMorePages = true;
        //            y = 40;
        //            return;
        //        }


        //    }
        //    posicao.Y = y + 20;
        //    posicao.X = 20;
        //    e.Graphics.DrawString("Quantidade de Itens: " + contadorProduto.ToString(), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);

        //    posicao.Y = y + 30;
        //    e.Graphics.DrawString("Total em Custo Unitário: " + totalCusto.ToString("N2"), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);

        //    posicao.Y = y + 40;
        //    e.Graphics.DrawString("Total em Venda Unitário: " + totalVenda.ToString("N2"), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);

        //    #endregion

        //}
        //private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    imprimiA4ProdutosSintetico(e);
        //}

        private void frmFiltroProduto_Load(object sender, EventArgs e)
        {
            Ferramentas.impressao objferra = new Ferramentas.impressao();
            //objferra.CarregarListaDeImpressoras(cbImpressora);
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            string tipo = rbSintetico.Checked ? "sintetico" : "analitico";
            this.formato = "pdf";
            Relatorio_Atualizado.Produtos.frmRelatorio frm = new Relatorio_Atualizado.Produtos.frmRelatorio(txtProduto.Text, txtReferencia.Text, txtSubCategoria.Text, txtCategoria.Text, tipo, dtInicio.Value.ToShortDateString(), dtFim.Value.ToShortDateString(), conexao,formato);
            frm.ShowDialog();
        }
    }
}
