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

namespace Beta1._0.Relatorio.Categoria
{
    public partial class frmFiltroCategoria : Form
    {
        public frmFiltroCategoria(DalConexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        DalConexao conexao;
        public int codVenda;
        public string formato { get; set; }
        //Variável será utilizada no momento em que for imprimir uma listagem dos produtos.
        public int codProduto { get; set; }
        public int contadorProduto = 0;

        //int alturaPagina = 0;

        string status = "";
        //Variável muito importante no momento de quebra de páginas.
        //int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            //frmRelatorioCategoria frm = new frmRelatorioCategoria(conexao);
            //frm.categoria = txtCategoria.Text;
            //frm.produto = txtProduto.Text;
            //frm.dtInicio = dtInicio.Value.ToShortDateString();
            //frm.dtFim = dtFim.Value.ToShortDateString();
            //frm.subCategoria = txtSubCategoria.Text;
            //if (rbAnalitico.Checked)
            //{
            //    frm.tipoRelatorio = "Analitico";
            //}
            //else
            //{
            //    frm.tipoRelatorio = "Sintetico";
            //}
            //frm.ShowDialog();

            //preVisualizacao.Document = documento;
            //((Form)preVisualizacao).WindowState = FormWindowState.Maximized;
            //preVisualizacao.PrintPreviewControl.Zoom = 150 / 100;
            //preVisualizacao.ShowDialog();
            //this.Close();

            Relatorio_Atualizado.Categoria.frmRelatorioCategoria frm = new Relatorio_Atualizado.Categoria.frmRelatorioCategoria();
            frm.MaximizeBox = true;
            frm.ShowDialog();


        }    
        public void imprimiA4Sintetico(System.Drawing.Printing.PrintPageEventArgs e)
        {
            documento.PrinterSettings.PrinterName = cbImpressora.SelectedItem.ToString();
            int alturaPagina = 0;
            int y = 50;
            
            documento.DefaultPageSettings.Landscape = false;

            Rectangle posicao = new Rectangle(0, 50, (documento.DefaultPageSettings.Bounds.Width), 30);

            posicao.Y = 50;
            alturaPagina = documento.DefaultPageSettings.Bounds.Height;
            int larguraPagina = documento.DefaultPageSettings.Bounds.Width;

            StringBuilder sb = new StringBuilder();

            var fonteArial16Regu = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            var fonteLucida8Rege = new Font("Lucida Sans Unicode", 8, FontStyle.Regular, GraphicsUnit.Pixel);
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
            e.Graphics.DrawString("Promissum System", fonteLucida8Rege, new SolidBrush(Color.Red), 2, 2);
            e.Graphics.DrawRectangle(new Pen(Color.Red), new Rectangle(2, 1, alturaPagina, 1));
            #endregion

            #region Título do Relatório           

            string Titulo = "Categoria(s)";
            Rectangle linha = new Rectangle(0, 100, larguraPagina, 1);
            y += 20;
            posicao.Y = y;
            posicao.X = 0;
            posicao.Width = larguraPagina;
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), linha);
            e.Graphics.DrawString(Titulo, fonteArial16Regu, corpreta, posicao, alinhamentocentro);
            var tamanholinha = e.Graphics.MeasureString(Titulo, fonteArial16Regu);

            #endregion

            #region Listagem dos Itens


            var bllCategoria = new BLL.BLLCategoria(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            var lista = bllCategoria.RelatorioCategoria(txtCategoria.Text,dtInicio.Value.ToShortDateString(),dtFim.Value.ToShortDateString(),txtProduto.Text,txtSubCategoria.Text);

            //Definindo a altu010inicial da listagem dos produtos.
            y += 40;

            int ultimoCodigoCategoria = 0;
            

            for (int i = 0; i < lista.Rows.Count; i++)
            {
                var Codigo = Convert.ToInt32(lista.Rows[i]["Codigo"].ToString());
                var Categoria = lista.Rows[i]["Categoria"].ToString();
                var Produto = lista.Rows[i]["Produto"].ToString();
                var SubCategoria = lista.Rows[i]["SubCategoria"].ToString();
                var Custo = lista.Rows[i]["Custo"].ToString();
                var Venda = Convert.ToInt32(lista.Rows[i]["Venda"]);         
            

                y += 20;
                posicao.Y += 20;

                if (ultimoCodigoCategoria == 0 )
                {
                    posicao.Y += 20;
                    posicao.X = 10;
                    e.Graphics.DrawString(Codigo.ToString(), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 200;
                    e.Graphics.DrawString(Categoria, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);

                    ultimoCodigoCategoria = Codigo;
                   
                }
                else if (Convert.ToInt32(ultimoCodigoCategoria) != Codigo)
                {
                    posicao.Y += 20;
                    posicao.X = 10;
                    e.Graphics.DrawString(Codigo.ToString(), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 200;
                    e.Graphics.DrawString(Categoria, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);

                    ultimoCodigoCategoria = Codigo;
                }             
                                
                if (y >= alturaPagina - 50)
                {                  
                    e.HasMorePages = true;
                    y = 40;
                    return;
                }


            }

            //posicao.Y += 20;
            //posicao.X = 20;
            //e.Graphics.DrawString("Quantidade de Itens: " + contadorProduto.ToString(), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            //posicao.Y += 20;
            //e.Graphics.DrawString("Total Aberto: " + totalAberto.ToString("N2"), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            //posicao.Y += 20;
            //e.Graphics.DrawString("Total Finalizado: " + totalFinalizado.ToString("N2"), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            //posicao.Y += 20;
            //e.Graphics.DrawString("Total: " + (totalFinalizado + totalAberto).ToString("N2"), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            documento.DefaultPageSettings.Landscape = false;
            #endregion

        }
        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            imprimiA4Sintetico(e);
        }

        private void frmFiltroCategoria_Load(object sender, EventArgs e)
        {
            //Ferramentas.impressao objferra = new Ferramentas.impressao();
            //objferra.CarregarListaDeImpressoras(cbImpressora);
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            this.formato = "pdf";
            Relatorio_Atualizado.Categoria.frmRelatorioCategoria frm = new Relatorio_Atualizado.Categoria.frmRelatorioCategoria();
            frm.MaximizeBox = true;
            frm.ShowDialog();
        }
    }
}
