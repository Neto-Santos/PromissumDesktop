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

namespace BLL
{
    public class BLLSubCategoria:BllAviso
    {
        private DalConexao conexao;

        //Construtor
        public BLLSubCategoria(DalConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloSubCategoria modelo)
        {
            if (modelo.SCatNome.Trim().Length == 0)
            {
                aviso("O nome da SubCategoria é obrigatório"); return;
            }
            else if (modelo.CatCod < 0)
            {
                aviso("O nome da Categoria é obrigatório"); return;
            }
            else
            {
                try
                {
                    DALSubCategoria DALobj = new DALSubCategoria(conexao);
                    DALobj.Incluir(modelo);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
                }

            }      


        }

        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.SCatNome.Trim().Length == 0)
            {
                aviso("O nome da SubCategoria é obrigatório"); return;
            }
            else if (modelo.CatCod <= 0)
            {
                aviso("O nome da Categoria é obrigatório"); return;
            }

            else if (modelo.SCat_Cod <= 0)
            {
                aviso("O código da SubCategoria é obrigatório"); return;
            }
            else
            {
                try
                {
                    DALSubCategoria DALobj = new DALSubCategoria(conexao);

                    DALobj.Alterar(modelo);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
                }

            }
        }

        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                MessageBox.Show("Não há produto selecionado"); return;
            }
            else
            {
                try
                {
                    DALSubCategoria DALobj = new DALSubCategoria(conexao);
                    DALobj.Excluir(codigo);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
                }

            }
           

        }

        public DataTable Localizar(string valor)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {

            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.CarregaModeloSubCategoria(codigo);

        }

        public DataTable LocalizarPorCategoria(int codigo)
        {
            DALSubCategoria dal = new DALSubCategoria(conexao);
            return dal.LocalizarPorCategoria(codigo);
        }
    }
}
