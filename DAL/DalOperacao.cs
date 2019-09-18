using Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalOperacao
    {
        private DalConexao conexao;

        
        public DalOperacao(DalConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloOperacao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into operacao(op_nome,op_descricao,op_cadastro) values (@op_nome,@op_descricao,@op_cadastro) select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@op_nome", modelo.op_nome);
                cmd.Parameters.AddWithValue("@op_descricao", modelo.op_descricao);
                cmd.Parameters.AddWithValue("@op_cadastro", DateTime.Now);
                conexao.Conectar();
                modelo.op_cod = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Alterar(ModeloOperacao modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update operacao set op_nome = @op_nome,op_descricao = @op_descricao where op_cod = @op_cod";
                cmd.Parameters.AddWithValue("@op_nome", modelo.op_nome);
                cmd.Parameters.AddWithValue("@op_descricao", modelo.op_descricao);
                cmd.Parameters.AddWithValue("@op_cod", modelo.op_cod);

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
                cmd.CommandText = "delete from operacao where op_cod = @codigo";
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
            var consulta = String.Format("select op_cod as Codigo,op_nome as Operacao from operacao where op_cod = {0}",valor);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable Localizar()
        {
            var consulta = String.Format("select op_cod as Codigo,op_nome as Operacao from operacao");
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloOperacao CarregaModeloOperacao(int codigo)
        {
            ModeloOperacao modelo = new ModeloOperacao();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from operacao where op_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.op_cod = Convert.ToInt32(registro["op_cod"]);
                modelo.op_nome = registro["op_nome"].ToString();
                modelo.op_descricao = registro["op_descricao"].ToString();
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
