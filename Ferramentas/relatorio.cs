using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas
{
   public class relatorio
    {
        public static void exportarRelatorio(LocalReport relatorio, string formato)
        {
            var bytes = relatorio.Render(formato);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
            if (!String.IsNullOrEmpty(saveFile.FileName))
            {
                try
                {
                    System.IO.File.WriteAllBytes(saveFile.FileName + ".PDF", bytes);
                    MessageBox.Show("Arquivo gerado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            
        }
    }
}
