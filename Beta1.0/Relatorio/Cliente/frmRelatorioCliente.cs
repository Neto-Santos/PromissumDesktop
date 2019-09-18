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

namespace Beta1._0.Relatorio.Cliente
{
    public partial class frmRelatorioCliente : Form
    {
        public frmRelatorioCliente(DalConexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }
        public string nome { get; set; }
        public string dataInicial { get; set; }
        public string dataFinal { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string  status { get; set; }
        public string tipoRelatorio { get; set; }
        public string referencia { get; set; }
        public string defeito { get; set; }
        public string servico { get; set; }
        DalConexao conexao;
       

        private void frmRelatorioCliente_Load(object sender, EventArgs e)
        {
            BllCliente bll = new BllCliente(conexao);
            //crCliente crCliente = new crCliente();
            //crClienteSintetico crClienteSintetico = new crClienteSintetico();
            
            //crViewer.ReportSource = null;

            //if (tipoRelatorio == "Analitico")
            //{
            //    crCliente.Database.Tables["dsClienteAnalitico"].SetDataSource(bll.LocalizarRelatorioAnalitico(nome, dataInicial, dataFinal, cidade, estado, status,defeito,servico,referencia));
            //    crViewer.ReportSource = crCliente;
            //}
            //else
            //{
            //    crClienteSintetico.Database.Tables["dsClienteAnalitico"].SetDataSource(bll.LocalizarRelatorioAnalitico(nome, dataInicial, dataFinal, cidade, estado, status, defeito, servico,referencia));
                //crViewer.ReportSource = crClienteSintetico;
            //}
            
        }
    }
}
