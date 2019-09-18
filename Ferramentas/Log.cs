using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class Log
    {
        public static void logOrcamento(string Message,string numOrcamento)
        {
            //Cria o caminho
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\LogOrcamento";

            if (!Directory.Exists(path))
            {
                //Cria a pasta
                Directory.CreateDirectory(path);
            }

            //Cria o endereço do arquivo .txt
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\LogOrcamento\\" + numOrcamento+ ".txt";

            if (!File.Exists(filepath))
            {
                //Cria o arquivo .txt  
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    //Escreve no arquivo .txt
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    //Escreve no arquivo .txt
                    sw.WriteLine(Message);
                }
            }
        }
       
        public static void Erro(string Message)
        {
            //Cria o caminho
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\LogErro";

            if (!Directory.Exists(path))
            {
                //Cria a pasta
                Directory.CreateDirectory(path);
            }

            //Cria o endereço do arquivo .txt
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\LogErro\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";

            if (!File.Exists(filepath))
            {
                //Cria o arquivo .txt  
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    //Escreve no arquivo .txt
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    //Escreve no arquivo .txt
                    sw.WriteLine(Message);
                }
            }
        }
    }
}
