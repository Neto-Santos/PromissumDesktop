using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class ModeloEmpresa
    {
        public int cod { get; set; }
        public string nome { get; set; }
        public string cpfcnpj { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string numero { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string estado { get; set; }
        public DateTime cadastro { get; set; }
        public string  endereco { get; set; }
    }
}
