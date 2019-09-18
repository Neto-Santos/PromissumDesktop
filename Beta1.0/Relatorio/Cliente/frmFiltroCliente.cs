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

namespace Beta1._0.Relatorio.Cliente
{
    public partial class frmFiltroCliente : Form
    {
        public frmFiltroCliente(DalConexao conexao)
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

        //int alturaPagina = 0;

        string status = "";
        //Variável muito importante no momento de quebra de páginas.
        //int i = 0;
        private void frmFiltroCliente_Load(object sender, EventArgs e)
        {
            rbSintetico.Checked = true;
            dtInicio.Value.AddYears(-1);
            dtInicio.Text = dtInicio.Value.AddYears(-1).ToShortDateString();

            Ferramentas.impressao objferra = new Ferramentas.impressao();
            objferra.CarregarListaDeImpressoras(cbImpressora);
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            //frmRelatorioCliente frm = new frmRelatorioCliente(conexao);
            //frm.dataInicial = dtInicio.Value.ToShortDateString();
            //frm.dataFinal = dtFim.Value.ToShortDateString();
            //frm.nome = txtNome.Text;
            //frm.cidade = txtCidade.Text;
            //frm.estado = txtEstado.Text;
            //frm.defeito = txtDefeito.Text;
            //frm.referencia = txtRef.Text;
            //frm.servico = txtServiço.Text;
            //if (rbAnalitico.Checked)
            //{
            //    frm.tipoRelatorio = "Analitico";
            //}
            //else
            //{
            //    frm.tipoRelatorio = "Sintetico";
            //}


            if (rbAberto.Checked)
            {
                status = "Aberto";
            }
            if (rbFinalizado.Checked)
            {
                status = "Finalizado";
            }
            if (rbCancelado.Checked)
            {
                status = "Cancelado";
            }
            if (rbTodos.Checked)
            {
                status = "";
            }

            preVisualizacao.Document = documento;
            ((Form)preVisualizacao).WindowState = FormWindowState.Maximized;
            preVisualizacao.PrintPreviewControl.Zoom = 150 / 100;           
            preVisualizacao.ShowDialog();
            this.Close();
            //frm.ShowDialog();

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

            string Titulo = "Cliente(s)";
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


            var bllCliente = new BLL.BllCliente(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            var lista = bllCliente.LocalizarRelatorioAnalitico(txtNome.Text, dtInicio.Value.ToShortDateString(), dtFim.Value.ToShortDateString(), txtCidade.Text, txtEstado.Text, status, txtDefeito.Text, txtServiço.Text, txtRef.Text);

            //Definindo a altu010inicial da listagem dos produtos.
            y += 40;

            int ultimoCodigoCliente = 0;
            int ultimoCodigoOrcamento = 0;

            decimal totalAberto = 0;
            decimal totalFinalizado = 0;           

            for (int i = 0; i < lista.Rows.Count; i++)
            {
                var Cliente = lista.Rows[i]["Cliente"].ToString();
                var CpfCnpj = lista.Rows[i]["CpfCnpj"].ToString();
                var RgIe = lista.Rows[i]["RgIe"].ToString();
                var RSocial = lista.Rows[i]["RSocial"].ToString();
                var Email = lista.Rows[i]["Email"].ToString();
                var Codigo = Convert.ToInt32(lista.Rows[i]["Codigo"]);
                var Orçamento = Convert.ToInt32(lista.Rows[i]["Orçamento"]);
                var Total = lista.Rows[i]["Total"].ToString();
                var Status = lista.Rows[i]["Status"].ToString();
                var Entrada = lista.Rows[i]["Entrada"].ToString();
                Entrada = Entrada.Remove(Entrada.Length - 9);
                var Saída = lista.Rows[i]["Saída"].ToString();
                if (Saída.Length >= 9)
                {
                    Saída = Saída.Remove(Saída.Length - 9);
                }
               
                var Início = lista.Rows[i]["Início"].ToString();
                if (Início.Length >= 9)
                {
                    Início = Início.Remove(10);
                }
                var Término = lista.Rows[i]["Término"].ToString();
                if (Término.Length >= 9)
                {
                    Término = Término.Remove(10);
                }
                var Defeito = lista.Rows[i]["Defeito"].ToString();
                var Serviço = lista.Rows[i]["Serviço"].ToString();
                var Referencia = lista.Rows[i]["Referencia"].ToString();

              
                //if (contadorProduto == lista.Rows.Count)
                //{
                //    break;
                //}

                y += 20;
                posicao.Y += 20;

                if (ultimoCodigoCliente == 0 && ultimoCodigoOrcamento == 0)
                {
                    y += 20;
                    posicao.Y += 20;
                    posicao.X = 10;
                    e.Graphics.DrawString(Cliente, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 200;
                    e.Graphics.DrawString(CpfCnpj, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    //posicao.X = 250;
                    //e.Graphics.DrawString(RgIe, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 300;
                    e.Graphics.DrawString(RSocial, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 350;
                    e.Graphics.DrawString(Email, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 400;
                    posicao.X = 10;
                    e.Graphics.DrawString(Cliente, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 200;
                    e.Graphics.DrawString(CpfCnpj, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 400;

                    y += 20;
                    posicao.Y += 20;
                    //posicao.X = 20;
                    //e.Graphics.DrawString("============================ Movimentação ============================ ", fonteLucida8Rege, corpreta, posicao, alinhamentocentro);
                    posicao.X = 10;
                    e.Graphics.DrawString("Orçamento: " + Orçamento.ToString(), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 80;
                    e.Graphics.DrawString("Total: " + Total.ToString(), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 180;
                    e.Graphics.DrawString("Status: " + Status, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 280;
                    e.Graphics.DrawString("Entrada:" + Entrada, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 380;
                    e.Graphics.DrawString("Saída:" + Saída, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    //posicao.X = 400;
                    //e.Graphics.DrawString(Início, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    //posicao.X = 450;
                    //e.Graphics.DrawString(Término, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    y += 20;
                    posicao.Y += 20;
                    posicao.X = 10;
                    e.Graphics.DrawString("Defeito: " + Defeito, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);

                    posicao.X = 300;
                    e.Graphics.DrawString("Serviço:" + Serviço, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    //posicao.X = 600;
                    //e.Graphics.DrawString(Referencia, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    if (Status == "Aberto")
                    {
                        totalAberto += Convert.ToDecimal(Total);
                    }
                    if (Status == "Finalizado")
                    {
                        totalFinalizado += Convert.ToDecimal(Total);
                    }
                }
                else if (ultimoCodigoCliente == Codigo && ultimoCodigoOrcamento != Orçamento)
                {
                    y += 20;
                    posicao.Y += 20;
                    //posicao.X = 20;
                    //e.Graphics.DrawString("============================ Movimentação ============================ ", fonteLucida8Rege, corpreta, posicao, alinhamentocentro);
                    posicao.X = 10;
                    e.Graphics.DrawString("Orçamento: " + Orçamento.ToString(), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 80;
                    e.Graphics.DrawString("Total: " + Total.ToString(), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 180;
                    e.Graphics.DrawString("Status: " + Status, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 280;
                    e.Graphics.DrawString("Entrada:" + Entrada, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 380;
                    e.Graphics.DrawString("Saída:" + Saída, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    //posicao.X = 400;
                    //e.Graphics.DrawString(Início, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    //posicao.X = 450;
                    //e.Graphics.DrawString(Término, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    y += 20;
                    posicao.Y += 20;
                    posicao.X = 10;
                    e.Graphics.DrawString("Defeito: " + Defeito, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    
                    posicao.X = 300;
                    e.Graphics.DrawString("Serviço:" + Serviço, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    //posicao.X = 600;
                    //e.Graphics.DrawString(Referencia, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);

                    if (Status == "Aberto")
                    {
                        totalAberto += Convert.ToDecimal(Total);
                    }
                    if (Status == "Finalizado")
                    {
                        totalFinalizado += Convert.ToDecimal(Total);
                    }
                }
                else if (ultimoCodigoCliente != Codigo &&  ultimoCodigoOrcamento != Orçamento)
                {
                    y += 20;
                    posicao.Y += 20;
                    posicao.X = 10;
                    e.Graphics.DrawString(Cliente, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 200;
                    e.Graphics.DrawString(CpfCnpj, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    //posicao.X = 250;
                    //e.Graphics.DrawString(RgIe, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 300;
                    e.Graphics.DrawString(RSocial, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 350;
                    e.Graphics.DrawString(Email, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 400;
                    posicao.X = 10;
                    e.Graphics.DrawString(Cliente, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 200;
                    e.Graphics.DrawString(CpfCnpj, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 400;
                    y += 20;
                    posicao.Y += 20;
                    //posicao.X = 20;
                    //e.Graphics.DrawString("============================ Movimentação ============================ ", fonteLucida8Rege, corpreta, posicao, alinhamentocentro);
                    posicao.X = 10;
                    e.Graphics.DrawString("Orçamento: " + Orçamento.ToString(), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 80;
                    e.Graphics.DrawString("Total: " + Total.ToString(), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 180;
                    e.Graphics.DrawString("Status: " + Status, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 280;
                    e.Graphics.DrawString("Entrada:" + Entrada, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    posicao.X = 380;
                    e.Graphics.DrawString("Saída:" + Saída, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    //posicao.X = 400;
                    //e.Graphics.DrawString(Início, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    //posicao.X = 450;
                    //e.Graphics.DrawString(Término, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    y += 20;
                    posicao.Y += 20;
                    posicao.X = 10;
                    e.Graphics.DrawString("Defeito: " + Defeito, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);

                    posicao.X = 300;
                    e.Graphics.DrawString("Serviço:" + Serviço, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    //posicao.X = 600;
                    //e.Graphics.DrawString(Referencia, fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
                    if (Status == "Aberto")
                    {
                        totalAberto += Convert.ToDecimal(Total);
                    }
                    if (Status == "Finalizado")
                    {
                        totalFinalizado += Convert.ToDecimal(Total);
                    }

                }

                contadorProduto++;

                ultimoCodigoCliente = Codigo;
                ultimoCodigoOrcamento = Orçamento ;
                if (y >= alturaPagina - 50)
                {
                    ultimoCodigoCliente = Codigo;
                    e.HasMorePages = true;
                    y = 40;
                    return;
                }


            }
            y += 20;
            posicao.Y += 20;
            posicao.X = 20;
            e.Graphics.DrawString("Quantidade de Itens: " + contadorProduto.ToString(), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            y += 20;
            posicao.Y += 20;
            e.Graphics.DrawString("Total Aberto: " + totalAberto.ToString("N2"), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            y += 20;
            posicao.Y += 20;
            e.Graphics.DrawString("Total Finalizado: " + totalFinalizado.ToString("N2"), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            y += 20;
            posicao.Y += 20;
            e.Graphics.DrawString("Total: " + (totalFinalizado+totalAberto).ToString("N2"), fonteLucida8Rege, corpreta, posicao, alinhamentoesquerda);
            documento.DefaultPageSettings.Landscape = false;
            #endregion

        }
        

        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            imprimiA4Sintetico(e);
        }
    }
}
