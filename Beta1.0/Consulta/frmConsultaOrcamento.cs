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
using DAL.EntityFramework;
using BLL;
using Beta1._0.Os;
using Beta1._0.Relatorio.Os.ItensVenda;
using System.Threading;
using System.Runtime.InteropServices;

namespace Beta1._0.Consulta
{
    public partial class frmConsultaOrcamento : Form
    {
        public frmConsultaOrcamento()
        {
            InitializeComponent();
        }
        promissumServicoEntities contexto = new promissumServicoEntities();

        private int codigoOrcamento { get; set; }
        //Variável será utilizada no momento em que for imprimir uma venda ou orçamento.
        public int codVenda;

        //Variável será utilizada no momento em que for imprimir uma listagem dos produtos.
        public int codProduto { get; set; }
        public int contadorProduto = 0;


        private int paginaAtual = 1;
        private string relatorioTitulo = "Ordem de Serviço";

        void abrirFormularioCadastroOrcamento()
        {

            frmCadastroOrcamento frmCadastroOrcamento = new frmCadastroOrcamento(this.codigoOrcamento);
            frmCadastroOrcamento.codigo = this.codigoOrcamento;
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
            dgOrcamento.DataSource = null;

            dgOrcamento.DataSource = contexto.venda.Where(v => v.ven_status.Contains("Aberto")).Select(x => new
            {
                x.itensvenda.Where(i => i.ven_cod == x.ven_cod).FirstOrDefault().ClienteProduto.cliente.cli_nome,
                x.ven_cod,
                x.ven_status,
                x.ven_total,
            }).ToList();

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
                this.codigoOrcamento = int.Parse(dgOrcamento.Rows[e.RowIndex].Cells["ven_cod"].Value.ToString());
                dgvItens.DataSource = null;

                dgvItens.DataSource = contexto.itensvenda.Include("operacao").Include("ClienteProduto").Include("produto").Select(i => new
                {
                    i.ven_cod,
                    i.ClienteProduto.produto.pro_nome,
                    i.itv_qtde,
                    i.itv_valorBase,
                    i.itv_valor,
                    i.itv_desconto,
                    i.referencia,
                    i.operacao.op_nome
                }).Where(i => i.ven_cod == codigoOrcamento).ToList();
            }
            catch (Exception)
            {
            }

        }

        private void dgOrcamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Convert.ToInt32(dgOrcamento.Rows[e.RowIndex].Cells["ven_cod"].Value) > 0)
            {
                this.codigoOrcamento = int.Parse(dgOrcamento.Rows[e.RowIndex].Cells["ven_cod"].Value.ToString());
            }

            if (this.codigoOrcamento > 0)
            {

                var modelo = contexto.venda.Find(codigoOrcamento);
                if (modelo.ven_status == "Cancelado")
                {
                    MessageBox.Show("Orçamento Cancelado");
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codigoOrcamento > 0)
            {

                var modeloVenda = contexto.venda.Find(codigoOrcamento);


                if (modeloVenda.ven_status == "Cancelado")
                {
                    MessageBox.Show("Pedido Cancelado");
                }
                else
                {
                    abrirFormularioCadastroOrcamento();
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


                    var modeloVenda = contexto.venda.Find(codigoVenda);

                    //Se a venda não estiver cancelada.
                    if (modeloVenda.ven_status != "Cancelado")
                    {
                        //Calculando a quantidade de parcelas já pagas

                        //Se quantidade for maior que zero significar que já foi pago alguma ou todas as parcelas
                        //Sendo assim não será possível excluir a compra.

                        //cx.Conectar();
                        //cx.IniciarTransacao();

                        //Excluindo todas as parcelas de uma compra
                        //Aqui estou incrementando a quantidade dos produtos, já que a venda foi cancelada.

                        //Excluindo todos os Itens de uma compra
                        //BllItensVenda bllItensVenda = new BllItensVenda(cx);

                        //Aqui é chamado uma trigger DecrementaEstoqueCompra
                        //bllItensVenda.ExcluirTodosItensVenda(Convert.ToInt32(codigoOrcamento));

                        //Excluindo a Compra                  

                        modeloVenda.ven_status = "Cancelado";
                        contexto.Entry(modeloVenda).State = System.Data.Entity.EntityState.Modified;
                        contexto.SaveChanges();

                        dgOrcamento.DataSource = null;


                        carregaDataGrid();

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
                dgOrcamento.DataSource = dgOrcamento.DataSource = contexto.venda.Where(v => v.ven_status.Contains("Aberto")).Select(x => new
                {
                    x.itensvenda.Where(i => i.ven_cod == x.ven_cod).FirstOrDefault().ClienteProduto.cliente.cli_nome,
                    x.ven_cod,
                    x.ven_status,
                    x.ven_total,
                    x.ven_data_entrada
                }).ToList();
            }
            if (rbFinalizado.Checked)
            {
                dgOrcamento.DataSource = dgOrcamento.DataSource = contexto.venda.Where(v => v.ven_status.Contains("Finalizado")).Select(x => new
                {
                    x.itensvenda.Where(i => i.ven_cod == x.ven_cod).FirstOrDefault().ClienteProduto.cliente.cli_nome,
                    x.ven_cod,
                    x.ven_status,
                    x.ven_total,
                    x.ven_data_entrada,
                    x.ven_data_saida
                }).ToList();
            }
            if (rbCancelado.Checked)
            {
                dgOrcamento.DataSource = dgOrcamento.DataSource = contexto.venda.Where(v => v.ven_status.Contains("Cancelado")).Select(x => new
                {
                    x.itensvenda.Where(i => i.ven_cod == x.ven_cod).FirstOrDefault().ClienteProduto.cliente.cli_nome,
                    x.ven_cod,
                    x.ven_status,
                    x.ven_total,
                    x.ven_data_entrada
                }).ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Relatorio_Atualizado.Orcamento.frmRelatorioOrçamento frm = new Relatorio_Atualizado.Orcamento.frmRelatorioOrçamento();
            frm.ShowDialog();

        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            Relatorio_Atualizado.Orcamento.frmRelatorioOrçamento frm = new Relatorio_Atualizado.Orcamento.frmRelatorioOrçamento();
            frm.ShowDialog();
        }

        public const int WM_NCLMUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();

        private void pnCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLMUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }
    }
}
