using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using MODELO;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BllVenda
    {
        DalConexao conexao;
        public BllVenda(DalConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloVenda modelo)
        {
            if (modelo.VenTotal <= 0)
            {
                MessageBox.Show("Valor da Venda deve ser informado"); return;
            }
            if (modelo.CliCod <= 0)
            {
                MessageBox.Show("Não há cliente selecionado para ordem"); return;
            }
            if (String.IsNullOrEmpty(modelo.vendDefeitoApresentado))
            {
                MessageBox.Show("Não há defeito/problema apresentado"); return;
            }
            if (modelo.VenStatus == "Finalizado")
            {
                if (String.IsNullOrEmpty(modelo.venServicoEfetuado))
                {
                    MessageBox.Show("Não há resolução/serviço apresentado"); return;
                }
            }

            DalVenda dal = new DalVenda(conexao);
            dal.Incluir(modelo);
            BllAviso.aviso("Operação realizada com sucesso!!!");




        }
        public void Alterar(ModeloVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                MessageBox.Show("Não há venda selecionada"); return;
            }
            if (modelo.VenTotal <= 0)
            {
                MessageBox.Show("Valor da Venda deve ser informado"); return;
            }
            if (modelo.CliCod <= 0)
            {
                MessageBox.Show("Não há cliente selecionado para ordem"); return;
            }
            if (String.IsNullOrEmpty(modelo.vendDefeitoApresentado))
            {
                MessageBox.Show("Não há defeito/problema apresentado"); return;
            }
            if (modelo.VenStatus == "Finalizado")
            {
                if (String.IsNullOrEmpty(modelo.venServicoEfetuado))
                {
                    MessageBox.Show("Não há resolução/serviço apresentado"); return;
                }
            }

            DalVenda dal = new DalVenda(conexao);
            dal.Alterar(modelo);
            BllAviso.aviso("Operação realizada com sucesso!!!");


        }
        public void Excluir(int CodigoVenda)
        {
            if (CodigoVenda <= 0)
            {
                MessageBox.Show("O código da venda deve ser maior que zero"); return;
            }
            try
            {
                DalVenda dal = new DalVenda(conexao);
                dal.Excluir(CodigoVenda);
                BllAviso.aviso("Operação realizada com sucesso!!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
            }

        }
        public Boolean CancelarVenda(int CodigoVenda)
        {
            bool retorno = false;

            if (CodigoVenda <= 0)
            {
                MessageBox.Show("O código da venda deve ser maior que zero");
            }
            else
            {
                try
                {
                    DalVenda dal = new DalVenda(conexao);
                    retorno = dal.CancelarVenda(CodigoVenda);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado");
                }
            }

            return retorno;
        }
        public DataTable Localizar(int codigo)
        {
            DalVenda dal = new DalVenda(conexao);
            return dal.Localizar(codigo);
        }
        public DataTable Localizar(string codigoVenda)
        {
            DalVenda dal = new DalVenda(conexao);
            return dal.Localizar(codigoVenda);
        }

        public DataTable LocalizarVenda(int codigoVenda)
        {
            DalVenda dal = new DalVenda(conexao);
            return dal.LocalizarVenda(codigoVenda);
        }
        public DataTable LocalizarVendaAberta(string nome)
        {
            DalVenda dal = new DalVenda(conexao);
            return dal.LocalizarVendaAberta(nome);
        }
        public DataTable LocalizarVendaCancelado(string nome)
        {
            DalVenda dal = new DalVenda(conexao);
            return dal.LocalizarVendaCancelado(nome);
        }
        public DataTable LocalizarVendaOperacao(string nome)
        {
            DalVenda dal = new DalVenda(conexao);
            return dal.LocalizarVendaOperacao(nome);
        }
        public DataTable LocalizarVendaFinalizada(string nome)
        {
            DalVenda dal = new DalVenda(conexao);
            return dal.LocalizarVendaFinalizada(nome);
        }
        public DataTable LocalizarTodaVenda(string nome)
        {
            DalVenda dal = new DalVenda(conexao);
            return dal.LocalizarTodaVenda(nome);
        }
        public DataTable LocalizarParcelasEmAberto()
        {
            DalVenda dal = new DalVenda(conexao);
            return dal.LocalizarParcelasEmAberto();
        }
        public int QuantidadeParcelasNaoPagas(int Codigovenda)
        {
            DalVenda dal = new DalVenda(conexao);
            return dal.QuantidadeParcelasNaoPagas(Codigovenda);
        }
        public DataTable Localizar(DateTime dataInicial, DateTime dataFinal)
        {
            DalVenda dal = new DalVenda(conexao);
            return dal.Localizar(dataInicial, dataFinal);
        }
        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            try
            {
                DalVenda dal = new DalVenda(conexao);
                return dal.CarregaModeloVenda(codigo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public ModeloVenda CarregaModeloVenda(int codigo, Boolean usaTransacao)
        {
            DalVenda dal = new DalVenda(conexao);
            return dal.CarregaModeloVenda(codigo, usaTransacao);
        }
    }
}
