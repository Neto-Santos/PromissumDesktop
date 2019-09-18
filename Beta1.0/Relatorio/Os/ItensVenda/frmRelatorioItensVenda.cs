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
using MODELO;

namespace Beta1._0.Relatorio.Os.ItensVenda
{
    public partial class frmRelatorioItensVenda : Form
    {
        public frmRelatorioItensVenda(DalConexao conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }
        public int codVenda { get; set; }

        DalConexao conexao;
        
        private void frmRelatorioItensVenda_Load(object sender, EventArgs e)
        {
            BllVenda bllVenda = new BllVenda(conexao);
            ModeloVenda modeloVenda = new ModeloVenda();
            
            if (codVenda>0)
            {
                modeloVenda = bllVenda.CarregaModeloVenda(codVenda);

                BllCliente bllCliente = new BllCliente(conexao);

                BllItensVenda bllItensVenda = new BllItensVenda(conexao);

                BllEmpresa bllEmpresa = new BllEmpresa(conexao);

                //crItensVenda crItensVenda = new crItensVenda();



                //crItensVenda.Database.Tables["dsOs"].SetDataSource(bllVenda.Localizar(modeloVenda.VenCod.ToString()));
                //crItensVenda.Database.Tables["dsCliente"].SetDataSource(bllCliente.LocalizarPorCodigo(modeloVenda.CliCod.ToString()));
                //crItensVenda.Database.Tables["dsItensVenda"].SetDataSource(bllItensVenda.Localizar(modeloVenda.VenCod));
                //crItensVenda.Database.Tables["dsEmpresa"].SetDataSource(bllEmpresa.LocalizarPorCodigo(1.ToString()));



                crvItensVenda.ReportSource = null;

                //crvItensVenda.ReportSource = crItensVenda;
            }           
        }
    }
}
