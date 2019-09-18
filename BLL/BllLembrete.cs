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
    public class BllLembrete
    {
        DalConexao conexao;
        public BllLembrete(DalConexao conexao)
        {
            this.conexao = conexao;
        }
        public void Alterar(int codigoLembrete, int diasAviso, string mensagemAviso, string tituloAViso)
        {
            DalLembrete dal = new DalLembrete(this.conexao);
            try
            {

                dal.Alterar(codigoLembrete, diasAviso, mensagemAviso, tituloAViso);
                BllAviso.aviso("Lembrete alterado com sucesso!!!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ModeloLembrete retornaLembrete()
        {
            DalLembrete dal = new DalLembrete(this.conexao);
            try
            {
                return dal.retornaLembrete();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
