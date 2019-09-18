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


namespace Beta1._0.Relatorio.Categoria
{
    public partial class frmRelatorioCategoria : Form
    {
        public frmRelatorioCategoria(DalConexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }
        DalConexao conexao;
        public string categoria { get; set; }
        public string produto { get; set; }
        public string dtInicio { get; set; }
        public string dtFim { get; set; }
        public string tipoRelatorio { get; set; }
        public string subCategoria { get; set; }
        private void frmRelatorioCategoria_Load(object sender, EventArgs e)
        {

            BLLCategoria bll = new BLLCategoria(conexao);
           
           
            if (tipoRelatorio =="Sintetico")
            {
                //    crCategoria crCategoria = new crCategoria();
                //    crCategoria.Database.Tables["dsCategoria"].SetDataSource(bll.RelatorioCategoria(categoria, dtInicio, dtFim, produto,subCategoria));
                //    crvCategoria.ReportSource = null;
                //    crvCategoria.ReportSource = crCategoria;
            }
            else
            {
                //crCategoriaAnalitico crCategoriaAnalitico = new crCategoriaAnalitico();
                //crCategoriaAnalitico.Database.Tables["dsCategoria"].SetDataSource(bll.RelatorioCategoria(categoria, dtInicio, dtFim, produto, subCategoria));
                //crvCategoria.ReportSource = null;
                //crvCategoria.ReportSource = crCategoriaAnalitico;
            }
            
        }
    }
}
