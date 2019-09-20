using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Promissum.Relatorio_Atualizado.Categoria;
using Beta1._0.Relatorio_Atualizado.Categoria;

namespace Promissum.Relatorio_Atualizado.Categoria
{
    public partial class frmFiltraSubCategoria : Form
    {
        public frmFiltraSubCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRelatorioCategoria frm = new frmRelatorioCategoria();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
