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
    public class DalEmail
    {

        public DalConexao conexao { get; set; }
        public DalEmail(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        public void Incluir(ModeloEmail modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into email(assunto,corpo,rodape1,rodape2,rodape3) values (@assunto,@corpo,@rodape1,@rodape2,@rodape3) select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@assunto", modelo.assunto);
                cmd.Parameters.AddWithValue("@corpo", modelo.corpo);
                cmd.Parameters.AddWithValue("@rodape1", modelo.rodape1);
                cmd.Parameters.AddWithValue("@rodape2", modelo.rodape2);
                cmd.Parameters.AddWithValue("@rodape3", modelo.rodape3);
                conexao.Conectar();
                modelo.cod = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
            }
            catch (Exception)
            {

            }


        }

        public void Alterar(ModeloEmail modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update email set assunto = @assunto,corpo = @corpo, rodape1=@rodape1, rodape2=@rodape2, rodape3=@rodape3 where cod = @codigo";

            cmd.Parameters.AddWithValue("@codigo", modelo.cod);
            cmd.Parameters.AddWithValue("@assunto", modelo.assunto);
            cmd.Parameters.AddWithValue("@corpo", modelo.corpo);
            cmd.Parameters.AddWithValue("@rodape1", modelo.rodape1);
            cmd.Parameters.AddWithValue("@rodape2", modelo.rodape2);
            cmd.Parameters.AddWithValue("@rodape3", modelo.rodape3);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete  from email where cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //public DataTable Localizar(string valor)
        //{
        //    DataTable tabela = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter("select cod as Codigo,assunto as email from email where assunto like '%" + valor + "%'", conexao.StringConexao);
        //    da.Fill(tabela);
        //    return tabela;
        //}


//        public DataTable Relatorioemail(string email, string dtInicio, string dtFim, string produto, string subemail)
//        {
//            string consulta = String.Format("SELECT email.cod as Codigo " +
//      ", email.assunto as email " +
//      ", email.corpo as Cadastro " +
//      ", produto.pro_assunto as Produto " +
//      ", produto.pro_valorpago as Custo " +
//      ", produto.pro_valorvenda as Venda " +
//      ", subemail.sassunto as Subemail " +
//  "FROM[promissum].[dbo].[email] " +
//" inner join produto on email.cod = produto.cod " +
//" inner join subemail on subemail.cod = email.cod" +
//" where email.assunto like '%{0}%' and email.corpo between '{1}' and '{2}' and produto.pro_assunto like '%{3}%' and subemail.sassunto like '%{4}%'", email, dtInicio, dtFim, produto, subemail);

//            DataTable tabela = new DataTable();
//            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
//            da.Fill(tabela);
//            return tabela;
//        }

        public ModeloEmail CarregaModeloEmail(int cod )
        {
            ModeloEmail modelo = new ModeloEmail();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from email where cod =@cod";
            cmd.Parameters.AddWithValue("@cod", cod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.cod = Convert.ToInt32(registro["cod"]);
                modelo.assunto = registro["assunto"].ToString();
                modelo.rodape1 = registro["rodape1"].ToString();
                modelo.rodape2 = registro["rodape2"].ToString();
                modelo.rodape3 = registro["rodape3"].ToString();
                modelo.corpo = registro["corpo"].ToString();
            }

            return modelo;
        }
    }
}
