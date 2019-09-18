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
using Ferramentas;
using DAL.EntityFramework;

namespace Beta1._0.Cadastro
{
    public partial class frmCadCategoria : Form
    {
        promissumServicoEntities contexto = new promissumServicoEntities();

        public frmCadCategoria(string codigo = null)
        {

            InitializeComponent();

            this.codigo = codigo;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        string codigo;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(codigo))
            {
                var _categoria = new categoria { cat_cadastro = DateTime.Now, cat_nome = txtCategoria.Text };

                contexto.categoria.Add(_categoria);

                Formulario.limpaCampos(this);
            }
            else
            {

                int cod = Convert.ToInt32(codigo);

                var _categoria = contexto.categoria.Find(cod);

                _categoria.cat_nome = txtCategoria.Text;

                contexto.Entry(_categoria).State = System.Data.Entity.EntityState.Modified;

            }

            contexto.SaveChanges();

            this.Close();
            this.Dispose();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var confirma = MessageBox.Show("Caso não tenha salvo. Suas informações serão perdidas", "Deseje realmente sair", MessageBoxButtons.YesNo);
            if (confirma == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmCadCategoria_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(codigo))
            {
                int cod = Convert.ToInt32(codigo);
                var categoria = contexto.categoria.Find(cod);
                txtCategoria.Text = categoria.cat_nome;
            }
        }
    }
}
