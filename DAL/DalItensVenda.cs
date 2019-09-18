using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DalItensVenda
    {
        public DalConexao conexao { get; set; }
        public DalItensVenda(DalConexao conexao)
        {
            this.conexao = conexao;
        }
        public void Incluir(ModeloItensVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = this.conexao.ObjetoTransacao;

                cmd.CommandText = "insert into itensvenda(itv_qtde, itv_valor,ven_cod, cp_cod,referencia,itv_valorBase,itv_desconto,op_cod) values (@itv_qtde, @itv_valor,@ven_cod, @cp_cod,@referencia,@itv_valorBase,@itv_desconto,@op_cod)";
                //cmd.Parameters.AddWithValue("@itv_cod", modelo.itvCod);
                cmd.Parameters.AddWithValue("@itv_qtde", modelo.itvQtde);
                cmd.Parameters.AddWithValue("@itv_valor", modelo.itvValor);
                cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
                cmd.Parameters.AddWithValue("@cp_cod", modelo.cp_cod);
                cmd.Parameters.AddWithValue("@referencia", modelo.referencia);
                cmd.Parameters.AddWithValue("@itv_valorBase", modelo.itvValorBase);
                cmd.Parameters.AddWithValue("@itv_desconto", modelo.itvDesconto);
                cmd.Parameters.AddWithValue("@op_cod", modelo.op_cod);
                //A partir de agora, está sendo utilizado transactions (transações)
                //devido a isso não deve usar várias conexões, mas apenas uma

                //conexao.Conectar();
                cmd.ExecuteNonQuery();
                // conexao.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(ModeloItensVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;

            cmd.CommandText = "update itensvenda set itv_qtde = @itv_qtde, itv_valor = @itv_valor, referencia=@referencia,op_cod=@op_cod where itv_cod = @itv_cod and ven_cod = @ven_cod and cp_cod = @cp_cod";
            cmd.Parameters.AddWithValue("@itv_cod", modelo.itvCod);
            cmd.Parameters.AddWithValue("@itv_qtde", modelo.itvQtde);
            cmd.Parameters.AddWithValue("@itv_valor", modelo.itvValor);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@cp_cod", modelo.cp_cod);
            cmd.Parameters.AddWithValue("@referencia", modelo.referencia);
            cmd.Parameters.AddWithValue("@itv_valorBase", modelo.itvValorBase);
            cmd.Parameters.AddWithValue("@itv_desconto", modelo.itvDesconto);
            cmd.Parameters.AddWithValue("@op_cod", modelo.op_cod);
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void Excluir(ModeloItensVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;

            cmd.CommandText = "delete from itensvenda  where itv_cod = @itv_cod and ven_cod = @ven_cod and cp_cod = @cp_cod";
            cmd.Parameters.AddWithValue("@itv_cod", modelo.itvCod);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@cp_cod", modelo.cp_cod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }


        public void ExcluirTodositensvenda(int VenCod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;

            cmd.CommandText = "delete from itensvenda where ven_cod = @ven_cod";
            cmd.Parameters.AddWithValue("@ven_cod", VenCod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public DataTable Localizar(int CodigoVenda)
        {
            string consulta = String.Format("select i.itv_cod, i.itv_qtde, i.itv_valor, i.ven_cod, i.cp_cod,i.itv_valorBase,i.itv_desconto, p.pro_nome, i.referencia,i.op_cod,operacao.op_nome " +
 "from itensvenda i  inner  join ClienteProduto cp on i.cp_cod = cp.cod inner join Produto p on cp.codProduto = p.pro_cod inner join operacao on i.op_cod = operacao.op_cod" +
 " where i.ven_cod = {0}", CodigoVenda);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarTodos()
        {
            string consulta = String.Format("select * from itensVenda");
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarColunasRenomeadas(int CodigoVenda)
        {
            string consulta = String.Format("select i.itv_qtde as Quantidade, i.itv_valor as ValorUn,i.itv_valorBase as ValorBase,i.itv_desconto as Desconto, p.pro_nome as Produto, i.referencia as Referencia,i.op_cod " +
 "from itensvenda i  inner  join ClienteProduto cp on i.cp_cod = cp.cod inner join Produto p on cp.codProduto = p.pro_cod" +
 " where i.ven_cod = {0}", CodigoVenda);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //public DataTable Localizar(int CodigoVenda)
        //{
        //    DataTable tabela = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter("select i.itv_cod,i.itv_qtde, i.itv_valor, i.ven_cod, i.cp_cod, p.pro_nome " +
        //                                            "from itensvenda i inner " +
        //                                            "join produto p on p.cp_cod = i.cp_cod where i.ven_cod= " + CodigoVenda.ToString(), conexao.StringConexao);
        //    da.Fill(tabela);
        //    return tabela;
        //}
        public DataTable LocalizarProdutosVenda(int codVenda)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select i.cp_cod,i.itv_qtde,i.referencia from itensvenda i where i.ven_cod =" + codVenda, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloItensVenda CarregaModeloItensVenda(int itv_cod, int ven_cod, int cp_cod)
        {
            ModeloItensVenda modelo = new ModeloItensVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from itensvenda where itv_cod = @itv_cod and ven_cod = @ven_cod and cp_cod = @cp_cod";
            cmd.Parameters.AddWithValue("@itv_cod", itv_cod);
            cmd.Parameters.AddWithValue("@ven_cod", ven_cod);
            cmd.Parameters.AddWithValue("@cp_cod", cp_cod);
            
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.itvCod = itv_cod;
                modelo.cp_cod = cp_cod;
                modelo.VenCod = ven_cod;
                modelo.itvQtde = Convert.ToDouble(registro["itv_qtde"]);
                modelo.itvValor = Convert.ToDouble(registro["itv_valor"]);
                modelo.itvDesconto = Convert.ToDouble(registro["itv_desconto"]);
                modelo.itvValorBase = Convert.ToDouble(registro["itv_valorBase"]);
                modelo.op_cod = Convert.ToInt32(registro["op_cod"]);
            }

            return modelo;
        }
    }
}
