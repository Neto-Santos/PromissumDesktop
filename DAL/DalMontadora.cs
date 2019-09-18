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
    public class DalMontadora
    {
        
        public DalMontadora(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        DalConexao conexao;

        public int Incluir(ModeloMontadora modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "incluirMontadora";
            cmd.Parameters.AddWithValue("@montadora", modelo.montadora);
            cmd.Parameters.AddWithValue("@abreviatura_montadora", modelo.abreviatura_montadora);
            cmd.Parameters.AddWithValue("@cadastro", DateTime.Now);
            conexao.Conectar();
            int retorno = cmd.ExecuteNonQuery();
            conexao.Desconectar();
            return retorno;
        }
    }
}
