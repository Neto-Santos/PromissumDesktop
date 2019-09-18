using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
   public class ModeloUsuario
    {
        public int usu_cod { get; set; }
        public string usu_nome { get; set; }
        public string usu_senha { get; set; }
        public DateTime usu_cadastro { get; set; }
    }
}
