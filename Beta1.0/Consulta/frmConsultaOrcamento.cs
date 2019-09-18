using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Beta1._0.Cadastro;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using Beta1._0.Os;
using Beta1._0.Relatorio.Os.ItensVenda;
using System.Threading;

namespace Beta1._0.Consulta
{
    public partial class frmConsultaOrcamento : Form
    {
        public frmConsultaOrcamento()
        {
            InitializeComponent();
            conexao = new DalConexao(DadosConexao.stringConexao);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private string codigoOrcamento { get; set; }
        DalConexao conexao;
        //Variável será utilizada no momento em que for imprimir uma venda ou orçamento.
        public int codVenda;

        //Variável será utilizada no momento em que for imprimir uma listagem dos produtos.
        public int codProduto { get; set; }
        public int contadorProduto = 0;


        private int paginaAtual = 1;
        private string relatorioTitulo= "Ordem de Serviço";

        void abrirFormularioCadastroOrcamento(string codigo = null)
        {
            frmCadastroOrcamento frmCadastroOrcamento = new frmCadastroOrcamento(codigo);
            if ((Application.OpenForms["frmCadastroOrcamento"] as frmCadastroOrcamento) != null)
            {
                frmCadastroOrcamento.BringToFront();
                frmCadastroOrcamento.Focus();
            }
            else
            {
                frmCadastroOrcamento.MdiParent = this.MdiParent;
                frmCadastroOrcamento.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormularioCadastroOrcamento();
        }
        void carregaDataGrid()
        {
            BllVenda bllVenda = new BllVenda(conexao);
            dgOrcamento.DataSource = null;
            dgOrcamento.DataSource = bllVenda.LocalizarVendaAberta("");
        }
        private void frmConsultaOrcamento_Load(object sender, EventArgs e)
        {
            carregaDataGrid();

            Ferramentas.impressao objferra = new Ferramentas.impressao();
            objferra.CarregarListaDeImpressoras(cbImpressora);
            //CarregarListaDeImpressoras();
        }

        private void dgOrcamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.codigoOrcamento = dgOrcamento.Rows[e.RowIndex].Cells[0].Value.ToString();
                BllItensVenda bllItensVenda = new BllItensVenda(conexao);
                dgvItens.DataSource = bllItensVenda.LocalizarColunasRenomeadas(Convert.ToInt32(codigoOrcamento));
            }
            catch (Exception)
            {
            }

        }

        private void dgOrcamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dgOrcamento.Rows[e.RowIndex].Cells[0].Value) > 0)
            {
                codigoOrcamento = dgOrcamento.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

            if (codigoOrcamento != null)
            {
                var bllVenda = new BllVenda(conexao);
                var modelo = bllVenda.CarregaModeloVenda(Convert.ToInt32(codigoOrcamento));
                if (modelo.VenStatus == "Cancelado")
                {
                    MessageBox.Show("Orçamento Cancelado");
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codigoOrcamento != null)
            {
                DalConexao cx = new DalConexao(DadosConexao.stringConexao);

                BllVenda bllVenda = new BllVenda(cx);

                cx.Conectar();
                cx.IniciarTransacao();

                var modeloVenda = bllVenda.CarregaModeloVenda(Convert.ToInt32(codigoOrcamento), true);

                cx.CancelarTransacao();
                cx.Desconectar();

                if (modeloVenda.VenStatus == "Cancelado")
                {
                    MessageBox.Show("Pedido Cancelado");
                }
                else
                {
                    abrirFormularioCadastroOrcamento(this.codigoOrcamento);
                }

            }
        }

        //Excluir OS=============================================
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja cancelar o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    //Implementando o botão cancelar venda
                    int codigoVenda = Convert.ToInt32(codigoOrcamento);

                    DalConexao cx = new DalConexao(DadosConexao.stringConexao);
                    cx.Conectar();
                    cx.IniciarTransacao();


                    BllVenda bllVenda = new BllVenda(cx);
                    var modeloVenda = bllVenda.CarregaModeloVenda(codigoVenda, true);

                    //Se a venda não estiver cancelada.
                    if (modeloVenda.VenStatus != "Cancelado")
                    {
                        //Calculando a quantidade de parcelas já pagas

                        //Se quantidade for maior que zero significar que já foi pago alguma ou todas as parcelas
                        //Sendo assim não será possível excluir a compra.

                        //cx.Conectar();
                        //cx.IniciarTransacao();
                        try
                        {
                            //Excluindo todas as parcelas de uma compra
                            //Aqui estou incrementando a quantidade dos produtos, já que a venda foi cancelada.

                            //Excluindo todos os Itens de uma compra
                            //BllItensVenda bllItensVenda = new BllItensVenda(cx);

                            //Aqui é chamado uma trigger DecrementaEstoqueCompra
                            //bllItensVenda.ExcluirTodosItensVenda(Convert.ToInt32(codigoOrcamento));

                            //Excluindo a Compra                  

                            bllVenda.CancelarVenda(Convert.ToInt32(codigoOrcamento));

                            dgOrcamento.DataSource = null;

                            cx.TerminarTransacao();
                            cx.Desconectar();

                            carregaDataGrid();

                        }
                        catch (Exception)
                        {
                            cx.CancelarTransacao();
                            cx.Desconectar();
                            throw;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Venda já está cancelada");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (rbAberto.Checked)
            {
                BllVenda bllVenda = new BllVenda(conexao);
                dgOrcamento.DataSource = bllVenda.LocalizarVendaAberta(txtNome.Text);
            }
            if (rbFinalizado.Checked)
            {
                BllVenda bllVenda = new BllVenda(conexao);
                dgOrcamento.DataSource = bllVenda.LocalizarVendaFinalizada(txtNome.Text);
            }
            if (rbCancelado.Checked)
            {
                BllVenda bllVenda = new BllVenda(conexao);
                dgOrcamento.DataSource = bllVenda.LocalizarVendaCancelado(txtNome.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //frmRelatorioItensVenda frmRelatorio = new frmRelatorioItensVenda(conexao);
            //frmRelatorio.codVenda = Convert.ToInt32(codigoOrcamento);
            //frmRelatorio.ShowDialog();

            //preVisualizacao.Document = documento;
            //((Form)preVisualizacao).WindowState = FormWindowState.Maximized;
            //preVisualizacao.PrintPreviewControl.Zoom =1;
            //preVisualizacao.ShowDialog();

            Relatorio_Atualizado.Orcamento.frmRelatorioOrçamento frm = new Relatorio_Atualizado.Orcamento.frmRelatorioOrçamento(Convert.ToInt32(this.codigoOrcamento), conexao);
            frm.ShowDialog();

        }

        
        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var linhasPorPagina = 0;
            var posicaoDaLinha = 0;
            var linhaAtual = 0;


            //========= Variáveis de alinhamento==========
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


            var margemEsquerda = e.MarginBounds.Left;
            var margemSuperior = e.MarginBounds.Top + 100;
            var margemDireita = e.MarginBounds.Right;
            var margemInferior = e.MarginBounds.Bottom;
           
           
            
            
            //=============== Fontes ====================
            var fonteArial16Regu = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            var fonteLucida10Rege = new Font("Lucida Sans Unicode", 10, FontStyle.Regular, GraphicsUnit.Pixel);
            var fonteLucida12Bold = new Font("Lucida Sans Unicode", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            var corpreta = new SolidBrush(Color.Black);
            //================Definindo a caneta =========================
            var caneta = new Pen(Color.Black, 1);            
            
            e.Graphics.DrawLine(caneta,margemEsquerda,60,margemDireita,60);
            e.Graphics.DrawLine(caneta, margemEsquerda, 90, margemDireita, 90);

            BllEmpresa bllEmpresa = new BllEmpresa(conexao);
            var listaEmpresa = bllEmpresa.LocalizarPorCodigo(1.ToString());
            
            //============Imprimi o nome da empresa====================
            e.Graphics.DrawString(listaEmpresa.Rows[0]["nome"].ToString(), fonteLucida10Rege, corpreta, margemEsquerda+250,60, new StringFormat());

            //===========Imprimi o logo da Empresa=====================
            Image logo = Image.FromFile(@Ferramentas.xmlConfig.config.retornaLogo());
            Rectangle recImage = new Rectangle(5, 0, 120, 100);

            e.Graphics.DrawImage(logo,recImage);

            //=========Imprimi o Título do relatório===================
            e.Graphics.DrawString(relatorioTitulo + " "+DateTime.Now.ToShortDateString(),fonteLucida10Rege,Brushes.Black,margemEsquerda +250,120, new StringFormat());


            //======Imprimi informações do Cliente===================
            BllVenda bllVenda = new BllVenda(conexao);

            var modeloVenda = bllVenda.CarregaModeloVenda(Convert.ToInt32(codigoOrcamento));

            BllCliente bllCliente = new BllCliente(conexao);

            BllItensVenda bllItensVenda = new BllItensVenda(conexao);

            var listaVenda = bllVenda.Localizar(modeloVenda.VenCod.ToString());

            var listaCliente = bllCliente.LocalizarPorCodigo(modeloVenda.CliCod.ToString());

            var listaItensVenda = bllItensVenda.Localizar(modeloVenda.VenCod);

            var bllProduto = new BLL.BLLProduto(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            
            e.Graphics.DrawString("Cliente: " + listaCliente.Rows[0]["cli_nome"].ToString(), fonteLucida10Rege, corpreta, margemEsquerda, 140);
            
            e.Graphics.DrawString("Cnpj: " + listaCliente.Rows[0]["cli_cpfcnpj"].ToString(), fonteLucida10Rege, corpreta, margemEsquerda, 160);

            e.Graphics.DrawString("Email: " + listaCliente.Rows[0]["cli_email"].ToString(), fonteLucida10Rege, corpreta, margemEsquerda, 180);

            e.Graphics.DrawString("Cidade: " + listaCliente.Rows[0]["cli_cidade"].ToString(), fonteLucida10Rege, corpreta, margemEsquerda, 200);

            e.Graphics.DrawString("Estado: " + listaCliente.Rows[0]["cli_estado"].ToString(), fonteLucida10Rege, corpreta, margemEsquerda, 220);


            //========== Imprimi Listagem dos Itens/Serviços Prestados==================
            e.Graphics.DrawString("Listagems Itens/Serviços Prestados", fonteLucida12Bold, corpreta, margemEsquerda+210, 280);

           
            e.Graphics.DrawString("Tipo/Equipamento", fonteLucida10Rege, corpreta, margemEsquerda-80, 300);

            e.Graphics.DrawString("QTD", fonteLucida10Rege, corpreta, margemEsquerda +100, 300);

            e.Graphics.DrawString("Vlr Base", fonteLucida10Rege, corpreta, margemEsquerda + 140, 300);

            e.Graphics.DrawString("Desc", fonteLucida10Rege, corpreta, margemEsquerda + 200, 300);

            e.Graphics.DrawString("Vlr", fonteLucida10Rege, corpreta, margemEsquerda + 250, 300);

            e.Graphics.DrawString("SubTotal", fonteLucida10Rege, corpreta, margemEsquerda + 300, 300);

            e.Graphics.DrawString("Serviço", fonteLucida10Rege, corpreta, margemEsquerda + 400, 300);

            e.Graphics.DrawString("Nº Série", fonteLucida10Rege, corpreta, margemEsquerda + 600, 300);

            // Define as linhas por páginas
            linhasPorPagina = Convert.ToInt32(e.MarginBounds.Height / fonteLucida10Rege.GetHeight(e.Graphics)-9);

            var contador = 0;
            posicaoDaLinha = 310;
            while (linhaAtual < linhasPorPagina && contador < listaItensVenda.Rows.Count )
            {     
                 
                    var quantidade = Convert.ToDecimal(listaItensVenda.Rows[contador]["itv_qtde"]);

                    var valor = Convert.ToDecimal(listaItensVenda.Rows[contador]["itv_valor"]);

                    var valorBase = Convert.ToDecimal(listaItensVenda.Rows[contador]["itv_valorBase"]);
                    var desconto = Convert.ToDecimal(listaItensVenda.Rows[contador]["itv_desconto"]);
                    var produto = listaItensVenda.Rows[contador]["pro_nome"].ToString();
                    var referencia = listaItensVenda.Rows[contador]["referencia"].ToString();
                    var operacao = listaItensVenda.Rows[contador]["op_nome"].ToString();



                    e.Graphics.DrawString(produto, fonteLucida10Rege, corpreta, margemEsquerda - 80, posicaoDaLinha);

                    e.Graphics.DrawString(quantidade.ToString(), fonteLucida10Rege, corpreta, margemEsquerda + 100, posicaoDaLinha);

                    e.Graphics.DrawString("R$" + valorBase.ToString("N2"), fonteLucida10Rege, corpreta, margemEsquerda + 140, posicaoDaLinha);

                    e.Graphics.DrawString("R$" + desconto.ToString("N2"), fonteLucida10Rege, corpreta, margemEsquerda + 200, posicaoDaLinha);

                    e.Graphics.DrawString("R$" + valor.ToString("N2"), fonteLucida10Rege, corpreta, margemEsquerda + 250, posicaoDaLinha);

                    e.Graphics.DrawString("R$" + (valor * quantidade).ToString("N2"), fonteLucida10Rege, corpreta, margemEsquerda + 300, posicaoDaLinha);

                    e.Graphics.DrawString(operacao, fonteLucida10Rege, corpreta, margemEsquerda + 400, posicaoDaLinha);

                    e.Graphics.DrawString(referencia, fonteLucida10Rege, corpreta, margemEsquerda + 600, posicaoDaLinha);

                    //posicao.X = 600;
                    //e.Graphics.DrawString(subCategoria, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
                    //posicao.X = 700;
                    //e.Graphics.DrawString(localizacao, fonteLucida10Rege, corpreta, posicao, alinhamentoesquerda);
                    posicaoDaLinha += 10;
                    contador++;
                    linhaAtual++;
               
            }

            // Imprimi o rodapé
            e.Graphics.DrawLine(caneta, margemEsquerda, margemInferior, margemDireita, margemInferior);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fonteLucida10Rege, Brushes.Black, margemEsquerda, margemInferior);

            linhaAtual += Convert.ToInt32(fonteLucida10Rege.GetHeight(e.Graphics));
            linhaAtual++;

            e.Graphics.DrawString("Página: " + paginaAtual, fonteLucida10Rege, Brushes.Black, margemDireita - 50, margemInferior);
                        
            paginaAtual++;

            if (linhaAtual > linhasPorPagina)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            Relatorio_Atualizado.Orcamento.frmRelatorioOrçamento frm = new Relatorio_Atualizado.Orcamento.frmRelatorioOrçamento(Convert.ToInt32(this.codigoOrcamento), conexao,"Sintetico","PDF");
            frm.ShowDialog();
        }
    }
}
