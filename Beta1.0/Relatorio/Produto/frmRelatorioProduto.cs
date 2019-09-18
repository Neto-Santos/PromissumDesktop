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
namespace Beta1._0.Relatorio.Produto
{
    public partial class frmRelatorioProduto : Form
    {
        public frmRelatorioProduto(DalConexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }
        DalConexao conexao;
        public string produto { get; set; }
        public string dtInicio { get; set; }
        public string dtFim { get; set; }
        public string categoria { get; set; }
        public string subCategoria { get; set; }
        public string referencia { get; set; }

        private void frmRelatorioProduto_Load(object sender, EventArgs e)
        {
            BLLProduto bll = new BLLProduto(conexao);

            crViewerProduto.ReportSource = null;
            //crProduto crProduto = new crProduto();
            try
            {
                var tabela = bll.RelatorioProdutoAnalitico(produto, dtInicio, dtFim, categoria, subCategoria, referencia);
                //crProduto.Database.Tables["dsProduto"].SetDataSource(tabela);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

            //crViewerProduto.ReportSource = crProduto;
        }
    }
}
