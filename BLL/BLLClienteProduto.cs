using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class BLLClienteProduto : DAL.ModeloInterface.IDal<ModeloClienteProduto>
    {
        DalConexao conexao;
        public BLLClienteProduto(DalConexao cx)
        {
            this.conexao = cx;
        }

        public void Alterar(ModeloClienteProduto modelo)
        {
            if (modelo.cod != 0 && !String.IsNullOrEmpty(modelo.referencia))
            {
                DAL.ClienteProduto dal = new ClienteProduto(conexao);
                try
                {
                    dal.Alterar(modelo);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado");
                }

            }
        }

        public ModeloClienteProduto CarregarModelo(int cod)
        {
            if (cod != 0)
            {
                DAL.ClienteProduto dal = new ClienteProduto(conexao); 
                return dal.CarregarModelo(cod);
            }
            else
            {
                return null;
            }
        }

        public ModeloClienteProduto CarregarModelo(int codCliente, int codProduto)
        {
            if (codProduto != 0 && codCliente != 0)
            {
                DAL.ClienteProduto dal = new ClienteProduto(conexao);
                return dal.CarregarModelo(codCliente, codProduto); 
            }
            else
            {
                return null;
            }
        }

        public ModeloClienteProduto CarregarModelo(int codCliente, int codProduto, string referencia)
        {
            if (codProduto != 0 && codCliente != 0)
            {
                DAL.ClienteProduto dal = new ClienteProduto(conexao);
                return dal.CarregarModelo(codCliente, codProduto, referencia);
            }
            else
            {
                return null;
            }
        }
        public bool verificaReferencia(string referencia)
        {

            ClienteProduto dal = new ClienteProduto(conexao);
            return dal.verificaReferencia(referencia);

        }
        public void Excluir(int cod)
        {
            if (cod != 0)
            {
                try
                {
                    DAL.ClienteProduto dal = new ClienteProduto(conexao);
                    dal.Excluir(cod);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception)
                {

                    throw;
                }
               
            }
        }
        public DataTable relatorioClienteProdutoAnalitico(string nome, string dtInicio, string dtTermino, string cidade, string estado, string produto,string referencia)
        {
            DAL.ClienteProduto dal = new ClienteProduto(conexao); 
            return dal.relatorioClienteProdutoAnalitico(nome, dtInicio, dtTermino, cidade, estado, produto,referencia);
        }
        public void Incluir(ModeloClienteProduto modelo)
        {
            if (modelo.codCliente > 0 && modelo.codProduto > 0 && modelo.referencia != null)
            {
                try
                {
                    DAL.ClienteProduto dal = new ClienteProduto(conexao);
                    dal.Incluir(modelo);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception)
                {

                    throw;
                }
           
            }
        }

        public DataTable Localizar(string valor)
        {
            DAL.ClienteProduto dal = new ClienteProduto(conexao); 
            return dal.Localizar(valor); 
        }

        public DataTable LocalizarTodoClienteProduto()
        {
            DAL.ClienteProduto dal = new ClienteProduto(conexao);
            return dal.LocalizarTodoClienteProduto(); 
        }

        public DataTable LocalizarClienteProdutoCodProduto(string codCliente,string codProduto)
        {
            try
            {
                DAL.ClienteProduto dal = new ClienteProduto(conexao);
                return dal.LocalizarClienteProdutoCodProduto(codCliente, codProduto);
            }
            catch (Exception)
            {

                throw;
            }
          
        }
        public DataTable LocalizarClienteProdutoNome(string codCliente, string nome)
        {
            try
            {
                DAL.ClienteProduto dal = new ClienteProduto(conexao);
                return dal.LocalizarClienteProdutoNome(codCliente, nome);
            }
            catch (Exception)
            {

                throw;
            }
          
        }
        public DataTable LocalizarClienteProdutoReferencia(string codCliente, string referencia)
        {
            try
            {
                DAL.ClienteProduto dal = new ClienteProduto(conexao);
                return dal.LocalizarClienteProdutoReferencia(codCliente, referencia);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
