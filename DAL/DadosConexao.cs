using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class DadosConexao
    {
        public static string caminho;
        public static String stringConexao
        {
            get
            {
                try
                {
                    string servidor;
                    string banco;
                    string usuario;
                    string senha;
                    string integratedSecurity;
                    var caminho = System.Environment.CurrentDirectory + "\\xmlConfig\\config.xml";

                    XDocument doc = System.Xml.Linq.XDocument.Load(caminho);

                    XElement x = doc.Element("config").Element("bancos").Elements().First();

                    banco = x.Attribute("nome").Value;
                    senha = x.Attribute("senha").Value;
                    usuario = x.Attribute("usuario").Value;
                    servidor = x.Attribute("servidor").Value;
                    integratedSecurity = x.Attribute("seguranca").Value;

                    caminho = string.Format(@"Data Source={0}\SQLEXPRESS;Initial Catalog={1};User Id={2};Password={3};Integrated Security={4}", servidor, banco, usuario, senha, integratedSecurity);

                    return caminho;
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro ao acessar a base de dados " + ex.Message);
                }

               
            }
        }
    }
}
