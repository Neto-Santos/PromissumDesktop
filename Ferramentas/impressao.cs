using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas
{
    public class impressao
    {
        public void CarregarListaDeImpressoras(ComboBox comboBoxImpressora)
        {

            comboBoxImpressora.Items.Clear();

            foreach (var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                comboBoxImpressora.Items.Add(printer);
                comboBoxImpressora.SelectedItem = printer;
            }
        }
    }
}
