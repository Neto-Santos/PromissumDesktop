using DAL;
using Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace BLL
{
    public class BllMontadora
    {
        DalConexao conexao;
        public BllMontadora(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        public void Incluir(ModeloMontadora modelo)
        {
            DalMontadora dal = new DalMontadora(conexao);
            int retorno = dal.Incluir(modelo);
            if (retorno > 0)
            {
                BllAviso.aviso("Operação Realizada com Sucesso!!!");
            }
        }
    }
}
