using DAL;
using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BllItensVenda
    {
        DalConexao conexao;
        
        public BllItensVenda(DalConexao conexao)
        {
            this.conexao = conexao;
        }        
        public void Incluir(ModeloItensVenda modelo)
        {
            if (modelo.op_cod <= 0)
            {
                MessageBox.Show("Favor informe uma operação para o serviço/item selecionado"); return;
            }

            if (modelo.VenCod <= 0)
            {
               MessageBox.Show("O código da venda é obrigatório"); return;
            }
            //if (modelo.itvCod <= 0)
            //{
            //   MessageBox.Show("O código do item é obrigatório"); return;
            //}
            if (modelo.itvQtde <= 0)
            {
               MessageBox.Show("A quantidade deve ser maior que zero."); return;
            }
            if (modelo.itvValor <= 0)
            {
               MessageBox.Show("O valor do item deve ser maior que zero."); return;
            }
            if (modelo.cp_cod <= 0)
            {
               MessageBox.Show("O código do produto é obrigatório"); return;
            }
            if (String.IsNullOrEmpty(modelo.itvDesconto.ToString()))
            {
                MessageBox.Show("Não há desconto informado"); return;
            }
            else
            {
                try
                {
                    DalItensVenda DalItensVenda = new DalItensVenda(conexao);
                    DalItensVenda.Incluir(modelo);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
                }

            }

        }

        public DataTable LocalizarProdutosVenda(int codVenda)
        {
            DalItensVenda DalItensVenda = new DalItensVenda(conexao);
            return DalItensVenda.LocalizarProdutosVenda(codVenda);            
        }
        public void Alterar(ModeloItensVenda modelo)
        {
            if (modelo.op_cod <= 0)
            {
                MessageBox.Show("Favor informe uma operação para o serviço/item selecionado"); return;
            }
            if (modelo.itvCod <=0)
            {
                MessageBox.Show("Não há item selecionado"); return;
            }
            if (modelo.VenCod <= 0)
            {
                MessageBox.Show("O código da venda é obrigatório"); return;
            }
            //if (modelo.itvCod <= 0)
            //{
            //   MessageBox.Show("O código do item é obrigatório"); return;
            //}
            if (modelo.itvQtde <= 0)
            {
                MessageBox.Show("A quantidade deve ser maior que zero."); return;
            }
            if (modelo.itvValor <= 0)
            {
                MessageBox.Show("O valor do item deve ser maior que zero."); return;
            }
            if (modelo.cp_cod <= 0)
            {
                MessageBox.Show("O código do produto é obrigatório"); return;
            }
            if (String.IsNullOrEmpty(modelo.itvDesconto.ToString()))
            {
                MessageBox.Show("Não há desconto informado"); return;
            }
            else
            {
                try
                {
                    DalItensVenda DalItensVenda = new DalItensVenda(conexao);
                    DalItensVenda.Alterar(modelo);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
                }

            }

        }

        public void Excluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
               MessageBox.Show("O código da venda é obrigatório"); return;
            }
            if (modelo.itvCod <= 0)
            {
               MessageBox.Show("O código do item é obrigatório"); return;
            }
            if (modelo.cp_cod <= 0)
            {
               MessageBox.Show("O código do produto é obrigatório"); return;
            }
            else
            {
                try
                {
                    DalItensVenda DalItensVenda = new DalItensVenda(conexao);
                    DalItensVenda.Excluir(modelo);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
                }

            }

        }
        public void ExcluirTodosItensVenda(int VenCod)
        {
            try
            {
                DalItensVenda DalItensVenda = new DalItensVenda(conexao);
                DalItensVenda.ExcluirTodositensvenda(VenCod);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
            }

        }

        public DataTable Localizar(int VenCod)
        {
            DalItensVenda DalItensVenda = new DalItensVenda(conexao);
            return DalItensVenda.Localizar(VenCod);
        }
        public DataTable LocalizarTodos()
        {
            DalItensVenda DalItensVenda = new DalItensVenda(conexao);
            return DalItensVenda.LocalizarTodos();
        }

        public DataTable LocalizarColunasRenomeadas(int VenCod)
        {
            DalItensVenda DalItensVenda = new DalItensVenda(conexao);
            return DalItensVenda.LocalizarColunasRenomeadas(VenCod);
        }

        public ModeloItensVenda CarregaModeloItensVenda(int itvCod, int VenCod, int cp_cod)
        {
            DalItensVenda DalItensVenda = new DalItensVenda(conexao);
            return DalItensVenda.CarregaModeloItensVenda(itvCod, VenCod, cp_cod);

        }
    }
}
