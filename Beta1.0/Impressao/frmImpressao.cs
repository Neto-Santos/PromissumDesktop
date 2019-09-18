using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta1._0.Impressao
{
    public partial class frmImpressao : Form
    {
        public frmImpressao()
        {
            InitializeComponent();
        }
        //Variável será utilizada no momento em que for imprimir uma venda ou orçamento.
        public int codVenda;

        //Variável será utilizada no momento em que for imprimir uma listagem dos produtos.
        public int codProduto { get; set; }
        public int contadorProduto = 0;

        int alturaPagina = 0;
        int y = 50;

        //Variável muito importante no momento de quebra de páginas.
        //int i = 0;
        private void frmImpressao_Load(object sender, EventArgs e)
        {
            //pre_visualizacao.Document = documento;
            ////Inicaliza o preview da impressão maximizada
            //((Form)printPreviewDialog).WindowState = FormWindowState.Maximized;
            //printPreviewDialog.ShowDialog();
            //printDocument1.Print();
        }
        private void btnPrever_Click(object sender, EventArgs e)
        {
            pre_visualizacao.Document = documento;
            pre_visualizacao.ShowDialog();
        }
        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            imprimiA4Produtos(e);
        }
        public void imprimiA4Produtos(PrintPageEventArgs e)
        {
            Rectangle posicao = new Rectangle(0, 50, (documento.DefaultPageSettings.Bounds.Width), 30);
            posicao.Y = y;
            alturaPagina = documento.DefaultPageSettings.Bounds.Height;
            int larguraPagina = documento.DefaultPageSettings.Bounds.Width;
            StringBuilder sb = new StringBuilder();

            var fonteArial16Regu = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            var fonteLucida10Rege = new Font("Lucida Sans Unicode", 10, FontStyle.Regular, GraphicsUnit.Pixel);
            var fonteLucida12Bold = new Font("Lucida Sans Unicode", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            var corpreta = new SolidBrush(Color.Black);

            #region variaveis de alinhamento
            var alinhamentodireita = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Far
            };
            var alinhamentocentro = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var alinhamentoesquerda = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            };
            #endregion
        
            #region Logo do Sistema
            //Desenhando um Linha
            e.Graphics.DrawString("NG SYSTEM - SOLUÇÕES EM SISTEMAS  CONTATO = 75 9 8107 1164  EMAIL: NGSYSTEM@GMAIL.COM", fonteLucida10Rege, new SolidBrush(Color.Red), 2, 2);
            e.Graphics.DrawRectangle(new Pen(Color.Red), new Rectangle(2, 1, larguraPagina, 1));
            #endregion

            #region Título do Relatório           

            string Orçamento = "PRODUTOS";
            Rectangle linha = new Rectangle(0, 100, larguraPagina, 1);
            y += 20;
            posicao.Y = y;
            posicao.X = 0;
            posicao.Width = larguraPagina;
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), linha);
            e.Graphics.DrawString(Orçamento, fonteArial16Regu, corpreta, posicao, alinhamentocentro);
            var tamanholinha = e.Graphics.MeasureString(Orçamento, fonteArial16Regu);

            #endregion

            #region Listagem dos Itens

            var bllProduto = new BLL.BLLProduto(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            var lista = bllProduto.LocalizaProdutos();

     //       "SELECT [pro_cod] as codigo,[pro_nome] as nome,[pro_ref] as Referencia,[pro_descricao] as descrição " +
     // ",[pro_valorpago] as custo,[pro_valorvenda] as Venda ,[pro_qtde] as Quantidade " +
     // ",[umed] as Und,cat_nome as Categoria,scat_nome as SubCategoria, localizacao as Localização " +
     // "FROM produto p " +
     // "inner join categoria c on p.cat_cod = c.cat_cod " +
     //"inner join subcategoria sb on p.scat_cod = sb.scat_cod ";

            //Definindo a altura inicial da listagem dos produtos.
            y += 40;

            posicao.X = 10;
            posicao.Y = y;
            e.Graphics.DrawString("Descrição", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 200;
            e.Graphics.DrawString("Custo", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 250;
            e.Graphics.DrawString("Venda", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 300;
            e.Graphics.DrawString("QTD", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 350;
            e.Graphics.DrawString("Ref", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 400;
            e.Graphics.DrawString("Und", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 500;
            e.Graphics.DrawString("Categoria", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 600;
            e.Graphics.DrawString("SubCategoria", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 700;
            e.Graphics.DrawString("Localização", fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);

            while (contadorProduto <= lista.Rows.Count)
            {
                if (contadorProduto == lista.Rows.Count)
                {
                    break;
                }

                var valorPago = Convert.ToDecimal(lista.Rows[contadorProduto]["custo"]);
                var valorVenda = Convert.ToDecimal(lista.Rows[contadorProduto]["Venda"]);
                var referencia = lista.Rows[contadorProduto]["Referencia"].ToString();
                var und = lista.Rows[contadorProduto]["Und"].ToString();
                var categoria = lista.Rows[contadorProduto]["Categoria"].ToString();
                var subCategoria = lista.Rows[contadorProduto]["SubCategoria"].ToString();
                var localizacao = lista.Rows[contadorProduto]["Localização"].ToString();

                y += 20;

                posicao.Y = y;                

                posicao.X = 10;
                e.Graphics.DrawString((lista.Rows[contadorProduto]["nome"]).ToString(), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 200;
                e.Graphics.DrawString(valorPago.ToString("N2"), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 250;
                e.Graphics.DrawString(valorVenda.ToString("N2"), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 300;
                e.Graphics.DrawString(lista.Rows[contadorProduto]["Quantidade"].ToString(), fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 350;
                e.Graphics.DrawString(referencia, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 400;
                e.Graphics.DrawString(und, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 500;
                e.Graphics.DrawString(categoria, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 600;
                e.Graphics.DrawString(subCategoria, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 700;
                e.Graphics.DrawString(localizacao, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);

                contadorProduto++;

                if (y >= alturaPagina - 50)
                {
                    e.HasMorePages = true;
                    y = 40;
                    return;
                }
            }

            #endregion

        }



    }
}
