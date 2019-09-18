using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas
{
    public class Mascaras
    {
        public static void Formatar(string Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case "CPF":
                    txtTexto.MaxLength = 14;
                    if (txtTexto.TextLength == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.TextLength == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.TextLength == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;

                case "CNPJ":
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;

                case "CEP":
                    txtTexto.MaxLength = 9;
                    if (txtTexto.Text.Length == 5)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }

                    break;

                case "FONE":
                    txtTexto.MaxLength = 12;
                    if (txtTexto.Text.Length == 2)
                    {
                        txtTexto.Text = txtTexto.Text + " ";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }

                    break;

                case "CEL":
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 2)
                    {
                        txtTexto.Text = txtTexto.Text + " ";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    if (txtTexto.Text.Length == 4)
                    {
                        txtTexto.Text = txtTexto.Text + " ";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    if (txtTexto.Text.Length == 9)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }

                    break;

                case "PLACA":
                    txtTexto.MaxLength = 8;
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }

                    break;

            }
        }
    }
}
