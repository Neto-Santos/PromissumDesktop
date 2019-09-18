using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class ModeloMontadora
    {
        public int cod { get; set; }
        public string montadora { get; set; }
        public string abreviatura_montadora { get; set; }
        public DateTime cadastro { get; set; }
    }
}
