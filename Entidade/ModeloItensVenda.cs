using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloItensVenda
    {
        public int itvCod { get; set; }
        public Double itvValor { get; set; }
        public double itvQtde { get; set; }
        public int VenCod { get; set; }
        public int cp_cod { get; set; }
        public string referencia { get; set; }
        public double itvValorBase { get; set; }
        public double itvDesconto { get; set; }
        public int op_cod { get; set; }
    }
}
