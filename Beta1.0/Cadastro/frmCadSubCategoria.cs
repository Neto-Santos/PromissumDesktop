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
    public partial class frmCadSubCategoria : Form
    {
        promissumServicoEntities contexto = new promissumServicoEntities();

        string codigo;
        public frmCadSubCategoria(string codigo)
        {
            InitializeComponent();
           
            this.codigo = codigo;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void frmCadSubCategoria_Load(object sender, EventArgs e)
        {

            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";
            cbCategoria.DataSource = contexto.categoria.ToList();
           
            if (!String.IsNullOrEmpty(codigo))
            {
                int cod = Convert.ToInt32(codigo);
                var _subCategoria = contexto.subcategoria.Find(cod);

                txtSubCategoria.Text = _subCategoria.scat_nome;
                cbCategoria.SelectedValue = _subCategoria.cat_cod;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(codigo))
            {
                var _subCategoria = new subcategoria { scat_nome = txtSubCategoria.Text,scat_cadastro = DateTime.Now ,cat_cod = Convert.ToInt32(cbCategoria.SelectedValue)};
                contexto.subcategoria.Add(_subCategoria);
                Formulario.limpaCampos(this);
            }
            else
            {
                int cod = Convert.ToInt32(codigo);
                var _subCategoria = contexto.subcategoria.Find(cod);

                _subCategoria.scat_cod = Convert.ToInt32(this.codigo);
                _subCategoria.scat_nome = txtSubCategoria.Text;
                _subCategoria.cat_cod = Convert.ToInt32(cbCategoria.SelectedValue);

                contexto.Entry(_subCategoria).State = System.Data.Entity.EntityState.Modified;
            }

            contexto.SaveChanges();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirma = MessageBox.Show("Caso não tenha salvo. Suas informações serão perdidas", "Deseje realmente sair", MessageBoxButtons.YesNo);
            if (confirma == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
