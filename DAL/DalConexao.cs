using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalConexao
    {
        public string StringConexao { get; set; }
        public SqlConnection ObjetoConexao { get; set; }
        private SqlTransaction _transaction;


        public DalConexao(string dadosConexao)
        {            
            this.ObjetoConexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this.ObjetoConexao.ConnectionString = dadosConexao;
        }
        public SqlTransaction ObjetoTransacao
        {
            get { return _transaction; }
            set { _transaction = value; }
        }

        public void IniciarTransacao()
        {
            this._transaction = ObjetoConexao.BeginTransaction();
        }
        public void TerminarTransacao()
        {
            this._transaction.Commit();
        }
        public void CancelarTransacao()
        {
            this._transaction.Rollback();
        }
        public void Conectar()
        {
            if (ObjetoConexao.State == ConnectionState.Closed)
            {
                this.ObjetoConexao.Open();
            }
            else
            {
                this.ObjetoConexao.Close();
                this.ObjetoConexao.Open();
            }
          
        }
        public void Desconectar()
        {
            if (ObjetoConexao.State == ConnectionState.Open)
            {
                this.ObjetoConexao.Close();
            }
            else
            {
                this.ObjetoConexao.Close();
            }  
        }
    }
}
