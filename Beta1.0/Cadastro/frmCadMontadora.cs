using Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace Promissum.Cadastro
{
    public partial class frmCadMontadora : Form
    {
        DalConexao conexao;
        public frmCadMontadora()
        {
            InitializeComponent();
           conexao = new DalConexao(DadosConexao.stringConexao);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ModeloMontadora modelo = new ModeloMontadora();
            modelo.abreviatura_montadora = txtSigla.Text;
            modelo.montadora = txtMontadora.Text;

            BllMontadora bll = new BllMontadora(conexao);
            bll.Incluir(modelo);
            
        }
    }
}
