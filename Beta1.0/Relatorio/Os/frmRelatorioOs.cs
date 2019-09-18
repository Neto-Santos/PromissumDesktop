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


namespace Beta1._0.Relatorio.Os
{
    public partial class frmRelatorioOs : Form
    {
        public frmRelatorioOs(DalConexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }
        DalConexao conexao;

        private void frmRelatorioOs_Load(object sender, EventArgs e)
        {
            //    BllVenda bll = new BllVenda(conexao);
            //    crOs crOs = new crOs();

            //    crOs.Database.Tables["dsOs"].SetDataSource(bll.LocalizarTodaVenda(""));
            //    crvOs.ReportSource = null;
            //    crvOs.ReportSource = crOs;
        }
    }
}
