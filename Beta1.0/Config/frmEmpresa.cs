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
using DAL;
using System.IO;

namespace Beta1._0.Config
{
    public partial class frmConfig : Form
    {

        public frmConfig(int cod = 1)
        {

            InitializeComponent();
            conexao = new DalConexao(DadosConexao.stringConexao);
            this.cod = cod;
        }
        DalConexao conexao;
        public int cod { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            var modeloEmpresa = new ModeloEmpresa();

            var bllEmpresa = new BllEmpresa(conexao);

            modeloEmpresa.bairro = txtBairro.Text;
            modeloEmpresa.cadastro = DateTime.Now;
            modeloEmpresa.celular = txtCelular.Text;
            modeloEmpresa.cidade = txtCidade.Text;
            modeloEmpresa.cpfcnpj = txtCpfCnpj.Text;
            modeloEmpresa.email = txtEmail.Text;
            modeloEmpresa.estado = txtEstado.Text;
            modeloEmpresa.nome = txtEmpresa.Text;
            modeloEmpresa.numero = txtNumero.Text;
            modeloEmpresa.endereco = txtEndereco.Text;
            modeloEmpresa.telefone = txtTelefone.Text;

            if (Convert.ToInt32(txtCod.Text) <= 0)
            {
                bllEmpresa.Incluir(modeloEmpresa);
                this.Close();
            }
            else
            {
                modeloEmpresa.cod = this.cod;
                bllEmpresa.Alterar(modeloEmpresa);
                this.Close();
            }


            string[] corpo = txtCorpo.Lines;
            var corpoEmail = "";
            for (int i = 0; i < corpo.Length; i++)
            {
                if (i>0)
                {
                    corpoEmail += String.Format("\n {0}", corpo[i]);
                }             
                
            }
            try
            {
                Ferramentas.xmlConfig.config.SalvaEmail(txtnomeEmail.Text, txtAssunto.Text, txtSenhaEmail.Text, corpoEmail, txtRodape1.Text, txtRodape2.Text, txtRodape3.Text);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            var modelo = new BllEmpresa(conexao).CarregaModeloEmpresa(1);

            txtCod.Text = modelo.cod.ToString();
            txtBairro.Text = modelo.bairro;
            txtCelular.Text = modelo.celular;
            txtCidade.Text = modelo.cidade;
            txtCpfCnpj.Text = modelo.cpfcnpj;
            txtEmail.Text = modelo.email;
            txtEstado.Text = modelo.estado;
            txtEmpresa.Text = modelo.nome;
            txtNumero.Text = modelo.numero;
            txtTelefone.Text = modelo.telefone;
            txtEndereco.Text = modelo.endereco;

            //carregando campos do email
            var email = Ferramentas.xmlConfig.config.carregaEmail();
            txtCodEmail.Text = email.codigo.ToString();
            txtAssunto.Text = email.assunto;
            txtCorpo.Text = email.corpo;
            txtRodape1.Text = email.rodape1;
            txtRodape2.Text = email.rodape2;
            txtRodape3.Text = email.rodape3;
            txtSenhaEmail.Text = email.senha;
            txtnomeEmail.Text = email.nome;       


            //carregando campos do config do banco de dados
            var bancoXml = Ferramentas.xmlConfig.config.carregaBanco();           
            banco.Text = bancoXml.nomeBanco;
            usuario.Text = bancoXml.usuarioBanco;
            senha.Text = bancoXml.senhaBanco;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Ferramentas.xmlConfig.config.SalvaBanco(txtBanco.Text, usuario.Text, senha.Text,txtSegurancaBanco.Text);
                lbAviso.Text = "Informações salvas";
            }
            catch (Exception)
            {

                throw;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirma = MessageBox.Show("Caso não tenha salvo. Suas informações serão perdidas", "Deseje realmente sair", MessageBoxButtons.YesNo);
            if (confirma == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                Ferramentas.Backup.BackupBanco(txtServidor.Text, txtBanco.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void frmConfig_Activated(object sender, EventArgs e)
        {
            cbBanco.DataSource = Ferramentas.Backup.listarBackup(txtServidor.Text, txtBanco.Text);
            cbBanco.DisplayMember = "FriendlyName";
            cbBanco.ValueMember = "physical_device_name";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Ferramentas.Backup.RestaurarBanco(txtServidor.Text, txtBanco.Text, cbBanco.SelectedValue.ToString(), cbBanco.SelectedText.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = false;
            op.ShowDialog();
            if (op.FileName != null)
            {
                txtLogo.Text = op.FileName;
                Ferramentas.xmlConfig.config.SalvaLogo(op.FileName);
            }
        }

        private async void BtnEnviarSms_Click(object sender, EventArgs e)
        {
            Ferramentas.EnviaSms sms = new Ferramentas.EnviaSms("netos0223@gmail.com", "NETO1994");
            string[] destino = { txtTelefoneEnviarMensagem.Text };

            try
            {
                await sms.EnvieSms(destino, txtMensagemEnvioLembrete.Text);
                BllAviso.aviso("Lembrete Enviado com sucesso");
            }
            catch (Exception ex)
            {
                BllAviso.aviso("Ops! " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BllLembrete bll = new BllLembrete(conexao);
            bll.Alterar(1, Convert.ToInt32(nuDiasLembrete.Value), txtLembrete.Text, txtTituloLembrete.Text);
        }
    }
}
