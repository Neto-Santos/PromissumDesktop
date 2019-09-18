using System;
using System.Linq;
using Beta1._0.Login;
using Beta1._0.Consulta;
using System.Windows.Forms;
using Beta1._0.Usuario;
using Beta1._0.Relatorio.Produto;
using Promissum.Relatorio_Atualizado.Operacao;
using Beta1._0.Relatorio.Categoria;
using Beta1._0.Relatorio.SubCategoria;
using Beta1._0.Relatorio.Os;
using Beta1._0.Relatorio.Produto.ClienteProduto;
using Beta1._0.Config;
using Beta1._0.Consulta.ConsultaRapida;
using Beta1._0.Relatorio.Fornecedor;
using Beta1._0.Sobre;
using Promissum.Consulta;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Beta1._0
{
    public partial class frmPrincipal : Form
    {
        public const int WM_NCLMUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;
       
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();

        public frmPrincipal()
        {
            InitializeComponent();

            var processo = System.Diagnostics.Process.GetCurrentProcess();
            var jaEstaRodando = System.Diagnostics.Process.GetProcessesByName(processo.ProcessName).Any(p => p.Id != processo.Id);

            

            if (jaEstaRodando)
            {
                MessageBox.Show("Este programa já está aberto.");
                Application.Exit();
                this.Close();
            }
            else
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }

        }

        List<string> listaCbManutencao = new List<string>() {
                                                                "Manutenção","Cliente","Fornecedor","Produto", "-------",
                                                                "Categoria","SubCategoria","-------",
                                                                "Tipos de Operação","Manutenção de Veículos"};

        List<string> listaCbVendas = new List<string>()    {
                                                                "Vendas","Orçamento"};

        List<string> listaCbRelatorio = new List<string>()    {
                                                                "Relatórios","Produto","-----","Cliente","ClienteXProduto","------",
                                                                "Fornecedor","Orçamento","------","Tipo-Modelo","------","Operação"};
        List<string> listaCbFinanceiro = new List<string>()    {
                                                                "Financeiro","Contas A Pagar","Contas Pagas", "Contas A Receber","Contas Recebidas","Fluxo de Caixa"};
        

        public static string usuario = null;
        public static string codUsuario = null;

        frmConsultaSubCategoria frmConsultaSubCategoria = null;
        frmConsultaCliente frmConsultaCliente = null;
        frmConsultaFornecedor frmConsultaFornecedor = null;
        frmConsultaProduto frmConsultaProduto = null;
        frmConsultaOrcamento frmConsultaOrcamento = null;
        frmConsultaCategoria frmConsultaCategoria = null;
        frmConsultaOperacao frmConsultaOperacao = null;
        frmConsultaMontadora frmConsultaMontadora = null;
        
     
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConsultaCliente == null || frmConsultaCliente.IsDisposed)
            {
                frmConsultaCliente = new frmConsultaCliente();
                frmConsultaCliente.MdiParent = this;
                frmConsultaCliente.Show();
            }
            else
            {
                frmConsultaCliente.Show();
                frmConsultaCliente.BringToFront();
            }
        }
        
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (frmConsultaOrcamento == null || frmConsultaOrcamento.IsDisposed)
            {
                frmConsultaOrcamento = new frmConsultaOrcamento();
                frmConsultaOrcamento.MdiParent = this;
                frmConsultaOrcamento.Show();
            }
            else
            {
                frmConsultaOrcamento.Show();
                frmConsultaOrcamento.BringToFront();
            }
        }

    
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();

            if (frm.status == true)
            {
                frmCadUsuario frmUsuario = new frmCadUsuario();
                frmUsuario.ShowDialog();
            }
        }

      

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioSubCategoria frm = new frmRelatorioSubCategoria(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            frm.ShowDialog();
            frm.Dispose();
        }

        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioOs frm = new frmRelatorioOs(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            frm.ShowDialog();
            frm.Dispose();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            statusUsuario.Text = "Usuário: " + usuario;

            comboBox2.DataSource = listaCbManutencao;
            cbVendas.DataSource = listaCbVendas;
            cbRelatorios.DataSource = listaCbRelatorio;
            cbFinanceiro.DataSource = listaCbFinanceiro;
            //Muda cor de fundo
            MdiClient ctlMDI = (MdiClient)this.Controls[this.Controls.Count - 1];
            ctlMDI.BackColor = this.BackColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusUsuario.Text = "Usuário: " + usuario;
            statusDataHora.Text = String.Format("Data: {0} Hora:{1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var confirmacao = MessageBox.Show("Tem certeza que deseja encerrar o programa?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Cliente")
            {
                if (frmConsultaCliente == null || frmConsultaCliente.IsDisposed)
                {
                    frmConsultaCliente = new frmConsultaCliente();
                    frmConsultaCliente.MdiParent = this;
                    frmConsultaCliente.Show();
                }
                else
                {
                    frmConsultaCliente.Show();
                    frmConsultaCliente.BringToFront();
                }
            }
            else if (comboBox2.Text == "Fornecedor")
            {
                if (frmConsultaFornecedor == null || frmConsultaFornecedor.IsDisposed)
                {
                    frmConsultaFornecedor = new frmConsultaFornecedor();
                    frmConsultaFornecedor.MdiParent = this;
                    frmConsultaFornecedor.Show();
                }
                else
                {
                    frmConsultaFornecedor.Show();
                    frmConsultaFornecedor.BringToFront();
                }
            }
            else if (comboBox2.Text == "Produto")
            {
                if (frmConsultaProduto == null || frmConsultaProduto.IsDisposed)
                {
                    frmConsultaProduto = new frmConsultaProduto();
                    frmConsultaProduto.MdiParent = this;
                    frmConsultaProduto.Show();
                }
                else
                {
                    frmConsultaProduto.Show();
                    frmConsultaProduto.BringToFront();
                }
            }
            else if (comboBox2.Text == "Categoria")
            {
                if (frmConsultaCategoria == null || frmConsultaCategoria.IsDisposed)
                {
                    frmConsultaCategoria = new frmConsultaCategoria();
                    frmConsultaCategoria.MdiParent = this;
                    frmConsultaCategoria.Show();
                }
                else
                {
                    frmConsultaCategoria.Show();
                    frmConsultaCategoria.BringToFront();
                }
            }
            else if (comboBox2.Text == "SubCategoria")
            {
                if (frmConsultaSubCategoria == null || frmConsultaSubCategoria.IsDisposed)
                {
                    frmConsultaSubCategoria = new frmConsultaSubCategoria();
                    frmConsultaSubCategoria.MdiParent = this;
                    frmConsultaSubCategoria.Show();
                }
                else
                {
                    frmConsultaSubCategoria.Show();
                    frmConsultaSubCategoria.BringToFront();
                }
            }
            else if (comboBox2.Text == "Tipos de Operação")
            {
                if (frmConsultaOperacao == null || frmConsultaOperacao.IsDisposed)
                {
                    frmConsultaOperacao = new frmConsultaOperacao();
                    frmConsultaOperacao.MdiParent = this;
                    frmConsultaOperacao.Show();
                }
                else
                {
                    frmConsultaOperacao.Show();
                    frmConsultaOperacao.BringToFront();
                }
            }
            else if (comboBox2.Text == "Manutenção de Veículos")
            {
                if (frmConsultaMontadora == null || frmConsultaMontadora.IsDisposed)
                {
                    frmConsultaMontadora = new frmConsultaMontadora();
                    frmConsultaMontadora.MdiParent = this;
                    frmConsultaMontadora.Show();
                }
                else
                {
                    frmConsultaMontadora.Show();
                    frmConsultaMontadora.BringToFront();
                }
            }
            else
            {

            }
            
        }

        private void cbVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVendas.Text == "Orçamento")
            {
                if (frmConsultaOrcamento == null || frmConsultaOrcamento.IsDisposed)
                {
                    frmConsultaOrcamento = new frmConsultaOrcamento();
                    frmConsultaOrcamento.MdiParent = this;
                    frmConsultaOrcamento.Show();
                }
                else
                {
                    frmConsultaOrcamento.Show();
                    frmConsultaOrcamento.BringToFront();
                }
            }
        }

        private void cbRelatorios_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbRelatorios.Text == "Produto")
            {
                frmFiltroProduto frm = new frmFiltroProduto(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
                frm.ShowDialog();
                frm.Dispose();
            }
            else if (cbRelatorios.Text == "Cliente")
            {
                Relatorio_Atualizado.Cliente.frmFiltroCliente frm = new Relatorio_Atualizado.Cliente.frmFiltroCliente();
                frm.ShowDialog();
                frm.Dispose();
            }
            else if (cbRelatorios.Text == "ClienteXProduto")
            {
                frmFiltroClienteProduto frm = new frmFiltroClienteProduto(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
                frm.ShowDialog();
                frm.Dispose();
            }
            else if (cbRelatorios.Text == "Fornecedor")
            {
                frmFiltroFornecedor frm = new frmFiltroFornecedor(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
                frm.ShowDialog();
                frm.Dispose();
            }
            else if (cbRelatorios.Text == "Orçamento")
            {
                Relatorio_Atualizado.Orcamento.frmFiltroOrcamento frm = new Relatorio_Atualizado.Orcamento.frmFiltroOrcamento();
                frm.ShowDialog();
                frm.Dispose();
            }
            else if (cbRelatorios.Text == "Tipo-Modelo")
            {
                frmFiltroCategoria frm = new frmFiltroCategoria(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
                frm.ShowDialog();
                frm.Dispose();
            }
            else if (cbRelatorios.Text == "Operação")
            {
                frmFiltroOperacao frm = new frmFiltroOperacao();
                frm.ShowDialog();
                frm.Dispose();
            }
            else
            {

            }
        }

        private void btnConsultaRapida_Click(object sender, EventArgs e)
        {
            frmConsultaRapida frm = new frmConsultaRapida();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            frmBackupRestauracao frm = new frmBackupRestauracao();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frm = new frmConfig();
            frm.ShowDialog();
        }
        

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }


        private void pnCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLMUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
    }
}
