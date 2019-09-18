using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DalVenda
    {
        private DalConexao conexao;

        public DalVenda(DalConexao conexao)
        {
            this.conexao = conexao;
        }
        public void Incluir(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;

            cmd.CommandText = "insert into venda(ven_data,ven_nfiscal,ven_total,ven_nparcelas,ven_status,cli_cod,tpa_cod,ven_avista,ven_data_entrada,ven_data_saida,ven_hora_entrada,ven_hora_saida,ven_defeito_apresentado,ven_servico_efetuado,ven_diasProximaRevisao,ven_lembrete)"
                + " values(@data,@nfiscal,@total,@nparcelas,@ven_status,@CliCod,@tpacod,@aVista,@ven_data_entrada,@ven_data_saida,@ven_hora_entrada,@ven_hora_saida,@ven_defeito_apresentado,@ven_servico_efetuado,@ven_diasProximaRevisao,@ven_lembrete) select @@IDENTITY;";

            //Informo ao sql que o parâmetro data vai receber o tipo Data, isto é feito para reforçar
            // o tipo de dado que será passado para o campo, evita dores de cabeça posteriores.
            cmd.Parameters.AddWithValue("@data", System.Data.SqlDbType.Date);

            //Aqui passa a informação para o valor Data.
            cmd.Parameters["@data"].Value = modelo.VenData;
            cmd.Parameters.AddWithValue("@nfiscal", modelo.VenNFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.VenNParcelas);
            cmd.Parameters.AddWithValue("@ven_status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@CliCod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
            cmd.Parameters.AddWithValue("@avista", modelo.VenAvista);
            cmd.Parameters.AddWithValue("@ven_data_entrada", DateTime.Now);
            cmd.Parameters.AddWithValue("@ven_diasProximaRevisao", modelo.venDiasAviso);
            cmd.Parameters.AddWithValue("@ven_lembrete", modelo.venLembrete);

            if (modelo.venDataSaida == null)
            {
                cmd.Parameters.AddWithValue("@ven_data_saida", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ven_data_saida", modelo.venDataSaida);
            }

            if (modelo.vendHoraSaida == null)
            {
                cmd.Parameters.AddWithValue("@ven_hora_saida", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ven_hora_saida", modelo.vendHoraSaida);
            }

            cmd.Parameters.AddWithValue("@ven_hora_entrada", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@ven_defeito_apresentado", modelo.vendDefeitoApresentado);
            cmd.Parameters.AddWithValue("@ven_servico_efetuado", modelo.venServicoEfetuado);

            //A partir de agora, está sendo utilizado transactions (transações)
            //devido a isso não deve usar várias conexões, mas apenas uma

            //conexao.Conectar();

            modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());


            //conexao.Desconectar();

        }
        public void Alterar(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;

            cmd.CommandText = "update venda set ven_data = @data,ven_nfiscal = @nfiscal,ven_total = @total, ven_nparcelas = @nparcelas," +
               " ven_status = @ven_status, cli_cod = @CliCod, tpa_cod = @tpacod ,ven_avista = @avista, ven_data_saida = @ven_data_saida" +
               ",ven_hora_saida = @ven_hora_saida,ven_defeito_apresentado=@ven_defeito_apresentado,ven_servico_efetuado=@ven_servico_efetuado, ven_diasProximaRevisao=@ven_diasProximaRevisao,ven_lembrete=@ven_lembrete  where ven_cod = @codigo";
            //Informo ao sql que o parâmetro data vai receber o tipo Data, isto é feito para reforçar
            // o tipo de dado que será passado para o campo, evita dores de cabeça posteriores.

            cmd.Parameters.AddWithValue("@data", System.Data.SqlDbType.Date);

            //Aqui passa a informação para o valor Data.
            cmd.Parameters["@data"].Value = modelo.VenData;
            cmd.Parameters.AddWithValue("@nfiscal", modelo.VenNFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.VenNParcelas);
            cmd.Parameters.AddWithValue("@ven_status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@CliCod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
            cmd.Parameters.AddWithValue("@avista", modelo.VenAvista);
            cmd.Parameters.AddWithValue("@ven_data_entrada", modelo.vendDataEntrada);
            cmd.Parameters.AddWithValue("@ven_diasProximaRevisao", modelo.venDiasAviso);
            cmd.Parameters.AddWithValue("@ven_lembrete", modelo.venLembrete);

            if (modelo.venDataSaida == null)
            {
                cmd.Parameters.AddWithValue("@ven_data_saida", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ven_data_saida", modelo.venDataSaida);
            }

            if (modelo.vendHoraSaida == null)
            {
                cmd.Parameters.AddWithValue("@ven_hora_saida", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ven_hora_saida", modelo.vendHoraSaida);
            }

            cmd.Parameters.AddWithValue("@ven_hora_entrada", modelo.venHoraEntrada);
            cmd.Parameters.AddWithValue("@ven_defeito_apresentado", modelo.vendDefeitoApresentado);
            cmd.Parameters.AddWithValue("@ven_servico_efetuado", modelo.venServicoEfetuado);
            cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
            //A partir de agora, está sendo utilizado transactions (transações)
            //devido a isso não deve usar várias conexões, mas apenas uma

            //conexao.Conectar();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            //conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete  from venda where ven_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

        }

        //Implementar Cancelar a venda
        public Boolean CancelarVenda(int codigo)
        {
            Boolean retorno = true;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            try
            {


                cmd.CommandText = "update venda set ven_status = 'Cancelado' where ven_cod = @codigo";

                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();

                //Incrementar o estoque com os itens da venda cancelada
                //Substituir para o método DalItensVenda
                //Localizar os itens da venda

                //DataTable tabela = new DataTable();
                //SqlDataAdapter da = new SqlDataAdapter("select i.itv_cod, i.pro_cod,i.itv_qtde " +
                //                                        "from itensvenda i where i.ven_cod= " + codigo.ToString(), conexao.StringConexao);
                //da.Fill(tabela);
                //ModeloProduto produto;

                //DALProduto dalProduto = new DALProduto(conexao);

                //for (int i = 0; i < tabela.Rows.Count; i++)
                //{
                //    produto = dalProduto.CarregaModeloProduto(Convert.ToInt32(tabela.Rows[i]["pro_cod"]),true);
                //    produto.ProQtde = produto.ProQtde + Convert.ToDouble(tabela.Rows[i]["itv_qtde"]);
                //    dalProduto.Alterar(produto, true);
                //}

                //conexao.TerminarTransacao();
                //conexao.Desconectar();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
                //conexao.Desconectar();             
            }

            return retorno;
        }

        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select v.ven_cod,v.ven_data,v.ven_nfiscal,v.ven_avista,v.ven_nparcelas,v.ven_total,v.ven_status, v.cli_cod,v.tpa_cod,c.cli_nome,v.ven_lembrete,v.ven_diasAviso from venda v inner join cliente c on v.cli_cod = c.cli_cod  where c.cli_cod =" + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarVenda(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from venda where ven_cod =" + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable Localizar(string codigoVenda)
        {
            string consulta = String.Format("SELECT[ven_cod], cli_nome as Cliente,[ven_total] as Total,[ven_status] as Status " +
      ",[ven_data_entrada] as Entrada,[ven_data_saida] as Saída,[ven_defeito_apresentado] as Defeito,[ven_servico_efetuado] as Serviço,v.ven_lembrete,v.ven_diasAviso " +
       "FROM  venda  v " +
 "inner join cliente c on v.cli_cod = c.cli_cod where ven_cod = {0}", codigoVenda);

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarVendaCliente(string nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select v.ven_cod,v.ven_data,v.ven_nfiscal,v.ven_avista,v.ven_nparcelas,v.ven_total,v.ven_status, v.cli_cod,v.tpa_cod,c.cli_nome,v.ven_lembrete,v.ven_diasAviso from venda v inner join cliente c on v.cli_cod = c.cli_cod  where cli_nome = 'like %" + nome + "% like'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarVendaAberta(string nome)
        {
            string consulta = String.Format("SELECT     venda.ven_cod as Codigo, cliente.cli_nome as Cliente, venda.ven_data as Cadastro, venda.ven_total as Total, venda.ven_status as Status," +
                      "venda.ven_data_entrada as Entrada, venda.ven_data_saida as Termino, venda.ven_hora_entrada as HrInicio, venda.ven_hora_saida as HrFim, venda.ven_defeito_apresentado as Defeito, " +
                      "venda.ven_servico_efetuado as Serviço,venda.ven_lembrete,venda.ven_diasProximaRevisao " +
"FROM         venda INNER JOIN " +
 "                     cliente ON venda.cli_cod = cliente.cli_cod " +
"WHERE(venda.ven_status = 'Aberto') AND(cliente.cli_nome LIKE '%{0}%')", nome);

            SqlCommand cmd = new SqlCommand(consulta);
            cmd.Connection = conexao.ObjetoConexao;

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarVendaCancelado(string nome)
        {
            string consulta = String.Format("SELECT     venda.ven_cod as Codigo, cliente.cli_nome as Cliente, venda.ven_data as Cadastro, venda.ven_total as Total, venda.ven_status as Status," +
                      "venda.ven_data_entrada as Entrada, venda.ven_data_saida as Termino, venda.ven_hora_entrada as HrInicio, venda.ven_hora_saida as HrFim, venda.ven_defeito_apresentado as Defeito, " +
                      "venda.ven_servico_efetuado as Serviço,venda.ven_lembrete,venda.ven_diasProximaRevisao " +
"FROM         venda INNER JOIN " +
 "                     cliente ON venda.cli_cod = cliente.cli_cod " +
"WHERE(venda.ven_status = 'Cancelado') AND(cliente.cli_nome LIKE '%{0}%')", nome);

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarVendaOperacao(string nome)
        {
            //            string consulta = String.Format("SELECT     venda.ven_cod as Codigo, cliente.cli_nome as Cliente, venda.ven_data as Cadastro, venda.ven_total as Total, venda.ven_status as Status," +
            //                     "venda.ven_data_entrada as Entrada, venda.ven_data_saida as Termino, venda.ven_hora_entrada as HrInicio, venda.ven_hora_saida as HrFim, venda.ven_defeito_apresentado as Defeito, " +
            //                     "venda.ven_servico_efetuado as Serviço " +
            //"FROM         venda INNER JOIN " +
            //"                     cliente ON venda.cli_cod = cliente.cli_cod " +
            //"WHERE(venda.ven_status = 'Aberto') AND(cliente.cli_nome LIKE '%{0}%')", nome);

            //            DataTable tabela = new DataTable();
            //            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            //            da.Fill(tabela);
            //            return tabela;
            return null;
        }

        public DataTable LocalizarTodaVenda(string nome)
        {
            string consulta = String.Format("SELECT[ven_cod], cli_nome as Cliente,[ven_total] as Total,[ven_status] as Status " +
      ",[ven_data_entrada] as Entrada,[ven_data_saida] as Saída,[ven_defeito_apresentado] as Defeito,[ven_servico_efetuado] as Serviço,venda.ven_lembrete,venda.ven_diasProximaRevisao " +
       "FROM  venda  v " +
 "inner join cliente c on v.cli_cod = c.cli_cod where c.cli_nome like '%{0}%'", nome);

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarVendaFinalizada(string nome)
        {
            string consulta = String.Format("SELECT     venda.ven_cod as Codigo, cliente.cli_nome as Cliente, venda.ven_data as Cadastro, venda.ven_total as Total, venda.ven_status as Status," +
                     "venda.ven_data_entrada as Entrada, venda.ven_data_saida as Termino, venda.ven_hora_entrada as HrInicio, venda.ven_hora_saida as HrFim, venda.ven_defeito_apresentado as Defeito, " +
                     "venda.ven_servico_efetuado as Serviço,venda.ven_lembrete,venda.ven_diasProximaRevisao " +
"FROM         venda INNER JOIN " +
"                     cliente ON venda.cli_cod = cliente.cli_cod " +
"WHERE(venda.ven_status = 'Finalizado') AND(cliente.cli_nome LIKE '%{0}%')", nome);

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable Localizar(DateTime dataInicial, DateTime dataFinal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            DataTable tabela = new DataTable();
            cmd.CommandText = "select v.ven_cod,v.ven_data,v.ven_nfiscal,v.ven_avista,v.ven_nparcelas,v.ven_total,v.ven_status, v.cli_cod,v.tpa_cod,c.cli_nome,v.ven_lembrete,v.ven_diasProximaRevisao from venda v inner join cliente c on v.cli_cod = c.cli_cod  where v.ven_data between @datainicial and @datafinal";

            //Informando o tipo de dados que serão os parâmetros
            cmd.Parameters.Add("@datainicial", System.Data.SqlDbType.DateTime);
            cmd.Parameters.Add("@datafinal", System.Data.SqlDbType.DateTime);
            //Setando os valores para os parâmetros.
            cmd.Parameters["@datainicial"].Value = dataInicial;
            cmd.Parameters["@datafinal"].Value = dataFinal;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //conexao.Conectar();
            da.Fill(tabela);
            //conexao.Desconectar();
            return tabela;
        }

        public DataTable LocalizarParcelasEmAberto()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            DataTable tabela = new DataTable();
            cmd.CommandText = "select distinct v.ven_cod,v.ven_data,v.ven_nfiscal,v.ven_avista,v.ven_nparcelas,v.ven_total,v.ven_status, v.cli_cod,v.tpa_cod,c.cli_nome,v.ven_lembrete,v.ven_diasProximaRevisao from venda v inner join cliente c on v.cli_cod = c.cli_cod inner join parcelasvenda p on v.ven_cod = p.ven_cod where p.pve_datapagto is NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            conexao.Conectar();
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public int QuantidadeParcelasNaoPagas(int Codigovenda)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;

            cmd.CommandText = "select count(ven_cod) from parcelasvenda where ven_cod =@ven_cod and pve_datapagto is NULL";

            cmd.Parameters.AddWithValue("@ven_cod", Codigovenda);

            int cod = Convert.ToInt32(cmd.ExecuteScalar());

            return cod;
        }
        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            ModeloVenda modelo = new ModeloVenda();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;

            cmd.CommandText = "select * from venda where ven_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();

                if (registro["ven_data_saida"] == DBNull.Value)
                {
                    modelo.venDataSaida = null;
                }
                else
                {
                    modelo.venDataSaida = Convert.ToDateTime(registro["ven_data_saida"]);
                }

                if (registro["ven_hora_saida"] == DBNull.Value)
                {
                    modelo.vendHoraSaida = null;
                }
                else
                {
                    modelo.vendHoraSaida = Convert.ToDateTime(registro["ven_hora_saida"]);
                }

                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
                modelo.VenData = Convert.ToDateTime(registro["ven_data"]);
                modelo.VenTotal = Convert.ToDouble(registro["ven_total"]);
                modelo.VenStatus = Convert.ToString(registro["ven_status"]);
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                modelo.VenNParcelas = Convert.ToInt32(registro["ven_nparcelas"]);
                modelo.VenNFiscal = Convert.ToInt32(registro["ven_nfiscal"]);
                modelo.VenAvista = Convert.ToInt32(registro["ven_avista"]);
                modelo.vendDataEntrada = Convert.ToDateTime(registro["ven_data_entrada"]);
                modelo.venHoraEntrada = Convert.ToDateTime(registro["ven_hora_entrada"]);
                modelo.vendDefeitoApresentado = Convert.ToString(registro["ven_defeito_apresentado"]);
                modelo.venServicoEfetuado = Convert.ToString(registro["ven_servico_efetuado"]);
                modelo.venLembrete = Convert.ToString(registro["ven_lembrete"]);
                modelo.venDiasAviso = Convert.ToInt32(registro["ven_diasProximaRevisao"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        //Usa Transação
        public ModeloVenda CarregaModeloVenda(int codigo, Boolean usaTransacao)
        {
            ModeloVenda modelo = new ModeloVenda();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;

            cmd.CommandText = "select * from venda where ven_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
                modelo.VenData = Convert.ToDateTime(registro["ven_data"]);
                modelo.VenTotal = Convert.ToDouble(registro["ven_total"]);
                modelo.VenStatus = Convert.ToString(registro["ven_status"]);
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                modelo.VenNParcelas = Convert.ToInt32(registro["ven_nparcelas"]);
                modelo.VenNFiscal = Convert.ToInt32(registro["ven_nfiscal"]);
                modelo.VenAvista = Convert.ToInt32(registro["ven_avista"]);
                modelo.venLembrete = Convert.ToString(registro["ven_lembrete"]);
                modelo.venDiasAviso = Convert.ToInt32(registro["ven_diasProximaRevisao"]);
            }
            registro.Close();
            return modelo;
        }
    }
}
