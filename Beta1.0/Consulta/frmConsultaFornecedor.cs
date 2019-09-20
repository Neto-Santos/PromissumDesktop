using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Beta1._0.Cadastro;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.EntityFramework;
using BLL;
using System.Runtime.InteropServices;

namespace Beta1._0.Consulta
{
    public partial class frmConsultaFornecedor : Form
    {
        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }

        promissumServicoEntities contexto = new promissumServicoEntities();

        string codigo;
        void abrirFormularioCadastroOrcamento(string codigo = null)
        {
            frmCadFornecedor frmCadFornecedor = new frmCadFornecedor(codigo);
            if ((Application.OpenForms["frmCadFornecedor"] as frmCadFornecedor) != null)
            {
                frmCadFornecedor.BringToFront();
                frmCadFornecedor.Focus();
            }
            else
            {
                frmCadFornecedor.MdiParent = this.MdiParent;
                frmCadFornecedor.Show();
            }
        }
        public void atualiarDgFornecedor()
        {
            dgvFornecedor.DataSource = null;
            dgvFornecedor.DataSource = contexto.fornecedor.Select(x => new
            {
                x.for_cod,
                x.for_nome,
                x.for_cnpj,
                x.for_cidade,
                x.for_bairro,
                x.for_estado,
                x.for_cep,
                x.for_cel,
                x.for_cadastro
            }).ToList();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormularioCadastroOrcamento();
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                codigo = dgvFornecedor.Rows[e.RowIndex].Cells["for_cod"].Value.ToString();
            }
            catch (Exception)
            {
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                abrirFormularioCadastroOrcamento(codigo);
            }
        }

        private void frmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            Ferramentas.impressao objferra = new Ferramentas.impressao();
            objferra.CarregarListaDeImpressoras(cbImpressora);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (codigo != null)
            {
                int codFornecedor = int.Parse(codigo);

                var fornecedor = contexto.fornecedor.Find(codFornecedor);

                if (fornecedor.for_status == "Cancelado")
                {
                    fornecedor.for_status = "Ativo";
                }
                else
                {
                    fornecedor.for_status = "Cancelado";
                }

                contexto.Entry(fornecedor).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();

                atualiarDgFornecedor();

                codigo = null;

            }
        }

        private void frmConsultaFornecedor_Activated(object sender, EventArgs e)
        {
            dgvFornecedor.DataSource = contexto.fornecedor.Select(x => new
            {
                x.for_cod,
                x.for_nome,
                x.for_cnpj,
                x.for_cidade,
                x.for_bairro,
                x.for_estado,
                x.for_cep,
                x.for_cel,
                x.for_cadastro,
                x.for_status
            }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbCnpj.Checked)
                {
                    dgvFornecedor.DataSource = contexto.fornecedor.Select(x => new
                    {
                        x.for_cod,
                        x.for_nome,
                        x.for_cnpj,
                        x.for_cidade,
                        x.for_bairro,
                        x.for_estado,
                        x.for_cep,
                        x.for_cel,
                        x.for_cadastro,
                        x.for_status
                    }).Where(x => x.for_cnpj.Contains(textBox1.Text)).ToList();
                }
                if (rbCodigo.Checked)
                {
                    if (!String.IsNullOrEmpty(textBox1.Text))
                    {
                        int codFornecedor = int.Parse(textBox1.Text);
                        dgvFornecedor.DataSource = contexto.fornecedor.Select(x => new
                        {
                            x.for_cod,
                            x.for_nome,
                            x.for_cnpj,
                            x.for_cidade,
                            x.for_bairro,
                            x.for_estado,
                            x.for_cep,
                            x.for_cel,
                            x.for_cadastro,
                            x.for_status
                        }).Where(x => x.for_cod == codFornecedor).ToList();
                    }

                }
                if (rbNome.Checked)
                {
                    dgvFornecedor.DataSource = contexto.fornecedor.Select(x => new
                    {
                        x.for_cod,
                        x.for_nome,
                        x.for_cnpj,
                        x.for_cidade,
                        x.for_bairro,
                        x.for_estado,
                        x.for_cep,
                        x.for_cel,
                        x.for_cadastro,
                        x.for_status
                    }).Where(x => x.for_nome.Contains(textBox1.Text)).ToList();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ops. Verifique se o campo de pesquisa foi preenchido corretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Relatorio.Fornecedor.frmFiltroFornecedor frm = new Relatorio.Fornecedor.frmFiltroFornecedor();
            frm.ShowDialog();
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
