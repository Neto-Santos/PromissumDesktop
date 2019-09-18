using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Ferramentas
{
    public class Formulario
    {
       //Fecha todos os formulário que sejam filhos do formulário pai.
        public static void MudaCorFundoFormularioMDI(Form formularioPai)
        {

            MdiClient ctlMDI;
            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in formularioPai.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = formularioPai.BackColor;
                }
                catch (InvalidCastException) 
                {
                    // Catch and ignore the error if casting failed.
                }
            }

            // Display a child form to show this is still an MDI application.
        }
        public static void limpaCampos(Form frm)
        {
            foreach (var item in frm.Controls)
            {
                if (object.ReferenceEquals(item.GetType(), typeof(TextBox)))
                {
                    var txt = (TextBox)item;
                    txt.Clear();
                }
                if (object.ReferenceEquals(item.GetType(), typeof(MaskedTextBox)))
                {
                    var txt = (MaskedTextBox)item;
                    txt.Clear();
                }
            }
        }

    }
}
