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

namespace Beta1._0
{
    public partial class frmPrincipal : Form
    {
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
        
        
        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
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

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFiltroProduto frm = new frmFiltroProduto(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            frm.ShowDialog();
            frm.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_Atualizado.Cliente.frmFiltroCliente frm = new Relatorio_Atualizado.Cliente.frmFiltroCliente();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFiltroCategoria frm = new frmFiltroCategoria(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            frm.ShowDialog();
            frm.Dispose();
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

        private void orçamentoAnalíticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_Atualizado.Orcamento.frmFiltroOrcamento frm = new Relatorio_Atualizado.Orcamento.frmFiltroOrcamento();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void clientesAnalíticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroClienteProduto frm = new frmFiltroClienteProduto(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            frm.ShowDialog();
            frm.Dispose();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmConfig frm = new frmConfig();
            frm.ShowDialog();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmConsultaRapida frm = new frmConsultaRapida(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            frm.ShowDialog();
            frm.Dispose();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            statusUsuario.Text = "Usuário: " + usuario;

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

        private void tiposDeOperaçãoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroFornecedor frm = new frmFiltroFornecedor(new DAL.DalConexao(DAL.DadosConexao.stringConexao));
            frm.ShowDialog();
            frm.Dispose();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmBackupRestauracao frm = new frmBackupRestauracao();
            frm.ShowDialog();
            frm.Dispose();

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {           
                          
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
           }

        private void manutençãoDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void operaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmFiltroOperacao frm = new frmFiltroOperacao();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
