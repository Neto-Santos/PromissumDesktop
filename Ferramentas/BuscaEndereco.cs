using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas
{
    public class BuscaEndereco
    {
        static public String cep = "";
        static public String cidade = "";
        static public String estado = "";
        static public String endereco = "";
        static public String bairro = "";
        static public string tipo_logradouro = "";
        public static  Boolean verificaCEP(String CEP)
        {
            bool flag = false;
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP);
                ds.ReadXml(xml);
                endereco = ds.Tables[0].Rows[0]["logradouro"].ToString();
                bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                estado = ds.Tables[0].Rows[0]["uf"].ToString();
                cep = CEP;
                tipo_logradouro = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString();
                flag = true;
            }
            catch (Exception)
            {                
                 MessageBox.Show("Não foi possível encontrar o endereço pelo cep informado.\nVerifique a veracidade do mesmo ou se sua conexão com a internet está desativada");
            }
            return flag;
        }
    }
}
