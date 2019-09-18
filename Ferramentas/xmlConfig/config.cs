using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Ferramentas.xmlConfig
{
    public class config
    {
        #region Region Relacionados a EMAIL
        public string nome { get; set; }
        public string codigo { get; set; }
        public string senha { get; set; }
        public string assunto { get; set; }
        public string corpo { get; set; }
        public string rodape1 { get; set; }
        public string rodape2 { get; set; }
        public string rodape3 { get; set; }

        public static config carregaEmail()
        {
            config objemail = new config();
            try
            {

                var caminho = System.Environment.CurrentDirectory + "\\xmlConfig\\config.xml";

                XDocument doc = XDocument.Load(caminho);

                foreach (XElement x in doc.Element("config").Element("emails").Elements())
                {

                    objemail.codigo = x.Attribute("codigo").Value;
                    objemail.nome = x.Attribute("nome").Value;
                    objemail.senha = x.Attribute("senha").Value;
                    objemail.assunto = x.Attribute("assunto").Value;
                    objemail.corpo = x.Attribute("corpo").Value;
                    objemail.rodape1 = x.Attribute("rodape1").Value;
                    objemail.rodape2 = x.Attribute("rodape2").Value;
                    objemail.rodape3 = x.Attribute("rodape3").Value;

                }

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            return objemail;

        }
        public static void SalvaEmail(string nome, string assunto, string senha, string corpo, string rodape1, string rodape2, string rodape3)
        {

            try
            {

                var caminho = System.Environment.CurrentDirectory + "\\xmlConfig\\config.xml";

                XDocument doc = XDocument.Load(caminho);
                if (doc.Element("config").Element("emails").Elements().Where(e => e.Attribute("codigo").Value.Equals("1")).Count() > 0)
                {
                    XElement ele = doc.Element("config").Element("emails").Elements().Where(x => x.Attribute("codigo").Value.Equals("1")).First();
                    ele.Attribute("nome").SetValue(nome);
                    ele.Attribute("assunto").SetValue(assunto);
                    ele.Attribute("senha").SetValue(senha);
                    ele.Attribute("corpo").SetValue(corpo);
                    ele.Attribute("rodape1").SetValue(rodape1);
                    ele.Attribute("rodape2").SetValue(rodape2);
                    ele.Attribute("rodape3").SetValue(rodape3);

                    doc.Save(caminho);
                }


            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }



        }
       public static void SalvaLogo(string logo)
        {
            try
            {
                var caminho = System.Environment.CurrentDirectory + "\\xmlConfig\\config.xml";

                XDocument doc = XDocument.Load(caminho);
                if (doc.Element("config").Element("logos").Elements().Where(e => e.Attribute("codigo").Value.Equals("3")).Count() > 0)
                {
                    XElement ele = doc.Element("config").Element("logos").Elements().Where(x => x.Attribute("codigo").Value.Equals("3")).First();
                    ele.Attribute("nome").SetValue(logo);         

                    doc.Save(caminho);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
       public static string retornaLogo()
        {
            var retorno = "";
            try
            {

                var caminho = System.Environment.CurrentDirectory + "\\xmlConfig\\config.xml";

                XDocument doc = XDocument.Load(caminho);

                foreach (XElement x in doc.Element("config").Element("logos").Elements())
                {

                   
                   retorno =  x.Attribute("nome").Value;
                   

                }

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return retorno;
        }
        #endregion

        #region Banco de Dados
        public string nomeBanco { get; set; }
        public string senhaBanco { get; set; }
        public string usuarioBanco { get; set; }

        public static config carregaBanco()
        {
            config objBanco = new config();
            try
            {

                var caminho = System.Environment.CurrentDirectory + "\\xmlConfig\\config.xml";

                XDocument doc = XDocument.Load(caminho);

                foreach (XElement x in doc.Element("config").Element("bancos").Elements())
                {
                    objBanco.nomeBanco = x.Attribute("nome").Value;
                    objBanco.senhaBanco = x.Attribute("senha").Value;
                    objBanco.usuarioBanco = x.Attribute("usuario").Value;       
                }

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            return objBanco;

        }
        public static void SalvaBanco(string nome, string usuario, string senha,string segurancaBanco)
        {
            try
            {
                var caminho = System.Environment.CurrentDirectory + "\\xmlConfig\\config.xml";

                XDocument doc = XDocument.Load(caminho);
                if (doc.Element("config").Element("bancos").Elements().Where(e => e.Attribute("codigo").Value.Equals("2")).Count() > 0)
                {
                    XElement ele = doc.Element("config").Element("bancos").Elements().Where(x => x.Attribute("codigo").Value.Equals("2")).First();

                    ele.Attribute("nome").SetValue(nome);
                    ele.Attribute("usuario").SetValue(usuario);
                    ele.Attribute("senha").SetValue(senha);
                    ele.Attribute("seguranca").SetValue(segurancaBanco);
                    doc.Save(caminho);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        #endregion






    }
}
