using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ferramentas
{
    public class imagemPrincipal
    {
        public static void configurarImagemPrincipal(string imagem, string valor)
        {
            StreamWriter gravar = null;
            try
            {
                gravar = new StreamWriter("imagem.txt", false);
                gravar.WriteLine(imagem);
                gravar.WriteLine(valor);
                gravar.Close();
            }
            catch (Exception)
            {
                
            } 
            
           
        }
        public static string carregaImagemPrincipal(out string valor)
        {
            StreamReader reader = null;
            string endereco = null;
            try
            {
                reader = new StreamReader("imagem.txt");
            }
            catch (Exception)
            {
                endereco = null;
            }

            endereco = reader.ReadLine();
            valor = reader.ReadLine();
            reader.Close();
            return endereco;
        }
    }
}
