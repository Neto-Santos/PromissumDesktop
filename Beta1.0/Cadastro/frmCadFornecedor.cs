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
using Beta1._0.Consulta;
using BLL;
using DAL.EntityFramework;
using Ferramentas;

namespace Beta1._0.Cadastro
{
    public partial class frmCadFornecedor : Form
    {
        string codigo = null;
        promissumServicoEntities contexto = new promissumServicoEntities();
        public frmCadFornecedor(string codigo = null)
        {
            InitializeComponent();

            this.codigo = codigo;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        void carregaCampos()
        {
            if (codigo != null && !String.IsNullOrEmpty(this.codigo))
            {
                int cod = Convert.ToInt32(codigo);

                var modelo = contexto.fornecedor.Find(cod);

                txtCod.Text = modelo.for_cod.ToString();
                txtBairro.Text = modelo.for_bairro;
                txtCelular.Text = modelo.for_cel;
                txtCep.Text = modelo.for_cep;
                txtCidade.Text = modelo.for_cidade;
                txtCnpj.Text = modelo.for_cnpj;
                txtEmail.Text = modelo.for_email;
                txtEndereco.Text = modelo.for_endereco;
                txtNumero.Text = modelo.for_endnumero;
                txtEstado.Text = modelo.for_estado;
                txtTelefone.Text = modelo.for_fone;
                txtFantasia.Text = modelo.for_nome;
                txtSocial.Text = modelo.for_rsocial;
                txtIe.Text = modelo.for_ie;
                txtCpf.Text = modelo.for_cpf;
                txtObservacao.Text = modelo.for_observacao;

                if (modelo.for_cnpj == "  .   .   /    -")
                {
                    rbJuridico.Checked = false;
                    rbFisico.Checked = true;
                }
                else
                {
                    rbJuridico.Checked = true;
                    rbFisico.Checked = false;
                }

            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (codigo != null && !String.IsNullOrEmpty(this.codigo))
            {
                int cod = Convert.ToInt32(codigo);

                var modelo = contexto.fornecedor.Find(cod);
                modelo.for_bairro = txtBairro.Text;
                modelo.for_cel = txtCelular.Text;
                modelo.for_cep = txtCep.Text;
                modelo.for_cidade = txtCidade.Text;
                modelo.for_cnpj = txtCnpj.Text;
                modelo.for_cpf = txtCpf.Text;
                modelo.for_email = txtEmail.Text;
                modelo.for_endereco = txtEndereco.Text;
                modelo.for_endnumero = txtNumero.Text;
                modelo.for_estado = txtEstado.Text;
                modelo.for_fone = txtTelefone.Text;
                modelo.for_ie = txtIe.Text;
                modelo.for_nome = txtFantasia.Text;
                modelo.for_rsocial = txtSocial.Text;
                modelo.for_observacao = txtObservacao.Text;
                modelo.for_cadastro = DateTime.Now;

                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;

            }
            else
            {
                string tipo = "";
                if (rbFisico.Checked)
                {
                    tipo = "Fisica";
                }
                else
                {
                    tipo = "Juridica";
                }
                var modelo = new fornecedor()
                {
                    for_bairro = txtBairro.Text,
                    for_cel = txtCelular.Text,
                    for_cep = txtCep.Text,
                    for_cidade = txtCidade.Text,
                    for_cnpj = txtCnpj.Text,
                    for_cpf = txtCpf.Text,
                    for_email = txtEmail.Text,
                    for_endereco = txtEndereco.Text,
                    for_endnumero = txtNumero.Text,
                    for_estado = txtEstado.Text,
                    for_fone = txtTelefone.Text,
                    for_ie = txtIe.Text,
                    for_nome = txtFantasia.Text,
                    for_rsocial = txtSocial.Text,
                    for_observacao = txtObservacao.Text,
                    for_cadastro = DateTime.Now
                };

                contexto.fornecedor.Add(modelo);
                Formulario.limpaCampos(this);
            }

            contexto.SaveChanges();

            this.Close();
            this.Dispose();
        }

        private void frmCadFornecedor_Load(object sender, EventArgs e)
        {
            carregaCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirma = MessageBox.Show("Caso não tenha salvo. Suas informações serão perdidas", "Deseje realmente sair", MessageBoxButtons.YesNo);
            if (confirma == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rbJuridico_Click(object sender, EventArgs e)
        {
            if (rbFisico.Checked)
            {
                txtCpf.Enabled = true;
                txtCnpj.Enabled = false;
                txtIe.Enabled = false;

            }
            if (rbJuridico.Checked)
            {
                txtCpf.Enabled = false;
                txtCnpj.Enabled = true;
                txtIe.Enabled = true;
            }
        }

        private void rbFisico_Click(object sender, EventArgs e)
        {
            if (rbFisico.Checked)
            {
                txtCpf.Enabled = true;
                txtCnpj.Enabled = false;
                txtIe.Enabled = false;
            }
            if (rbJuridico.Checked)
            {
                txtCpf.Enabled = false;
                txtCnpj.Enabled = true;
                txtIe.Enabled = true;
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (ckbBuscarCep.Checked)
            {
                BuscaEndereco.verificaCEP(txtCep.Text);
                txtBairro.Text = BuscaEndereco.bairro;
                txtCidade.Text = BuscaEndereco.cidade;
                txtEndereco.Text = BuscaEndereco.tipo_logradouro + " - " + BuscaEndereco.endereco;
                txtEstado.Text = BuscaEndereco.estado;
            }
        }
    }
}


