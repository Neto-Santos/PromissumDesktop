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
    public partial class frmCadOperacao : Form
    {
        promissumServicoEntities contexto = new promissumServicoEntities();

        string codigo = "";
        public frmCadOperacao(string codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(codigo))
                {
                    var _operacao = contexto.operacao.Add(new operacao { op_descricao = txtDescricao.Text, op_nome = txtOperacao.Text, op_cadastro = DateTime.Now });

                    Formulario.limpaCampos(this);
                    
                }
                else
                {
                    int cod = Convert.ToInt32(codigo);

                    var _operacao = contexto.operacao.Find(cod);

                    _operacao.op_descricao = txtDescricao.Text;
                    _operacao.op_nome = txtOperacao.Text;

                    contexto.Entry(_operacao).State = System.Data.Entity.EntityState.Modified;
                    //=====================Utilizando DataSets===================                    
                    Formulario.limpaCampos(this);
                }

                contexto.SaveChanges();              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
            this.Dispose();
        }

        private void frmCadOperacao_Load(object sender, EventArgs e)
        {              

            if (!String.IsNullOrEmpty(codigo))
            {
                int cod = Convert.ToInt32(codigo);

                var modelo = contexto.operacao.Find(cod);
                txtOperacao.Text = modelo.op_nome;
                txtDescricao.Text = modelo.op_descricao;               
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
    }
}
