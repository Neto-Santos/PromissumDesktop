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
namespace Beta1._0.Relatorio.Produto.ClienteProduto
{
    public partial class frmRelatorioClienteProduto : Form
    {
        public frmRelatorioClienteProduto(DalConexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }
        DalConexao conexao;
        public string nome { get; set; }
        public string dtInicio { get; set; }
        public string dtTermino { get; set; }
        public string cidade { get; set; }
        public string referencia { get; set; }
        public string estado { get; set; }
        public string produto { get; set; }
        
        private void frmRelatorioClienteProduto_Load(object sender, EventArgs e)
        {
            BLLClienteProduto bllclienteProduto = new BLLClienteProduto(conexao);
          
            crvClienteProduto.ReportSource = null;

            //crClienteProduto crClienteProduto = new crClienteProduto();

            //crClienteProduto.Database.Tables["dsClienteProduto"].SetDataSource(bllclienteProduto.relatorioClienteProdutoAnalitico(nome,dtInicio,dtTermino,cidade,estado,produto,referencia));

            //crvClienteProduto.ReportSource = crClienteProduto;
        }
    }
}
