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
    public class DalCliente
    {
        //Construtor

        DalConexao conexao;
        public DalCliente(DalConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into cliente(cli_nome,cli_cpfcnpj,cli_rgie,cli_rsocial,cli_tipo,cli_cep,cli_endereco,cli_bairro,cli_fone,cli_cel,cli_email,cli_endnumero,cli_cidade,cli_estado,cli_observacao,cli_cadastro)" +
                "values (@nome,@cpfcnpj,@rgie,@rsocial,@tipo,@cep,@endereco,@bairro,@fone,@cel,@email,@endnumero,@cidade,@estado,@cli_observacao,@cli_cadastro) select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.CliNome);
            cmd.Parameters.AddWithValue("@cpfcnpj", modelo.CliCpfCnpj);
            cmd.Parameters.AddWithValue("@rgie", modelo.Clirgie);
            cmd.Parameters.AddWithValue("@rsocial", "");
            cmd.Parameters.AddWithValue("@tipo", modelo.CliTipo);
            cmd.Parameters.AddWithValue("@cep", modelo.CliCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.CliEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.CliBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.CliFone);
            cmd.Parameters.AddWithValue("@cel", modelo.CliCel);
            cmd.Parameters.AddWithValue("@email", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@endnumero", modelo.CliEndnumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.CliEstado);
            cmd.Parameters.AddWithValue("@cli_observacao", modelo.cli_observacao);
            cmd.Parameters.AddWithValue("@cli_cadastro", DateTime.Now);

            conexao.Conectar();
            modelo.CliCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

        }

        public void Alterar(ModeloCliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update cliente set cli_nome = @nome, cli_cpfcnpj = @cpfcnpj,cli_rgie = @rgie,cli_rsocial = @rsocial,cli_tipo = @tipo, cli_cep =@cep,cli_endereco = @endereco,cli_bairro = @bairro,cli_fone = @fone ,cli_cel =@cel,cli_email = @email, cli_endnumero = @endnumero, cli_cidade = @cidade,cli_estado = @estado,cli_observacao=@cli_observacao  where cli_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.CliNome);
            cmd.Parameters.AddWithValue("@cpfcnpj", modelo.CliCpfCnpj);
            cmd.Parameters.AddWithValue("@rgie", modelo.Clirgie);
            cmd.Parameters.AddWithValue("@rsocial", "");
            cmd.Parameters.AddWithValue("@tipo", modelo.CliTipo);
            cmd.Parameters.AddWithValue("@cep", modelo.CliCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.CliEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.CliBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.CliFone);
            cmd.Parameters.AddWithValue("@cel", modelo.CliCel);
            cmd.Parameters.AddWithValue("@email", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@endnumero", modelo.CliEndnumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.CliEstado);
            cmd.Parameters.AddWithValue("@cli_observacao", modelo.cli_observacao);
            cmd.Parameters.AddWithValue("@codigo", modelo.CliCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete  from cliente where cli_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from cliente where cli_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarRelatorioAnalitico(string nome, string dataInicial, string dataFinal, string cidade, string estado, string status,string defeito,string solucao,string referencia)
        {
            string consulta = String.Format(
      " SELECT " +
       "  cliente.cli_cod as Codigo " +
       " ,[cli_nome] as Cliente " +
       " ,[cli_cpfcnpj] as CpfCnpj " +
       " ,[cli_rgie] as RgIe " +
       " ,[cli_rsocial] as RSocial " +
       " ,[cli_tipo] as Tipo " +
      "  ,[cli_cep] as Cep " +
      "  ,[cli_endereco] as Endereço " +
      "  ,[cli_bairro] as Bairro " +
      "  ,[cli_fone] as Fone " +
      "  ,[cli_cel] as Cel " +
      "  ,[cli_email] as Email " +
     "   ,[cli_endnumero] as Numero " +
     "   ,[cli_cidade] as Cidade " +
      "  ,[cli_estado] as UF " +
     "   ,[cli_observacao] as Observação " +
     "   ,[cli_cadastro] as Cadastro " +
      "  , v.ven_cod as Orçamento " +
      "  , v.ven_data as Data " +
      "  , v.ven_nfiscal as Nfiscal " +
      "  , v.ven_total as Total " +
      "  , v.ven_status as 'Status' " +
      "  , v.ven_data_entrada as Entrada " +
     "   , v.ven_data_saida as Saída " +
     "   , v.ven_hora_entrada as Início " +
     "   , v.ven_hora_saida as Término " +
      "  , v.ven_defeito_apresentado as Defeito " +
     "   , v.ven_servico_efetuado as Serviço " +  
     ", ClienteProduto.referencia as Referencia"  +
  "  FROM cliente " +
  "  inner join venda v on Cliente.cli_cod = v.cli_cod " +
"inner join ClienteProduto on Cliente.cli_cod = ClienteProduto.codCliente " +
  " where cli_nome like '%{0}%' and cli_cadastro between '{1}' and '{2}' and cli_cidade like '%{3}%' and cli_estado like '%{4}%' and v.ven_status like '%{5}%' and v.ven_defeito_apresentado like '%{6}%' and v.ven_servico_efetuado like '%{7}%' and ClienteProduto.referencia like'%{8}%' order by cliente.cli_cod", nome, dataInicial, dataFinal, cidade, estado, status,defeito,solucao,referencia);

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorCodigo(string valor)
        {
            string consulta = string.Format("select * from cliente where cli_cod = '{0}'", valor);
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
            SqlDataAdapter da = new SqlDataAdapter("select * from cliente where cli_cpfcnpj like'%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //Carrega Modelo Pelo Código do Cliente
        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cli_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();

                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.CliNome = registro["cli_nome"].ToString();
                modelo.CliCpfCnpj = registro["cli_cpfcnpj"].ToString();
                modelo.Clirgie = registro["cli_rgie"].ToString();
                modelo.cli_razaoSocial = registro["cli_rsocial"].ToString();
                modelo.CliTipo = registro["cli_tipo"].ToString();
                modelo.CliCep = registro["cli_cep"].ToString();
                modelo.CliEndereco = registro["cli_endereco"].ToString();
                modelo.CliBairro = registro["cli_bairro"].ToString();
                modelo.CliFone = registro["cli_fone"].ToString();
                modelo.CliCel = registro["cli_cel"].ToString();
                modelo.CliEmail = registro["cli_email"].ToString();
                modelo.CliEndnumero = registro["cli_endnumero"].ToString();
                modelo.CliCidade = registro["cli_cidade"].ToString();
                modelo.CliEstado = registro["cli_estado"].ToString();
                modelo.cli_observacao = registro["cli_observacao"].ToString();


            }

            return modelo;
        }

        //Carrega Modelo CpfCNPJ do Cliente
        public ModeloCliente CarregaModeloCliente(String cpfcnpj)
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where cli_cpfcnpj = @cpfcnpj";
            cmd.Parameters.AddWithValue("@cpfcnpj", cpfcnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.CliNome = registro["cli_nome"].ToString();
                modelo.CliCpfCnpj = registro["cli_cpfcnpj"].ToString();
                modelo.Clirgie = registro["cli_rgie"].ToString();
                modelo.cli_razaoSocial = registro["cli_rsocial"].ToString();
                modelo.CliTipo = registro["cli_tipo"].ToString();
                modelo.CliCep = registro["cli_cep"].ToString();
                modelo.CliEndereco = registro["cli_endereco"].ToString();
                modelo.CliBairro = registro["cli_bairro"].ToString();
                modelo.CliFone = registro["cli_fone"].ToString();
                modelo.CliCel = registro["cli_cel"].ToString();
                modelo.CliEmail = registro["cli_email"].ToString();
                modelo.CliEndnumero = registro["cli_endnumero"].ToString();
                modelo.CliCidade = registro["cli_cidade"].ToString();
                modelo.CliEstado = registro["cli_estado"].ToString();



            }

            return modelo;
        }
    }
}
