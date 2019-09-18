using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas
{
    public class FormataMoeda
    {
        public static void formatarMoeda(TextBox txt)
        {
            try
            {
                decimal salario = Convert.ToDecimal(txt.Text);
                txt.Text = salario.ToString("N2");
            }
            catch (Exception)
            {               
            }
          
        }
        public static void aceitaNumero(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                //MessageBox.Show("este campo aceita somente números e virgula", "Parâmetro de Entrada Inválido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public static void aceitaSomenteNumero(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente números", "Parâmetro de Entrada Inválido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

    }
}
