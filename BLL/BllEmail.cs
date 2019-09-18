using DAL;
using Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace BLL
{
    public class BllEmail
    {
        public BllEmail(DalConexao conexao)
        {
            this.conexao = conexao;
        }
        DalConexao conexao;

        public void Incluir(ModeloEmail modelo)
        {
            DalEmail dal = new DalEmail(conexao);
            dal.Incluir(modelo);
        }
        public void Alterar(ModeloEmail modelo)
        {
            DalEmail dal = new DalEmail(conexao);
            dal.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DalEmail dal = new DalEmail(conexao);
            dal.Excluir(codigo);
        }
        public ModeloEmail CarregaModeloEmail(int cod )
        {
            DalEmail dal = new DalEmail(conexao);
            return dal.CarregaModeloEmail(cod);
        }
    }
}
