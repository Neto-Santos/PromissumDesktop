using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace Beta1._0.Relatorio.Fornecedor
{
    public partial class frmRelatorioFornecedor : Form
    {
        public frmRelatorioFornecedor(DalConexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }
        DalConexao conexao;
        public string fornecedor { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cpf { get; set; }
        public string cnpj { get; set; }
        public string cadastroInicio { get; set; }
        public string cadastroTermino { get; set; }
        public string produto { get; set; }
        public string TipoRelatorio { get; set; }


        private void frmRelatorioFornecedor_Load(object sender, EventArgs e)
        {
            BLLFornecedor bll = new BLLFornecedor(conexao);
                 
            crvFornecedor.ReportSource = null;

            if (TipoRelatorio == "Analitico")
            {
                //crFornecedorAnalitico cr = new crFornecedorAnalitico();
                //cr.Database.Tables["dsFornecedor"].SetDataSource(bll.RelatorioFornecedor(fornecedor, cidade, estado, cpf, cnpj, cadastroInicio, cadastroTermino, produto));
                //crvFornecedor.ReportSource = cr;
            }
            else
            {
                //    crFornecedorSintetico cr = new crFornecedorSintetico();
                //    cr.Database.Tables["dsFornecedor"].SetDataSource(bll.RelatorioFornecedor(fornecedor,cidade,estado,cpf,cnpj,cadastroInicio,cadastroTermino));
                //    crvFornecedor.ReportSource = cr;
            }
        }
    }
}
