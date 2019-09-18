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
    public class DalLembrete
    {

        DalConexao conexao;
        public DalLembrete(DalConexao cx)
        {
            this.conexao = cx;
        }

        public void Alterar(int codigoLembrete, int diasAviso, string mensagemAviso, string tituloAviso = "Lembrete Promissum System")
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            string query = String.Format("update lembrete set diasAviso = '{0}', mensagemAviso = '{1}', tituloAviso ='{2}' where cod = {3}", diasAviso, mensagemAviso, tituloAviso, codigoLembrete);
            cmd.CommandText = query;

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }


        public ModeloLembrete retornaLembrete()
        {
            var modeloLembrete = new ModeloLembrete();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = String.Format("select * from lembrete");

            conexao.Conectar();
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    modeloLembrete.diasAviso = Convert.ToInt32(reader["diasAviso"]);
                    modeloLembrete.mensagemAviso = reader["mensagemAviso"].ToString();
                    modeloLembrete.tituloAviso = reader["tituloAviso"].ToString();
                }
            }

            conexao.Desconectar();

            return modeloLembrete;
        }
    }
}
