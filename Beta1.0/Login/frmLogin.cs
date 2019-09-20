using BLL;
using DAL.EntityFramework;
using Ferramentas;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta1._0.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        promissumServicoEntities contexto = new promissumServicoEntities();

        public bool status = false;
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {//VERIFICA SE O CLIENTE TEM UMA LICENÇA
            try
            {
                string PATH = @"SOFTWARE\Wow6432Node\QX3\ROTAS\Hosts";
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(PATH);
                string key = registryKey.GetValue("PROMISSUMKEY").ToString();
                if (key != "05041994")
                {
                    MessageBox.Show("Ops. Lamentamos mas você não tem uma licença para usar este programa.\n Entre em contato com o desenvolvedor");
                    Application.Exit();
                }
                else
                {

                    if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtSenha.Text))
                    {
                        var usuario = contexto.usuario.Where(u => u.usu_nome.Equals(txtUsuario.Text) && u.usu_senha.Equals(txtSenha.Text));
                        if (usuario.Count() > 0)
                        {
                            this.Hide();
                            this.status = true;
                            frmPrincipal.usuario = txtUsuario.Text;
                            
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops. Lamentamos mas você não tem uma licença para usar este programa.\n Entre em contato com o desenvolvedor",ex.Message);              
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
