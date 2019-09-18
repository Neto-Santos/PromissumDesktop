using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class copiaImagem
    {
        public static string CopiarParaLocalDoAplicativo(string caminhoImagem,string cpf)
        {
            var caminhoExecutavel = AppDomain.CurrentDomain.BaseDirectory.ToString();
            StreamReader rd = new StreamReader(@caminhoExecutavel+"\\caminhoImagem.txt");
            var destino = rd.ReadLine().ToString();
            System.IO.File.Copy(caminhoImagem, @""+ destino + "\\"+cpf+".jpg",true);
            return cpf + ".jpg";
        }
        public static string RetornaCaminhoImagem(string cpf)
        {
            var caminhoExecutavel = AppDomain.CurrentDomain.BaseDirectory.ToString();
            StreamReader rd = new StreamReader(@caminhoExecutavel + "\\caminhoImagem.txt");
            var destino = rd.ReadLine().ToString();
            return @String.Format(destino+"\\{0}.jpg",cpf);
        }
    }
}
