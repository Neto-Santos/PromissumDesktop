using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAL.DataSetOperacao.dsOperacaoTableAdapters;

namespace BLL
{
    public class BllOperacao
    {
        private DalConexao conexao;

        //Construtor
        public BllOperacao(DalConexao cx)

        {
            this.conexao = cx;
        }
        public void Incluir(ModeloOperacao modelo)
        {
            if (modelo.op_nome.Trim().Length == 0)
            {
                MessageBox.Show("O nome da Operação é obrigatório");
            }
            else
            {
                try
                {
                    DalOperacao DALobj = new DalOperacao(conexao);

                    DALobj.Incluir(modelo);

                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado");
                }

            }


        }

        public void Alterar(ModeloOperacao modelo)
        {
            if (modelo.op_nome.Trim().Length == 0)
            {
                MessageBox.Show("O nome da Operação é obrigatório");
            }
            else
            {
                try
                {
                    DalOperacao DALobj = new DalOperacao(conexao);

                    DALobj.Alterar(modelo);
                    
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado");
                }

            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                DalOperacao DALobj = new DalOperacao(conexao);
                DALobj.Excluir(codigo);

                
                BllAviso.aviso("Operação realizada com sucesso!!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado");
            }

        }

        public DataTable Localizar(string valor)
        {
            DalOperacao DALobj = new DalOperacao(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable Localizar()
        {
            DalOperacao DALobj = new DalOperacao(conexao);
            return DALobj.Localizar();
        }

        public ModeloOperacao CarregaModeloOperacao(int codigo)
        {

            DalOperacao DALobj = new DalOperacao(conexao);
            return DALobj.CarregaModeloOperacao(codigo);

        }

    }
}
