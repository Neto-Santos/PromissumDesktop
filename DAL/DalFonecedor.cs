using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DalFornecedor
    {
        DalConexao conexao;
        public DalFornecedor(DalConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into fornecedor(for_nome,for_rsocial,for_ie,for_cnpj,for_cep,for_endereco,for_bairro,for_fone,for_cel,for_email,for_endnumero,for_cidade,for_estado,for_cpf,for_observacao,for_cadastro) values (@nome,@rsocial,@ie,@cnpj,@cep,@endereco,@bairro,@fone,@cel,@email,@endnumero,@cidade,@estado,@for_cpf,@for_observacao,@for_cadastro) select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@nome", modelo.ForNome);
            cmd.Parameters.AddWithValue("@rsocial", modelo.ForRsocial);
            cmd.Parameters.AddWithValue("@ie", modelo.ForIe);
            cmd.Parameters.AddWithValue("@cnpj", modelo.ForCnpj);
            cmd.Parameters.AddWithValue("@cep", modelo.ForCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.ForEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.ForFone);
            cmd.Parameters.AddWithValue("@cel", modelo.ForCel);
            cmd.Parameters.AddWithValue("@email", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@endnumero", modelo.ForEndnumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.ForEstado);
            cmd.Parameters.AddWithValue("@for_cpf", modelo.ForCpf);
            cmd.Parameters.AddWithValue("@for_cadastro", DateTime.Now);
            cmd.Parameters.AddWithValue("@for_observacao", modelo.for_observacao);
            conexao.Conectar();
            modelo.ForCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update fornecedor set for_nome = @nome,for_rsocial =@rsocial,for_ie = @ie,for_cnpj = @cnpj,for_cep = @cep,for_endereco = @endereco,for_bairro = @bairro,for_fone = @fone,for_cel = @cel,for_email = @email,for_endnumero = @endnumero,for_cidade = @cidade,for_estado = @estado,for_cpf = @for_cpf, for_observacao=@for_observacao where for_cod = @cod";

            cmd.Parameters.AddWithValue("@cod", modelo.ForCod);
            cmd.Parameters.AddWithValue("@nome", modelo.ForNome);
            cmd.Parameters.AddWithValue("@rsocial", modelo.ForRsocial);
            cmd.Parameters.AddWithValue("@ie", modelo.ForIe);
            cmd.Parameters.AddWithValue("@cnpj", modelo.ForCnpj);
            cmd.Parameters.AddWithValue("@cep", modelo.ForCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.ForEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.ForFone);
            cmd.Parameters.AddWithValue("@cel", modelo.ForCel);
            cmd.Parameters.AddWithValue("@email", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@endnumero", modelo.ForEndnumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.ForEstado);
            cmd.Parameters.AddWithValue("@for_cpf", modelo.ForCpf);
            cmd.Parameters.AddWithValue("@for_observacao", modelo.for_observacao);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from fornecedor where for_cod=@cod";
            cmd.Parameters.AddWithValue("@cod", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable LocalizarFornecedorPorNome(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from fornecedor where for_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarFornecedorPorCodigo(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from fornecedor where for_cod =" + valor, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarFornecedorPorCnpj(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from fornecedor where for_cnpj like'%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //Carrega Modelo do Fornecedor através do Código
        public ModeloFornecedor CarregaModeloFornecedorPorCodigo(int codigo)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from fornecedor where for_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();

                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.ForNome = registro["for_nome"].ToString();
                modelo.ForCnpj = registro["for_cnpj"].ToString();
                modelo.ForIe = registro["for_ie"].ToString();
                modelo.ForRsocial = registro["for_rsocial"].ToString();
                modelo.ForCep = registro["for_cep"].ToString();
                modelo.ForEndereco = registro["for_endereco"].ToString();
                modelo.ForBairro = registro["for_bairro"].ToString();
                modelo.ForFone = registro["for_fone"].ToString();
                modelo.ForCel = registro["for_cel"].ToString();
                modelo.ForEmail = registro["for_email"].ToString();
                modelo.ForEndnumero = registro["for_endnumero"].ToString();
                modelo.ForCidade = registro["for_cidade"].ToString();
                modelo.ForEstado = registro["for_estado"].ToString();
                modelo.ForCpf = registro["for_cpf"].ToString();
                modelo.for_observacao = registro["for_observacao"].ToString();

            }

            return modelo;
        }

        //Carrega Modelo do Fornecedor através do CNPJ
        public ModeloFornecedor CarregaModeloFornecedorPorCNPJ(String cnpj)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from fornecedor where for_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", cnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();

                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.ForNome = registro["for_nome"].ToString();
                modelo.ForCnpj = registro["for_cnpj"].ToString();
                modelo.ForIe = registro["for_ie"].ToString();
                modelo.ForRsocial = registro["for_rsocial"].ToString();
                modelo.ForCep = registro["for_cep"].ToString();
                modelo.ForEndereco = registro["for_endereco"].ToString();
                modelo.ForBairro = registro["for_bairro"].ToString();
                modelo.ForFone = registro["for_fone"].ToString();
                modelo.ForCel = registro["for_cel"].ToString();
                modelo.ForEmail = registro["for_email"].ToString();
                modelo.ForEndnumero = registro["for_endnumero"].ToString();
                modelo.ForCidade = registro["for_cidade"].ToString();
                modelo.ForEstado = registro["for_estado"].ToString();
                modelo.ForCpf = registro["for_cpf"].ToString();
                modelo.for_observacao = registro["for_observacao"].ToString();


            }

            return modelo;
        }

        public DataTable RelatorioFornecedor(string fornecedor, string cidade, string estado, string cpf, string cnpj, string cadastroInicio, string cadastroTermino, string produto)
        {
            string consulta = String.Format("SELECT DISTINCT fornecedor.for_cod as Codigo, fornecedor.for_nome AS Fornecedor, fornecedor.for_rsocial AS RSocial, fornecedor.for_ie AS IE, fornecedor.for_cnpj AS Cnpj, " +
                      "  fornecedor.for_cep AS Cep, fornecedor.for_endereco AS Endereço, fornecedor.for_bairro AS Bairro, fornecedor.for_fone AS Telefone, fornecedor.for_cel AS Celular, " +
                     "   fornecedor.for_email AS Email, fornecedor.for_endnumero AS Nº, fornecedor.for_cidade AS Cidade, fornecedor.for_estado AS UF, fornecedor.for_cadastro AS Cadastro, " +
                      "  fornecedor.for_cpf AS CPF, fornecedor.for_observacao AS Observação, produto.pro_nome AS Produto, produto.pro_descricao AS Descrição, " +
                     "   produto.pro_valorpago AS Custo, produto.pro_valorvenda AS Venda, produto.umed as Und " +
                        "FROM         fornecedor  INNER JOIN " +
                      "produto ON fornecedor.for_cod = produto.for_cod " +
                        "WHERE     for_nome like '%{0}%' and for_cidade  like '%{1}%' and for_estado  like '%{2}%' and for_cpf  like '%{3}%' and for_cnpj  like '%{4}%' and for_cadastro  between '{5}' " +
                         " and '{6}' " +
                        " and pro_nome  like '%{7}%' ", fornecedor, cidade, estado, cpf, cnpj, cadastroInicio, cadastroTermino, produto);
            DataTable tabela = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
                da.Fill(tabela);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            return tabela;
        }
        public DataTable RelatorioFornecedor(string fornecedor, string cidade, string estado, string cpf, string cnpj, string cadastroInicio, string cadastroTermino)
        {
            string consulta = String.Format("SELECT  fornecedor.for_cod as Codigo, fornecedor.for_nome AS Fornecedor, fornecedor.for_rsocial AS RSocial, fornecedor.for_ie AS IE, fornecedor.for_cnpj AS Cnpj, " +
                      "  fornecedor.for_cep AS Cep, fornecedor.for_endereco AS Endereço, fornecedor.for_bairro AS Bairro, fornecedor.for_fone AS Telefone, fornecedor.for_cel AS Celular, " +
                     "   fornecedor.for_email AS Email, fornecedor.for_endnumero AS Nº, fornecedor.for_cidade AS Cidade, fornecedor.for_estado AS UF, fornecedor.for_cadastro AS Cadastro, " +
                      "  fornecedor.for_cpf AS CPF, fornecedor.for_observacao AS Observação " +                     
                        " FROM  fornecedor " +                      
                        "WHERE     for_nome like '%{0}%' and for_cidade  like '%{1}%' and for_estado  like '%{2}%' and for_cpf  like '%{3}%' and for_cnpj  like '%{4}%' and for_cadastro  between '{5}' " +
                         " and '{6}' ", fornecedor, cidade, estado, cpf, cnpj, cadastroInicio, cadastroTermino);

            DataTable tabela = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
                da.Fill(tabela);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return tabela;
        }
    }
}
