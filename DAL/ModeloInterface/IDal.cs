using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ModeloInterface
{
    public interface IDal<t> where t : class
    {
        void Incluir(t modelo);
        void Alterar(t modelo);
        void Excluir(int cod);
        DataTable Localizar(string valor);
        t CarregarModelo(int cod);

    }
}
