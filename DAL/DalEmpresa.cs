using DAL.ModeloInterface;
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
    public class DalEmpresa
    {
        DalConexao conexao;
        public DalEmpresa(DalConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloEmpresa modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into empresa(nome,cpfcnpj,telefone,celular,email,numero,cidade,bairro,estado,cadastro,endereco)" +
                "values (@nome,@cpfcnpj,@telefone,@celular,@email,@numero,@cidade,@bairro,@estado,@cadastro,@endereco) select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.nome);
            cmd.Parameters.AddWithValue("@cpfcnpj", modelo.cpfcnpj);
            cmd.Parameters.AddWithValue("@telefone", modelo.telefone);
            cmd.Parameters.AddWithValue("@celular",modelo.celular);
            cmd.Parameters.AddWithValue("@email", modelo.email);
            cmd.Parameters.AddWithValue("@numero", modelo.numero);
            cmd.Parameters.AddWithValue("@cidade", modelo.cidade);
            cmd.Parameters.AddWithValue("@bairro", modelo.bairro);
            cmd.Parameters.AddWithValue("@estado", modelo.estado);
            cmd.Parameters.AddWithValue("@endereco", modelo.endereco);
            cmd.Parameters.AddWithValue("@cadastro", DateTime.Now);

            try
            {
                conexao.Conectar();
                modelo.cod = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        public void Alterar(ModeloEmpresa modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update empresa set nome = @nome, cpfcnpj = @cpfcnpj,telefone = @telefone,numero =@numero,cidade = @cidade,bairro = @bairro,estado = @estado ,celular =@celular,email = @email,endereco=@endereco  where cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.nome);
            cmd.Parameters.AddWithValue("@cpfcnpj", modelo.cpfcnpj);
            cmd.Parameters.AddWithValue("@telefone", modelo.telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.celular);
            cmd.Parameters.AddWithValue("@email", modelo.email);
            cmd.Parameters.AddWithValue("@numero", modelo.numero);
            cmd.Parameters.AddWithValue("@cidade", modelo.cidade);
            cmd.Parameters.AddWithValue("@bairro", modelo.bairro);
            cmd.Parameters.AddWithValue("@estado", modelo.estado);
            cmd.Parameters.AddWithValue("@endereco", modelo.endereco);


            cmd.Parameters.AddWithValue("@codigo", modelo.cod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete  from empresa where cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from empresa where nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorCodigo(string valor)
        {
            string consulta = string.Format("select * from empresa where cod = {0}", valor);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNome(string valor)
        {

            return Localizar(valor);
        }
        public DataTable LocalizarPorCpfCnpj(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from empresa where cpfcnpj like'%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //Carrega Modelo Pelo Código do empresa
        public ModeloEmpresa CarregaModeloEmpresa(int codigo)
        {
            ModeloEmpresa modelo = new ModeloEmpresa();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from empresa where cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();

                modelo.cod = Convert.ToInt32(registro["cod"]);
                modelo.nome = registro["nome"].ToString();
                modelo.cpfcnpj = registro["cpfcnpj"].ToString();
                modelo.telefone = registro["telefone"].ToString();
                modelo.celular = registro["celular"].ToString();
                modelo.email = registro["email"].ToString();
                modelo.numero = registro["numero"].ToString();
                modelo.cidade = registro["cidade"].ToString();
                modelo.bairro = registro["bairro"].ToString();
                modelo.estado = registro["estado"].ToString();
                modelo.celular = registro["celular"].ToString();
                modelo.endereco = registro["endereco"].ToString();



            }

            return modelo;
        }

        //Carrega Modelo CpfCNPJ do empresa
        public ModeloEmpresa CarregaModeloEmpresa(String cpfcnpj)
        {
            ModeloEmpresa modelo = new ModeloEmpresa();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from empresa where cpfcnpj = @cpfcnpj";
            cmd.Parameters.AddWithValue("@cpfcnpj", cpfcnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.cod = Convert.ToInt32(registro["cod"]);
                modelo.nome = registro["nome"].ToString();
                modelo.cpfcnpj = registro["cpfcnpj"].ToString();
                modelo.telefone = registro["telefone"].ToString();
                modelo.celular = registro["celular"].ToString();
                modelo.email = registro["email"].ToString();
                modelo.numero = registro["numero"].ToString();
                modelo.cidade = registro["cidade"].ToString();
                modelo.bairro = registro["bairro"].ToString();
                modelo.estado = registro["estado"].ToString();
                modelo.celular = registro["celular"].ToString();
                modelo.email = registro["cli_email"].ToString();
            }

            return modelo;
        }
    }
}
