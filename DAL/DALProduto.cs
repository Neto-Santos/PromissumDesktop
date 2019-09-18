using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidade;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DAL
{
    public class DALProduto
    {
        DalConexao conexao;
        public DALProduto(DalConexao cx)
        {
            this.conexao = cx;
        }

        public void incluir(ModeloProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into produto (pro_nome,pro_descricao,pro_foto,pro_valorpago,pro_valorvenda,pro_qtde,umed,cat_cod, scat_cod,pro_cadastro,for_cod,pro_ref,localizacao) values(@pro_nome,@pro_descricao,@pro_foto,@pro_valorpago,@pro_valorvenda,@pro_qtde,@umed,@cat_cod,@scat_cod,@pro_cadastro,@for_cod,@pro_ref,@localizacao) select @@IDENTITY";

                cmd.Parameters.AddWithValue("@pro_nome", modelo.ProNome);
                cmd.Parameters.AddWithValue("@pro_descricao", modelo.ProDescricao);
                cmd.Parameters.AddWithValue("@pro_ref", modelo.pro_ref);
                cmd.Parameters.AddWithValue("@pro_foto", System.Data.SqlDbType.Image);
                if (modelo.ProFoto == null)
                {
                    cmd.Parameters.AddWithValue("@pro_foto", DBNull.Value);
                    cmd.Parameters["@pro_foto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@pro_foto"].Value = modelo.ProFoto;
                }
                cmd.Parameters.AddWithValue("@pro_valorpago", modelo.ProValorpago);
                cmd.Parameters.AddWithValue("@pro_valorvenda", modelo.ProValorvenda);
                cmd.Parameters.AddWithValue("@pro_qtde", modelo.ProQtde);
                cmd.Parameters.AddWithValue("@umed", modelo.UmedCod);
                cmd.Parameters.AddWithValue("@cat_cod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@scat_cod", modelo.ScatCod);
                cmd.Parameters.AddWithValue("@pro_cadastro", DateTime.Now);
                cmd.Parameters.AddWithValue("@for_cod", modelo.for_cod);
                cmd.Parameters.AddWithValue("@localizacao", modelo.localizacao);
                conexao.Conectar();
                modelo.ProCod = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception erro)
            {

                throw new Exception("ERRO AO INSERIR UM PRODUTO" + erro);
            }


        }

        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from produto where pro_cod = @cod";
                cmd.Parameters.AddWithValue("@cod", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {

                throw new Exception("" + erro);
            }

        }

        public void Alterar(ModeloProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update produto set pro_nome = @pro_nome, pro_descricao = @pro_descricao, pro_foto = @pro_foto,pro_valorpago = @pro_valorpago,pro_valorvenda= @pro_valorvenda,pro_qtde = @pro_qtde,umed = @undmed_cod,cat_cod = @cat_cod,scat_cod = @scat_cod, for_cod=@for_cod,pro_ref=@pro_ref,localizacao=@localizacao where pro_cod = @pro_cod";


                cmd.Parameters.AddWithValue("@pro_nome", modelo.ProNome);
                cmd.Parameters.AddWithValue("@pro_descricao", modelo.ProDescricao);
                cmd.Parameters.AddWithValue("@pro_foto", modelo.ProFoto);
                cmd.Parameters.AddWithValue("@pro_ref", modelo.pro_ref);
                //if (modelo.ProFoto == null)
                //{
                //    cmd.Parameters.AddWithValue("@pro_foto", DBNull.Value);
                //    cmd.Parameters["@pro_foto"].Value = DBNull.Value;
                //}
                //else
                //{
                //    cmd.Parameters["@pro_foto"].Value = modelo.ProFoto;
                //}
                cmd.Parameters.AddWithValue("@pro_valorpago", modelo.ProValorpago);
                cmd.Parameters.AddWithValue("@pro_valorvenda", modelo.ProValorvenda);
                cmd.Parameters.AddWithValue("@pro_qtde", modelo.ProQtde);
                cmd.Parameters.AddWithValue("@undmed_cod", modelo.UmedCod);
                cmd.Parameters.AddWithValue("@cat_cod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@scat_cod", modelo.ScatCod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
                cmd.Parameters.AddWithValue("@for_cod", modelo.for_cod);
                cmd.Parameters.AddWithValue("@localizacao", modelo.localizacao);
                conexao.Conectar();
                cmd.ExecuteNonQuery();

                conexao.Desconectar();

            }
            catch (Exception erro)
            {

                throw new Exception("" + erro);
            }

        }

        public void Alterar(ModeloProduto modelo, Boolean transacao)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update produto set pro_nome = @pro_nome, pro_descricao = @pro_descricao, pro_foto = @pro_foto,pro_valorpago = @pro_valorpago,pro_valorvenda= @pro_valorvenda,pro_qtde = @pro_qtde,umed = @undmed_cod,cat_cod = @cat_cod,scat_cod = @scat_cod,for_cod =@for_cod,pro_ref=@pro_ref,localizacao=@localizacao where pro_cod = @pro_cod";


                cmd.Parameters.AddWithValue("@pro_nome", modelo.ProNome);
                cmd.Parameters.AddWithValue("@pro_ref", modelo.pro_ref);
                cmd.Parameters.AddWithValue("@pro_descricao", modelo.ProDescricao);
                cmd.Parameters.AddWithValue("@pro_foto", System.Data.SqlDbType.Image);
                if (modelo.ProFoto == null)
                {
                    cmd.Parameters.AddWithValue("@pro_foto", DBNull.Value);
                    cmd.Parameters["@pro_foto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@pro_foto"].Value = modelo.ProFoto;
                }
                cmd.Parameters.AddWithValue("@pro_valorpago", modelo.ProValorpago);
                cmd.Parameters.AddWithValue("@pro_valorvenda", modelo.ProValorvenda);
                cmd.Parameters.AddWithValue("@pro_qtde", modelo.ProQtde);
                cmd.Parameters.AddWithValue("@undmed_cod", modelo.UmedCod);
                cmd.Parameters.AddWithValue("@cat_cod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@scat_cod", modelo.ScatCod);
                cmd.Parameters.AddWithValue("@for_cod", modelo.for_cod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
                cmd.Parameters.AddWithValue("@localizacao", modelo.localizacao);

                if (transacao)
                {
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    conexao.Conectar();
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar();
                }


            }
            catch (Exception erro)
            {

                throw new Exception("" + erro);
            }

        }

        public DataTable Localizar(String valor)
        {
            string consulta = String.Format("SELECT pro_cod, pro_nome, pro_descricao, pro_valorpago, pro_valorvenda, pro_qtde, umed,categoria.cat_nome,subcategoria.scat_nome,pro_ref,localizacao " +
                                "FROM produto " +
                                "inner join categoria on produto.cat_cod = categoria.cat_cod " +
                                "inner join subcategoria on produto.scat_cod = subcategoria.scat_cod " +
                                "where pro_nome like'%{0}%'", valor);

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, DadosConexao.stringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizar(String valor, string nomePadrao ="")
        {
            string consulta = "SELECT [pro_cod] as codigo,[pro_nome] as nome,[pro_ref] as Referencia,[pro_descricao] as descrição " +
      ",[pro_valorpago] as custo,[pro_valorvenda] as Venda ,[pro_qtde] as Quantidade " +
      ",[umed] as Und,cat_nome as Categoria,scat_nome as SubCategoria,localizacao as Localização " +
      "FROM produto p " +
      "inner join categoria c on p.cat_cod = c.cat_cod " +
     "inner join subcategoria sb on p.scat_cod = sb.scat_cod where pro_nome like '%" + valor + "%'";

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, DadosConexao.stringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarProdutoSubCategoria(String valor)
        {
            string consulta = "SELECT [pro_cod] as codigo,[pro_nome] as nome,[pro_ref] as Referencia,[pro_descricao] as descrição " +
      ",[pro_valorpago] as custo,[pro_valorvenda] as Venda ,[pro_qtde] as Quantidade " +
      ",[umed] as Und,cat_nome as Categoria,scat_nome as SubCategoria,localizacao as Localização " +
      "FROM produto p " +
      "inner join categoria c on p.cat_cod = c.cat_cod " +
     "inner join subcategoria sb on p.scat_cod = sb.scat_cod where sb.scat_nome like '%" + valor + "%'";

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, DadosConexao.stringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarProdutoCategoria(String valor)
        {
            string consulta = "SELECT [pro_cod] as codigo,[pro_nome] as nome,[pro_ref] as Referencia,[pro_descricao] as descrição " +
      ",[pro_valorpago] as custo,[pro_valorvenda] as Venda ,[pro_qtde] as Quantidade " +
      ",[umed] as Und,cat_nome as Categoria,scat_nome as SubCategoria,localizacao as Localização " +
      "FROM produto p " +
      "inner join categoria c on p.cat_cod = c.cat_cod " +
     "inner join subcategoria sb on p.scat_cod = sb.scat_cod where c.cat_nome like '%" + valor + "%'";

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, DadosConexao.stringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarProdutoCodigo(String valor)
        {
            string consulta = "SELECT [pro_cod] as codigo,[pro_nome] as nome,[pro_ref] as Referencia,[pro_descricao] as descrição " +
      ",[pro_valorpago] as custo,[pro_valorvenda] as Venda ,[pro_qtde] as Quantidade " +
      ",[umed] as Und,cat_nome as Categoria,scat_nome as SubCategoria,localizacao as Localização " +
      "FROM produto p " +
      "inner join categoria c on p.cat_cod = c.cat_cod " +
     "inner join subcategoria sb on p.scat_cod = sb.scat_cod where p.pro_cod =" + valor + "";

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, DadosConexao.stringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarProdutoReferencia(string referencia)
        {
            string consulta = "SELECT [pro_cod] as codigo,[pro_nome] as nome,[pro_ref] as Referencia,[pro_descricao] as descrição " +
    ",[pro_valorpago] as custo,[pro_valorvenda] as Venda ,[pro_qtde] as Quantidade " +
    ",[umed] as Und,cat_nome as Categoria,scat_nome as SubCategoria,localizacao as Localização " +
    "FROM produto p " +
    "inner join categoria c on p.cat_cod = c.cat_cod " +
   "inner join subcategoria sb on p.scat_cod = sb.scat_cod where pro_ref like '%" + referencia + "%'";

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, DadosConexao.stringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizaProdutos()
        {
            string consulta = "SELECT [pro_cod] as codigo,[pro_nome] as nome,[pro_ref] as Referencia,[pro_descricao] as descrição " +
      ",[pro_valorpago] as custo,[pro_valorvenda] as Venda ,[pro_qtde] as Quantidade " +
      ",[umed] as Und,cat_nome as Categoria,scat_nome as SubCategoria, localizacao as Localização " +
      "FROM produto p " +
      "inner join categoria c on p.cat_cod = c.cat_cod " +
     "inner join subcategoria sb on p.scat_cod = sb.scat_cod ";

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, DadosConexao.stringConexao);
            da.Fill(tabela);
            return tabela;
        }


        public DataTable RelatorioProdutoAnalitico(string produto, string dtInicio, string dtFim, string categoria, string subCategoria,string referencia)
        {
            string consulta = String.Format("  SELECT[pro_cod] as Codigo " +
      ",[pro_nome] as Produto " +
      ",[pro_descricao] as Descrição   " +
      ",[pro_valorpago] as Custo " +
      ",[pro_valorvenda] as Venda " +
      ",[pro_qtde]as Quantidade " +
      ",[umed] as Und      " +
      ",[pro_cadastro] as Cadastro " +
      ",categoria.cat_nome as Categoria " +
      ",subcategoria.scat_nome as SubCategoria " +
      ",[pro_ref] as Referencia "+
      ",[localizacao] as Localização " +
 " FROM produto " +
       " inner join categoria on produto.cat_cod = categoria.cat_cod " +
        "inner join subcategoria on produto.scat_cod = subcategoria.scat_cod " +
       " where pro_nome like '%{0}%' and pro_cadastro between '{1}' and '{2}' and categoria.cat_nome like '%{3}%' and subcategoria.scat_nome like '%{4}%' and pro_ref like '%{5}%'", produto,  dtInicio,  dtFim,  categoria,  subCategoria,referencia);

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, DadosConexao.stringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            string consulta = String.Format("select * from produto where pro_cod ={0}", codigo);
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = consulta;
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                modelo.ProNome = Convert.ToString(registro["pro_nome"]);
                modelo.ProDescricao = Convert.ToString(registro["pro_descricao"]);
                modelo.ProFoto = Convert.ToString(registro["pro_foto"]);
                modelo.ProValorpago = Convert.ToDouble(registro["pro_valorpago"]);
                modelo.ProValorvenda = Convert.ToDouble(registro["pro_valorvenda"]);
                modelo.ProQtde = Convert.ToInt32(registro["pro_qtde"]);
                modelo.UmedCod = Convert.ToString(registro["umed"]);
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.ScatCod = Convert.ToInt32(registro["scat_cod"]);
                modelo.for_cod = Convert.ToInt32(registro["for_cod"]);
                modelo.pro_ref = Convert.ToString(registro["pro_ref"]);
                modelo.localizacao = Convert.ToString(registro["localizacao"]);
            }
            conexao.Desconectar();
            return modelo;

        }

        public ModeloProduto CarregaModeloProduto(int codigo, Boolean transacao)
        {
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from produto where pro_cod =" + codigo;

            if (transacao == false)
            {
                conexao.Conectar();
            }


            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                modelo.ProNome = Convert.ToString(registro["pro_nome"]);
                modelo.ProDescricao = Convert.ToString(registro["pro_descricao"]);
                modelo.ProFoto = Convert.ToString(registro["pro_foto"]);
                modelo.for_cod = Convert.ToInt32(registro["for_cod"]);
                modelo.ProValorpago = Convert.ToDouble(registro["pro_valorpago"]);
                modelo.ProValorvenda = Convert.ToDouble(registro["pro_valorvenda"]);
                modelo.ProQtde = Convert.ToInt32(registro["pro_qtde"]);
                modelo.UmedCod = Convert.ToString(registro["umed"]);
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.ScatCod = Convert.ToInt32(registro["scat_cod"]);


            }
            if (transacao == false)
            {
                conexao.Desconectar();
            }


            return modelo;

        }

        public void IncrementarProduto(int codProduto, double quantidade)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = this.conexao.ObjetoTransacao;

                cmd.CommandText = "update produto set pro_qtde = pro_qtde + @quantidade where pro_cod = @codProduto ";
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Parameters.AddWithValue("@codProduto", codProduto);

                cmd.ExecuteNonQuery();

            }
            catch (Exception erro)
            {

                throw new Exception("" + erro);
            }
        }

        public void DecrementarProduto(int codProduto, double quantidade)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = this.conexao.ObjetoTransacao;

                cmd.CommandText = "update produto set pro_qtde = pro_qtde - @quantidade where pro_cod = @codProduto ";
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Parameters.AddWithValue("@codProduto", codProduto);

                cmd.ExecuteNonQuery();

            }
            catch (Exception erro)
            {

                throw new Exception("" + erro);
            }
        }
    }
}
