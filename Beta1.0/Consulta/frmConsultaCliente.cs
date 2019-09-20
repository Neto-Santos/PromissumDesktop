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
using Beta1._0.Relatorio.Os;
using Beta1._0.Relatorio.Cliente;
using DAL;
using System.Runtime.InteropServices;

namespace Beta1._0.Consulta
{
    public partial class frmConsultaCliente : Form
    {
        promissumServicoEntities contexto = new promissumServicoEntities();
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        string codigoCliente;
        int codigoClienteProduto;
        void atualizaDgCliente()
        {
            try
            {
                dgCliente.DataSource = contexto.cliente.ToList();
                //==========================================


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void abrirFormularioCadastroOrcamento(string codigo = null)
        {
            frmCadCliente frmCadCliente = new frmCadCliente(codigo);

            if ((Application.OpenForms["frmCadCliente"] as frmCadCliente) != null)
            {
                frmCadCliente.BringToFront();
                frmCadCliente.Focus();
            }
            else
            {
                frmCadCliente.MdiParent = this.MdiParent;
                frmCadCliente.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormularioCadastroOrcamento();
        }

        void atualizaDgClienteProduto(string valor)
        {
            int codCliente = Convert.ToInt32(valor);
            dgClienteProduto.DataSource = contexto.ClienteProduto.Where(cp => cp.codCliente == codCliente).Select(x=>new {x.referencia,x.produto.pro_nome,x.status,x.cadastro,x.cod }).ToList();
        }
        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            Ferramentas.impressao objferra = new Ferramentas.impressao();
            objferra.CarregarListaDeImpressoras(cbImpressora);

            //atualizaDgClienteProduto(codigoCliente);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormularioCadastroOrcamento(codigoCliente);
        }
        private void dgCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoCliente = dgCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (codigoCliente != null)
            {
                abrirFormularioCadastroOrcamento(codigoCliente);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //cliente não poderá ser mais excluídos,mas sim cancelado 

            if (codigoCliente != null)
            {
                var confirma = MessageBox.Show("Tem certeza que deseja cancelar o cliente selecionado?", "Aviso", MessageBoxButtons.YesNo);

                if (confirma == DialogResult.Yes)
                {
                    var codCliente = int.Parse(codigoCliente);
                    var _cliente = contexto.cliente.Find(codCliente);

                    if (_cliente.cli_status == "Cancelado")
                    {
                        _cliente.cli_status = "Ativo";
                    }
                    else
                    {
                        _cliente.cli_status = "Cancelado";
                    }
                    contexto.Entry(_cliente).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();

                    atualizaDgCliente();
                    codigoCliente = null;
                }
            }
        }

        private void btnConsultaProduto_Click(object sender, EventArgs e)
        {
            Consulta.ClienteProduto.frmConsultaProduto frm = new ClienteProduto.frmConsultaProduto();

            frm.ShowDialog();

            int codProduto = Convert.ToInt32(frm.codigo);

            var produto = contexto.produto.Find(codProduto);

            txtCod.Text = produto.pro_cod.ToString();
            lblDescricaoProduto.Text = produto.pro_nome;

            frm.Dispose();


        }

        private void btnVinculaProduto_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCod.Text) && !String.IsNullOrEmpty(txtReferencia.Text))
            {
                try
                {
                    if (contexto.ClienteProduto.Where(cp => cp.referencia.Equals(txtReferencia.Text)).Count() <= 0)
                    {
                        DAL.EntityFramework.ClienteProduto objClienteProduto = new DAL.EntityFramework.ClienteProduto();

                        objClienteProduto.codCliente = Convert.ToInt32(codigoCliente);
                        objClienteProduto.codProduto = Convert.ToInt32(txtCod.Text);
                        objClienteProduto.referencia = txtReferencia.Text;
                        objClienteProduto.cadastro = DateTime.Now;
                        objClienteProduto.status = "Ativo";

                        contexto.ClienteProduto.Add(objClienteProduto);
                        contexto.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Referencia já Cadastrada");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                atualizaDgClienteProduto(codigoCliente);

                lblDescricaoProduto.Text = "Consulte um Produto====>>>>";
                txtReferencia.Clear();
            }
            else
            {
                MessageBox.Show("Não há referência", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (rbCod.Checked)
                {
                    if (string.IsNullOrEmpty(txtPesquisa.Text))
                    {
                        var codCliente = int.Parse(txtPesquisa.Text);
                        dgCliente.DataSource = contexto.cliente.Where(c => c.cli_cod == codCliente).ToList();
                    }
                }
                if (rbCPf.Checked)
                {
                    dgCliente.DataSource = contexto.cliente.Where(c => c.cli_cpfcnpj.Contains(txtPesquisa.Text)).ToList();
                }
                if (rbNome.Checked)
                {
                    dgCliente.DataSource = contexto.cliente.Where(c => c.cli_nome.Contains(txtPesquisa.Text)).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ops. Parece que algo deu errado. Verifique se o campo foi preenchido corretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
            }
        }

        private void frmConsultaCliente_Activated(object sender, EventArgs e)
        {
            atualizaDgCliente();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Relatorio_Atualizado.Cliente.frmFiltroCliente frm = new Relatorio_Atualizado.Cliente.frmFiltroCliente();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigoCliente = dgCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (!String.IsNullOrEmpty(codigoCliente))
                {
                    atualizaDgClienteProduto(codigoCliente);

                }
                else
                {
                    dgClienteProduto.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Excluir o Produto Vinculado ao cliente.
        private void button5_Click(object sender, EventArgs e)
        {
            if (codigoClienteProduto > 0)
            {
                    try
                    {
                        var clienteProduto = contexto.ClienteProduto.Find(codigoClienteProduto);

                        if (clienteProduto.status == "Cancelado")
                        {
                            clienteProduto.status = "Ativo";
                        }
                        else
                        {
                            clienteProduto.status = "Cancelado";
                        }
                        contexto.Entry(clienteProduto).State = System.Data.Entity.EntityState.Modified;
                        contexto.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi possível realizar a operação", "Aviso", MessageBoxButtons.OK);
                    }

            }
        }

        private void dgClienteProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                codigoClienteProduto = Convert.ToInt32(dgClienteProduto.Rows[e.RowIndex].Cells["cod"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Formato de uma Placa de Veículo
        private void txtPlacaVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ferramentas.Mascaras.Formatar("PLACA", txtPlacaVeiculo);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {

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
    }
}
