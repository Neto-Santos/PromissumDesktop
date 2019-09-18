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
    public partial class frmCadProduto : Form
    {
        promissumServicoEntities contexto = new promissumServicoEntities();

        string codigo;
        string foto;
        public frmCadProduto(string codigo = null)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        void carregaComboBox()
        {
            try
            {
                cbCategoria.DisplayMember = "cat_nome";
                cbCategoria.ValueMember = "cat_cod";
                cbCategoria.DataSource = contexto.categoria.ToList();


                //=======================================================

                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
                cbSubCategoria.DataSource = contexto.subcategoria.ToList();
                int codCategoriaSelecionada = Convert.ToInt32(cbCategoria.SelectedValue);
                cbSubCategoria.DataSource = contexto.subcategoria.Where(s => s.cat_cod == codCategoriaSelecionada).ToList();

                //===============================================================
                cbFornecedor.DisplayMember = "for_nome";
                cbFornecedor.ValueMember = "for_cod";
                cbFornecedor.DataSource = contexto.fornecedor.ToList();

            }
            catch (Exception)
            {


            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.ShowDialog();
            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                pbImagem.Load(ofd.FileName);
                foto = copiaImagem.CopiarParaLocalDoAplicativo(ofd.FileName, "58585858");
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var modelo = new produto();

            int categoria = Convert.ToInt32(cbCategoria.SelectedValue);
            int subCategoria = Convert.ToInt32(cbSubCategoria.SelectedValue);
            int codFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
            //Convert.ToInt32(((DataRowView)ddlDivisionId.SelectedValue)["id"]);

            modelo.cat_cod = categoria;
            modelo.scat_cod = subCategoria;

            modelo.pro_descricao = txtDescricao.Text;
            modelo.pro_foto = "";
            modelo.pro_nome = txtNome.Text;
            modelo.umed = txtUndMedida.Text;
            modelo.pro_qtde = 0;
            modelo.localizacao = txtlocalizacao.Text;
            modelo.pro_valorpago = Convert.ToDecimal(txtCusto.Text);
            modelo.pro_valorvenda = Convert.ToDecimal(txtVenda.Text);
            modelo.pro_valorvenda = Convert.ToDecimal(txtVenda.Text);
            modelo.for_cod = codFornecedor;
            modelo.pro_ref = txtRef.Text;


            if (String.IsNullOrEmpty(codigo))
            {
                contexto.produto.Add(modelo);
                Formulario.limpaCampos(this);
            }
            else
            {
                int cod = Convert.ToInt32(codigo);
                var produto = contexto.produto.Find(cod);

                produto.cat_cod = categoria;
                produto.scat_cod = subCategoria;

                produto.pro_descricao = txtDescricao.Text;
                produto.pro_foto = "";
                produto.pro_nome = txtNome.Text;
                produto.umed = txtUndMedida.Text;
                produto.pro_qtde = 0;
                produto.localizacao = txtlocalizacao.Text;
                produto.pro_valorpago = Convert.ToDecimal(txtCusto.Text);
                produto.pro_valorvenda = Convert.ToDecimal(txtVenda.Text);
                produto.pro_valorvenda = Convert.ToDecimal(txtVenda.Text);
                produto.for_cod = codFornecedor;
                produto.pro_ref = txtRef.Text;

                contexto.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            }

            contexto.SaveChanges();
            this.Close();
            this.Dispose();         
        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormataMoeda.aceitaNumero(e);
        }

        private void txtCusto_Leave(object sender, EventArgs e)
        {
            FormataMoeda.formatarMoeda(txtCusto);
        }

        private void txtVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormataMoeda.aceitaNumero(e);
        }

        private void txtVenda_Leave(object sender, EventArgs e)
        {
            FormataMoeda.formatarMoeda(txtVenda);
        }

        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            carregaComboBox();
            if (!String.IsNullOrEmpty(this.codigo))
            {

                int cod = Convert.ToInt32(codigo);
                var modelo = contexto.produto.Find(cod);

                txtCusto.Text = modelo.pro_valorpago.ToString();
                txtNome.Text = modelo.pro_nome;
                txtDescricao.Text = modelo.pro_descricao;
                txtRef.Text = modelo.pro_ref;
                txtUndMedida.Text = modelo.umed;
                txtVenda.Text = modelo.pro_valorvenda.ToString();
                txtCod.Text = modelo.pro_cod.ToString();
                cbCategoria.SelectedValue = modelo.cat_cod;
                cbSubCategoria.SelectedValue = modelo.scat_cod;
                cbFornecedor.SelectedValue = modelo.for_cod;
                txtRef.Text = modelo.pro_ref;
                txtlocalizacao.Text = modelo.localizacao;
                //pbImagem.Load(copiaImagem.RetornaCaminhoImagem("58585858"));

            }
        }

        private void cbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {

                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
                cbSubCategoria.DataSource = contexto.subcategoria.ToList();
                int codCategoriaSelecionada = Convert.ToInt32(cbCategoria.SelectedValue);
                cbSubCategoria.DataSource = contexto.subcategoria.Where(s => s.cat_cod == codCategoriaSelecionada).ToList();
                

            }
            catch (Exception)
            { }

        }

        private void txtMargemLucro_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMargemLucro.Text))
            {
                double margem = Convert.ToDouble(txtMargemLucro.Text);
                margem = margem / 100;
                if (String.IsNullOrEmpty(txtCusto.Text))
                {
                    txtCusto.Text = "0";
                }
                double custo = Convert.ToDouble(txtCusto.Text);
                var valorVenda = custo * (1 + margem);
                txtVenda.Text = valorVenda.ToString();


            }

        }

        private void txtMargemLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormataMoeda.aceitaNumero(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMargemLucro.Enabled = true;
            txtMargemLucro.Focus();
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
