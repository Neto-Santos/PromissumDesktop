using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace Beta1._0.Relatorio.Fornecedor
{
    public partial class frmFiltroFornecedor : Form
    {
        public frmFiltroFornecedor()
        {
            InitializeComponent();
           
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
        private void frmFiltroFornecedor_Load(object sender, EventArgs e)
        {
            //Ferramentas.impressao objferra = new Ferramentas.impressao();
            //objferra.CarregarListaDeImpressoras(cbImpressora);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relatorio_Atualizado.Fornecedor.frmRelatorio frm = new Relatorio_Atualizado.Fornecedor.frmRelatorio(txtNome.Text, "", txtCnpj.Text, txtCidade.Text, txtEstado.Text, dtInicio.Value.ToShortDateString(), dtFim.Value.ToShortDateString(),"");
            frm.ShowDialog();

        }
        public void imprimiA4Sintetico(System.Drawing.Printing.PrintPageEventArgs e)
        {
            //documento.PrinterSettings.PrinterName = cbImpressora.SelectedItem.ToString();
            int alturaPagina = 0;
            int y = 50;
            documento.DefaultPageSettings.Landscape = false;

            Rectangle posicao = new Rectangle(0, 50, (documento.DefaultPageSettings.Bounds.Width), 30);

            posicao.Y = y;
            alturaPagina = posicao.Height;
            int larguraPagina = posicao.Width;

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
            e.Graphics.DrawString("NG SYSTEM - SOLUÇÕES EM SISTEMAS  CONTATO = 75 9 8107 1164  EMAIL: NGSYSTEM@GMAIL.COM", fonteLucida8Rege, new SolidBrush(Color.Red), 2, 2);
            e.Graphics.DrawRectangle(new Pen(Color.Red), new Rectangle(2, 1, alturaPagina, 1));
            #endregion

            #region Título do Relatório           

            string Titulo = "Fornecedor(es)";
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


            var bllProduto = new BLL.BLLFornecedor(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            var lista = bllProduto.RelatorioFornecedor(txtNome.Text, txtCidade.Text, txtEstado.Text, txtCpf.Text, txtCnpj.Text, dtInicio.Value.ToShortDateString(), dtFim.Value.ToShortDateString());

            //"SELECT  fornecedor.for_cod as Codigo, fornecedor.for_nome AS Fornecedor, fornecedor.for_rsocial AS RSocial, fornecedor.for_ie AS IE, fornecedor.for_cnpj AS Cnpj, " +
            //          "  fornecedor.for_cep AS Cep, fornecedor.for_endereco AS Endereço, fornecedor.for_bairro AS Bairro, fornecedor.for_fone AS Telefone, fornecedor.for_cel AS Celular, " +
            //         "   fornecedor.for_email AS Email, fornecedor.for_endnumero AS Nº, fornecedor.for_cidade AS Cidade, fornecedor.for_estado AS UF, fornecedor.for_cadastro AS Cadastro, " +
            //          "  fornecedor.for_cpf AS CPF, fornecedor.for_observacao AS Observação " +
            //            " FROM  fornecedor " +
            //            "WHERE     for_nome like '%{0}%' and for_cidade  like '%{1}%' and for_estado  like '%{2}%' and for_cpf  like '%{3}%' and for_cnpj  like '%{4}%' and for_cadastro  between '{5}' " +
            //             " and '{6}' ", fornecedor, cidade, estado, cpf, cnpj, cadastroInicio, cadastroTermino);

            //Definindo a altura inicial da listagem dos produtos.
            y += 40;

            posicao.X = 10;
            posicao.Y = y;
            e.Graphics.DrawString("Fornecedor", fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 200;
            e.Graphics.DrawString("RSocial", fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 250;
            e.Graphics.DrawString("IE", fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 300;
            e.Graphics.DrawString("Cnpj", fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 350;
            e.Graphics.DrawString("Cep", fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 400;
            e.Graphics.DrawString("Endereço", fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 500;
            e.Graphics.DrawString("Bairro", fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 600;
            e.Graphics.DrawString("Telefone", fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            posicao.X = 700;
            e.Graphics.DrawString("Email", fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);


            while (contadorProduto <= lista.Rows.Count)
            {
                if (contadorProduto == lista.Rows.Count)
                {
                    break;
                }

                var Fornecedor = lista.Rows[contadorProduto]["Fornecedor"].ToString();
                var RSocial = lista.Rows[contadorProduto]["RSocial"].ToString();
                var IE = lista.Rows[contadorProduto]["IE"].ToString();
                var Cnpj = lista.Rows[contadorProduto]["Cnpj"].ToString();
                var Cep = lista.Rows[contadorProduto]["Cep"].ToString();
                var Endereco = lista.Rows[contadorProduto]["Endereço"].ToString();
                var Bairro = lista.Rows[contadorProduto]["Bairro"].ToString();
                var Telefone = lista.Rows[contadorProduto]["Telefone"].ToString();
                var Email = lista.Rows[contadorProduto]["Email"].ToString();

                y += 20;

                posicao.Y = y;

                posicao.X = 10;
                e.Graphics.DrawString(Fornecedor, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 200;
                e.Graphics.DrawString(RSocial, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 250;
                e.Graphics.DrawString(IE, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 300;
                e.Graphics.DrawString(Cnpj, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 350;
                e.Graphics.DrawString(Cep, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 400;
                e.Graphics.DrawString(Endereco, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 500;
                e.Graphics.DrawString(Bairro, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 600;
                e.Graphics.DrawString(Telefone, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                posicao.X = 700;
                e.Graphics.DrawString(Email, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);

                contadorProduto++;


                if (y >= alturaPagina - 50)
                {
                    e.HasMorePages = true;
                    y = 40;
                    return;
                }


            }
            posicao.Y = y + 20;
            posicao.X = 20;
            e.Graphics.DrawString("Quantidade de Itens: " + contadorProduto.ToString(), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);

            documento.DefaultPageSettings.Landscape = true;
            #endregion

        }
        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            imprimiA4Sintetico(e);

        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            this.formato = "pdf";
            Relatorio_Atualizado.Fornecedor.frmRelatorio frm = new Relatorio_Atualizado.Fornecedor.frmRelatorio(txtNome.Text, "", txtCnpj.Text, txtCidade.Text, txtEstado.Text, dtInicio.Value.ToShortDateString(), dtFim.Value.ToShortDateString(),formato);
            frm.ShowDialog();
        }
    }
}
