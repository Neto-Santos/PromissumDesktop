using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class DALSubCategoria
    {
        private DalConexao conexao;

        //Isto é um construtor
        public DALSubCategoria(DalConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into subCategoria(scat_nome,cat_cod,scat_cadastro) values (@nome,@cat_cod,@scat_cadastro) select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.SCatNome);
                cmd.Parameters.AddWithValue("@cat_cod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@scat_cadastro", DateTime.Now);
                conexao.Conectar();
                modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Alterar(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update subcategoria set scat_nome = @nome,cat_cod = @catcod where scat_cod = @scat_cod";
                cmd.Parameters.AddWithValue("@nome", modelo.SCatNome);
                cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@scat_cod", modelo.SCat_Cod);

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

        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from subcategoria where scat_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
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

        public DataTable Localizar(string valor)
        {

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select sc.scat_cod as CodigoSubCategoria,sc.scat_nome as SubCategoria,c.cat_nome as Categoria from subcategoria sc inner join categoria c on sc.cat_cod = c.cat_cod where scat_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorCategoria(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select sc.scat_cod as CodigoSubCategoria,sc.scat_nome as SubCategoria,c.cat_nome as Categoria from subcategoria sc inner join categoria c on sc.cat_cod = c.cat_cod where sc.cat_cod = " + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            ModeloSubCategoria modelo = new ModeloSubCategoria();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from subcategoria where scat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.SCat_Cod = Convert.ToInt32(registro["scat_cod"]);
                modelo.SCatNome = registro["scat_nome"].ToString();
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }



    }
}


