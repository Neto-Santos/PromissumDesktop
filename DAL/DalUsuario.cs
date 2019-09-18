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
    public class DalUsuario
    {

        public DalConexao conexao { get; set; }
        public DalUsuario(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        public void Incluir(ModeloUsuario modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into usuario(usu_nome,usu_senha,usu_cadastro) values (@usu_nome,@usu_senha,@usu_cadastro) select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@usu_nome", modelo.usu_nome);
                cmd.Parameters.AddWithValue("@usu_senha", modelo.usu_senha);
                cmd.Parameters.AddWithValue("@usu_cadastro", DateTime.Now);
                conexao.Conectar();
                modelo.usu_cod = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception)
            {

            }


        }

        public void Alterar(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update usuario set usu_nome = @usu_nome usu_senha = @usu_senha where usu_cod = @codigo";
            cmd.Parameters.AddWithValue("@usu_nome", modelo.usu_nome);
            cmd.Parameters.AddWithValue("@usu_senha", modelo.usu_senha);
            cmd.Parameters.AddWithValue("@codigo", modelo.usu_cod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete  from usuario where usu_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select usu_cod as Codigo,usu_nome as usuario, usu_cadastro as Cadastro from usuario where usu_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public bool VerificaUsuario(string login,string senha)
        {
            var retorno = false;
            string consulta = String.Format("select * from usuario where usu_nome = '{0}' and usu_senha = '{1}'", login, senha);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            if (tabela.Rows.Count > 0)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool VerficaLoginCadastrado(string login)
        {
            var retorno = false;
            string consulta = String.Format("select * from usuario where usu_nome = '{0}'",login);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            if (tabela.Rows.Count > 0)
            {
                retorno = true;
            }
            return retorno;
        }

        //public DataTable Relatoriousuario(string usuario, string dtInicio, string dtFim, string produto, string subusuario)
        //{
        //    string consulta = String.Format("", usuario, dtInicio, dtFim, produto, subusuario);

        //    DataTable tabela = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
        //    da.Fill(tabela);
        //    return tabela;
        //}

        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where usu_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.usu_cod = Convert.ToInt32(registro["usu_cod"]);
                modelo.usu_nome = registro["usu_nome"].ToString();
                modelo.usu_senha = registro["usu_senha"].ToString();
            }

            return modelo;
        }
    }
}
