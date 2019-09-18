using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloVenda
    {
      

        public int VenCod { get; set; }
        public DateTime VenData { get; set; }
        public int VenNFiscal { get; set; }
        public double VenTotal { get; set; }
        public int VenNParcelas { get; set; }
        public string VenStatus { get; set; }
        public int CliCod { get; set; }
        public int TpaCod { get; set; }
        public int VenAvista { get; set; }
        public DateTime vendDataEntrada { get; set; }
        public DateTime? venDataSaida { get; set; }
        public DateTime venHoraEntrada { get; set; }
        public DateTime? vendHoraSaida { get; set; }
        public string vendDefeitoApresentado { get; set; }
        public string venServicoEfetuado { get; set; }
        public string venLembrete { get; set; }
        public int venDiasAviso { get; set; }
    }
}
