using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Promissum.NFS_e
{
    public class nfse
    {
        //******************************************************************************************************
        //
        //          Importação de funções externas
        //
        //******************************************************************************************************        

        //Carga de Dlls
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
        private static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
        //Declaração de variáveis do componente spdNFSeX        
        public NFSeX.spdNFSeX NFSe;
        public NFSeX.spdProxyNFSeX ProxyNFSe;
        public NFSeConverterX.spdNFSeConverterX NFSeConverter;
        public NFSeConverterX.IspdRetEnvioNFSe RetEnvio;
        public NFSeConverterX.IspdRetConsultaLoteNFSe RetConsLote;
        public NFSeConverterX.IspdRetEnvioSincronoNFSe RetEnvioSincrono;
        public NFSeConverterX.IspdRetConsultaNFSe RetConsNFSe;
        public NFSeConverterX.IspdRetCancelaNFSe RetCancelamento;
        public NFSeDataSetX.IspdNFSeDataSetX NfseDataSet;

        //Caminho para o arquivo de configuração
        public string ArqIni;

        /* Passos para gerar uma nota fiscal de serviço eletrônica
         * 1 - Editar ou configurar o arquivo ini
         * 
         * 
         * 
         * 
         **/

        public nfse()
        {
            NFSe = new NFSeX.spdNFSeX();
            ProxyNFSe = new NFSeX.spdProxyNFSeX();
            NFSeConverter = new NFSeConverterX.spdNFSeConverterX();
            ProxyNFSe.ComponenteNFSe = NFSe;
            RetEnvio = new NFSeConverterX.spdRetEnvioNFSe();
            RetConsLote = new NFSeConverterX.spdRetConsultaLoteNFSe();
            RetEnvioSincrono = new NFSeConverterX.spdRetEnvioSincronoNFSe();
            RetConsNFSe = new NFSeConverterX.spdRetConsultaNFSe();
            RetCancelamento = new NFSeConverterX.spdRetCancelaNFSe();
            NfseDataSet = new NFSeDataSetX.spdNFSeDataSetX();
            //UTF8Encoding = new UTF8Encoding();   
        }
    }
}
