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


namespace Beta1._0.Relatorio.SubCategoria
{
    public partial class frmRelatorioSubCategoria : Form
    {
        public frmRelatorioSubCategoria(DalConexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }
        DalConexao conexao;
        private void frmRelatorioSubCategoria_Load(object sender, EventArgs e)
        {
            BLLSubCategoria bll = new BLLSubCategoria(conexao);
            //crSubCategoria crSubCategora = new crSubCategoria();

            //crSubCategora.Database.Tables["dsSubCategoria"].SetDataSource(bll.Localizar(""));
            //crvSubCategoria.ReportSource = null;
            //crvSubCategoria.ReportSource = crSubCategora;
        }
    }
}
