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
    public class DALCategoria
    {
        public DalConexao conexao { get; set; }
        public DALCategoria(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into categoria(cat_nome,cat_cadastro) values (@nome,@cat_cadastro) select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.cat_nome);
                cmd.Parameters.AddWithValue("@cat_cadastro", DateTime.Now);
                conexao.Conectar();
                modelo.cat_cod = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception)
            {

            }


        }

        public void Alterar(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update categoria set cat_nome = @nome where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.cat_nome);
            cmd.Parameters.AddWithValue("@codigo", modelo.cat_cod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete  from categoria where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select cat_cod as Codigo,cat_nome as Categoria from categoria where cat_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }


        public DataTable RelatorioCategoria(string categoria, string dtInicio, string dtFim, string produto,string subCategoria)
        {
            string consulta = String.Format("SELECT categoria.cat_cod as Codigo "+
      ", categoria.cat_nome as Categoria " +
      ", categoria.cat_cadastro as Cadastro " +
      ", produto.pro_nome as Produto " +
      ", produto.pro_valorpago as Custo " +
      ", produto.pro_valorvenda as Venda " +
      ", subcategoria.scat_nome as SubCategoria " +
  "FROM categoria " +
" inner join produto on categoria.cat_cod = produto.cat_cod " +
" inner join subcategoria on subcategoria.cat_cod = categoria.cat_cod" +
" where categoria.cat_nome like '%{0}%' and categoria.cat_cadastro between '{1}' and '{2}' and produto.pro_nome like '%{3}%' and subcategoria.scat_nome like '%{4}%' order by categoria.cat_cod ", categoria, dtInicio, dtFim, produto,subCategoria);

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            ModeloCategoria modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from categoria where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.cat_cod = Convert.ToInt32(registro["cat_cod"]);
                modelo.cat_nome = registro["cat_nome"].ToString();
            }

            return modelo;
        }
    }
}
