using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidade;
using BLL;
using DAL.EntityFramework;
using Ferramentas;

namespace Beta1._0.Cadastro
{
    public partial class frmCadCliente : Form
    {
        string codigo;
        promissumServicoEntities contexto = new promissumServicoEntities();
        public frmCadCliente(string codigo = null)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        void carregaCampos(cliente modelo)
        {
            txtBairro.Text = modelo.cli_bairro;
            txtCelular.Text = modelo.cli_cel;
            txtCep.Text = modelo.cli_cep;
            txtCidade.Text = modelo.cli_cidade;
            txtCod.Text = (string)modelo.cli_cod.ToString();

            if (modelo.cli_cpfcnpj.Length > 14)
            {
                rbJuridico.Checked = true;
                txtCnpj.Text = modelo.cli_cpfcnpj;
            }

            else
            {
                rbFisico.Checked = true;
                txtCpf.Text = modelo.cli_cpfcnpj;
            }

            txtEmail.Text = modelo.cli_email;
            txtEndereco.Text = modelo.cli_endereco;
            txtEstado.Text = modelo.cli_estado;
            txtNome.Text = modelo.cli_nome;
            txtRg.Text = modelo.cli_rgie;
            txtTelefone.Text = modelo.cli_fone;
            txtObservacao.Text = modelo.cli_observacao;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var cpf_cnpj = "";
            var tipoCliente = "";
            if (rbFisico.Checked)
            {
                cpf_cnpj = txtCpf.Text;
                tipoCliente = "Fisica";
            }
            else
            {
                cpf_cnpj = txtCnpj.Text;
                tipoCliente = "Juridica";
            }

            var cliente = new cliente()
            {
                cli_bairro = txtBairro.Text,
                cli_cel = txtCelular.Text,
                cli_cep = txtCep.Text,
                cli_cidade = txtCidade.Text,
                cli_cpfcnpj = cpf_cnpj,
                cli_email = txtEmail.Text,
                cli_endereco = txtEndereco.Text,
                cli_endnumero = txtRg.Text,
                cli_estado = txtEstado.Text,
                cli_fone = txtTelefone.Text,
                cli_nome = txtNome.Text,
                cli_rgie = txtRg.Text,
                cli_observacao = txtObservacao.Text,
                cli_tipo = tipoCliente
            };


            if (codigo != null)
            {
                int cod = Convert.ToInt32(codigo);
                var _cliente = contexto.cliente.Find(cod);
                _cliente.cli_bairro = txtBairro.Text;
                _cliente.cli_cel = txtCelular.Text;
                _cliente.cli_cep = txtCep.Text;
                _cliente.cli_cidade = txtCidade.Text;
                _cliente.cli_cpfcnpj = cpf_cnpj;
                _cliente.cli_email = txtEmail.Text;
                _cliente.cli_endereco = txtEndereco.Text;
                _cliente.cli_endnumero = txtRg.Text;
                _cliente.cli_estado = txtEstado.Text;
                _cliente.cli_fone = txtTelefone.Text;
                _cliente.cli_nome = txtNome.Text;
                _cliente.cli_rgie = txtRg.Text;
                _cliente.cli_observacao = txtObservacao.Text;
                _cliente.cli_tipo = tipoCliente;

                contexto.Entry(_cliente).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                contexto.cliente.Add(cliente);

                Formulario.limpaCampos(this);
            }

            contexto.SaveChanges();
            this.Close();
            this.Dispose();

        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            if (codigo != null)
            {
                int cod = Convert.ToInt32(codigo);
                var _cliente = contexto.cliente.Find(cod);
                carregaCampos(_cliente);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var confirma = MessageBox.Show("Caso não tenha salvo. Suas informações serão perdidas", "Deseje realmente sair", MessageBoxButtons.YesNo);
            if (confirma == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rbFisico_Click(object sender, EventArgs e)
        {
            if (rbFisico.Checked)
            {
                txtCpf.Enabled = true;
                txtRg.Enabled = true;
                txtCnpj.Enabled = false;
            }
            if (rbJuridico.Checked)
            {
                txtCpf.Enabled = false;
                txtRg.Enabled = false;
                txtCnpj.Enabled = true;
            }
        }

        private void rbJuridico_Click(object sender, EventArgs e)
        {
            if (rbFisico.Checked)
            {
                txtCpf.Enabled = true;
                txtRg.Enabled = true;
                txtCnpj.Enabled = false;
            }
            if (rbJuridico.Checked)
            {
                txtCpf.Enabled = false;
                txtRg.Enabled = false;
                txtCnpj.Enabled = true;
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (ckbBuscarCep.Checked)
            {
                BuscaEndereco.verificaCEP(txtCep.Text);
                txtBairro.Text = BuscaEndereco.bairro;
                txtCidade.Text = BuscaEndereco.cidade;
                txtEndereco.Text = BuscaEndereco.tipo_logradouro+ " - " + BuscaEndereco.endereco;
                txtEstado.Text = BuscaEndereco.estado;                
            }
        }
    }
}
