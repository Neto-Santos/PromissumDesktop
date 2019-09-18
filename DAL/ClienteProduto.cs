using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.ModeloInterface;
using System.Data.SqlClient;
using Entidade;

namespace DAL
{
    public class ClienteProduto : IDal<Entidade.ModeloClienteProduto>
    {
        DalConexao conexao;
        public ClienteProduto(DalConexao conexao)
        {
            this.conexao = conexao;
        }
        public void Alterar(ModeloClienteProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;

                cmd.CommandText = "update ClienteProduto set codCliente = @codCliente,codProduto = @codProduto, referencia=@referencia where cod = @cod";
                cmd.Parameters.AddWithValue("@codCliente", modelo.codCliente);
                cmd.Parameters.AddWithValue("@codProduto", modelo.codProduto);
                cmd.Parameters.AddWithValue("@referencia", modelo.referencia);
                cmd.Parameters.AddWithValue("@cod", modelo.cod);
                //cmd.Parameters.AddWithValue("@cod_clienteProduto", modelo.cod_clienteProduto);

                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Excluir(int cod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from ClienteProduto where cod = @cod";
                cmd.Parameters.AddWithValue("@cod", cod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Incluir(ModeloClienteProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into ClienteProduto(codCliente,CodProduto,referencia) values (@codCliente,@CodProduto,@referencia) select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@codCliente", modelo.codCliente);
                cmd.Parameters.AddWithValue("@CodProduto", modelo.codProduto);
                cmd.Parameters.AddWithValue("@referencia", modelo.referencia);
                //cmd.Parameters.AddWithValue("@cod_clienteProduto", modelo.cod_clienteProduto);
                conexao.Conectar();
                modelo.cod = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public bool verificaReferencia(string referencia)
        {
            var retorno = true;

            string consulta = string.Format("select * from ClienteProduto where referencia = '{0}'", referencia);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = consulta;

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            retorno = registro.HasRows;

            conexao.Desconectar();

            return retorno;
        }

        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from ClienteProduto", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloClienteProduto CarregarModelo(int cod)
        {

            ModeloClienteProduto modelo = new ModeloClienteProduto();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from ClienteProduto where cod = @cod";
            cmd.Parameters.AddWithValue("@cod", cod);
            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.codCliente = Convert.ToInt32(registro["codCliente"]);
                modelo.codProduto = Convert.ToInt32(registro["codProduto"]);
                modelo.referencia = Convert.ToString(registro["referencia"]);
                modelo.cod = Convert.ToInt32(registro["cod"]);
                modelo.cod_clienteProduto = Convert.ToInt32(registro["cod_clienteProduto"]);
            }
            conexao.Desconectar();
            return modelo;
        }
        public ModeloClienteProduto CarregarModelo(int codCliente, int codProduto)
        {
            string consulta = String.Format("select * from ClienteProduto where codCliente = {0} and codProduto = {1} }", codCliente, codProduto);
            ModeloClienteProduto modelo = new ModeloClienteProduto();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = consulta;

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.codCliente = Convert.ToInt32(registro["codCliente"]);
                modelo.codProduto = Convert.ToInt32(registro["codProduto"]);
                modelo.referencia = Convert.ToString(registro["referencia"]);
                modelo.cod = Convert.ToInt32(registro["cod"]);
                //modelo.cod_clienteProduto = Convert.ToInt32(registro["cod_clienteProduto"]);
            }
            conexao.Desconectar();
            return modelo;
        }
        public ModeloClienteProduto CarregarModelo(int codCliente, int codProduto, string referencia)
        {
            string consulta = String.Format("select * from ClienteProduto where codCliente = {0} and codProduto = {1} and referencia = '{2}'", codCliente, codProduto, referencia);
            ModeloClienteProduto modelo = new ModeloClienteProduto();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = consulta;

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.codCliente = Convert.ToInt32(registro["codCliente"]);
                modelo.codProduto = Convert.ToInt32(registro["codProduto"]);
                modelo.referencia = Convert.ToString(registro["referencia"]);
                modelo.cod = Convert.ToInt32(registro["cod"]);
                //modelo.cod_clienteProduto = Convert.ToInt32(registro["cod_clienteProduto"]);
            }
            conexao.Desconectar();
            return modelo;
        }
        public DataTable Localizar(string valor)
        {
            string consulta;
            DataTable tabela = new DataTable();
            if (!String.IsNullOrEmpty(valor))
            {
                consulta = String.Format("SELECT     ClienteProduto.cod,ClienteProduto.codProduto,ClienteProduto.codCliente, cliente.cli_nome, produto.pro_nome, ClienteProduto.referencia, categoria.cat_nome, subcategoria.scat_nome FROM         ClienteProduto INNER JOIN cliente ON ClienteProduto.codCliente = cliente.cli_cod INNER JOIN  produto ON ClienteProduto.codProduto = produto.pro_cod INNER JOIN categoria ON produto.cat_cod = categoria.cat_cod INNER JOIN subcategoria ON produto.scat_cod = subcategoria.scat_cod WHERE     (ClienteProduto.codCliente = {0})", valor);
            }
            else
            {
                consulta = null;
            }

            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorReferencia(string valor)
        {
            string consulta;
            DataTable tabela = new DataTable();
            if (!String.IsNullOrEmpty(valor))
            {
                consulta = String.Format("SELECT     ClienteProduto.cod,ClienteProduto.codProduto,ClienteProduto.codCliente, cliente.cli_nome, produto.pro_nome, ClienteProduto.referencia, categoria.cat_nome, subcategoria.scat_nome FROM         ClienteProduto INNER JOIN cliente ON ClienteProduto.codCliente = cliente.cli_cod INNER JOIN  produto ON ClienteProduto.codProduto = produto.pro_cod INNER JOIN categoria ON produto.cat_cod = categoria.cat_cod INNER JOIN subcategoria ON produto.scat_cod = subcategoria.scat_cod WHERE     (referencia like '%{0}%')", valor);
            }
            else
            {
                consulta = null;
            }

            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //public DataTable Localizar(string codigoCliente)
        //{
        //    string consulta;
        //    DataTable tabela = new DataTable();
        //    if (!String.IsNullOrEmpty(codigoCliente))
        //    {
        //        consulta = string.Format("SELECT cod, codCliente, codProduto as Codigo, referencia FROM         ClienteProduto WHERE     (codCliente = {0})", codigoCliente);
        //    }
        //    else
        //    {
        //        consulta = null;
        //    }

        //    SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
        //    da.Fill(tabela);
        //    return tabela;
        //}


        public DataTable relatorioClienteProdutoAnalitico(string nome, string dtInicio, string dtTermino, string cidade, string estado, string produto,string referencia)
        {
            string consulta;
            DataTable tabela = new DataTable();

            consulta = string.Format(" SELECT[cli_cod] as Codigo " +
      ",[cli_nome] as Nome " +
       ",[cli_cpfcnpj] as CpfCnpj " +
      " ,[cli_fone] as Fone " +
      " ,[cli_cel] as Cel " +
      " ,[cli_email] as Email " +
      " , ClienteProduto.referencia as Referencia " +
      " , produto.pro_nome as Produto " +
  " from cliente " +
       "  inner join ClienteProduto on cli_cod = ClienteProduto.codCliente " +
      "   inner join produto on ClienteProduto.codProduto = produto.pro_cod " +
      "  where cli_nome like '%{0}%' and cli_cadastro between '{1}' and '{2}' and cli_cidade like '%{3}%' and cli_estado like '%{4}%' and produto.pro_nome like '%{5}%' and ClienteProduto.referencia like'%{6}%' order by cli_nome", nome, dtInicio, dtTermino, cidade, estado, produto,referencia);


            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarTodoClienteProduto()
        {
            string consulta;
            DataTable tabela = new DataTable();

            consulta = string.Format("SELECT ClienteProduto.cod, produto.pro_cod as Codigo , produto.pro_nome as Descrição " +
     "   ,[referencia], produto.pro_valorpago as Custo, produto.pro_valorvenda as Venda " +
    "    , categoria.cat_nome as Categoria, subcategoria.scat_nome as SubCategoria" +
   " from ClienteProduto " +
   "inner join produto on codProduto = produto.pro_cod " +
  " inner join categoria on produto.cat_cod = categoria.cat_cod " +
   "inner join subcategoria on produto.scat_cod = subcategoria.scat_cod ");


            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarClienteProdutoCodProduto(string codCliente,string codProduto)
        {
            try
            {
                string consulta;
                DataTable tabela = new DataTable();

                consulta = string.Format("SELECT ClienteProduto.cod,ClienteProduto.codCliente as codigoCliente, produto.pro_cod as Codigo , produto.pro_nome as Descrição " +
         "   ,[referencia], produto.pro_valorpago as Custo, produto.pro_valorvenda as Venda " +
        "    , categoria.cat_nome as Categoria, subcategoria.scat_nome as SubCategoria" +
       " from ClienteProduto " +
       "inner join produto on codProduto = produto.pro_cod " +
      " inner join categoria on produto.cat_cod = categoria.cat_cod " +
       "inner join subcategoria on produto.scat_cod = subcategoria.scat_cod where ClienteProduto.codCliente = {0} and produto.pro_cod = {1} ", codCliente, codProduto);


                SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
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
                string consulta;
                DataTable tabela = new DataTable();

                consulta = string.Format("SELECT ClienteProduto.cod,ClienteProduto.codCliente as codigoCliente, produto.pro_cod as Codigo , produto.pro_nome as Descrição " +
         "   ,[referencia], produto.pro_valorpago as Custo, produto.pro_valorvenda as Venda " +
        "    , categoria.cat_nome as Categoria, subcategoria.scat_nome as SubCategoria" +
       " from ClienteProduto " +
       "inner join produto on codProduto = produto.pro_cod " +
      " inner join categoria on produto.cat_cod = categoria.cat_cod " +
       "inner join subcategoria on produto.scat_cod = subcategoria.scat_cod where ClienteProduto.codCliente = {0} and referencia like '%{1}%' ", codCliente, referencia);


                SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
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
                string consulta;
                DataTable tabela = new DataTable();

                consulta = string.Format("SELECT ClienteProduto.cod,ClienteProduto.codCliente as codigoCliente, produto.pro_cod as Codigo , produto.pro_nome as Descrição " +
         "   ,[referencia], produto.pro_valorpago as Custo, produto.pro_valorvenda as Venda " +
        "    , categoria.cat_nome as Categoria, subcategoria.scat_nome as SubCategoria" +
       " from ClienteProduto " +
       "inner join produto on codProduto = produto.pro_cod " +
      " inner join categoria on produto.cat_cod = categoria.cat_cod " +
       "inner join subcategoria on produto.scat_cod = subcategoria.scat_cod where ClienteProduto.codCliente = {0} and produto.pro_nome like '%{1}%' ", codCliente, nome);


                SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception)
            {

                throw;
            }
       
        }


    }
}
