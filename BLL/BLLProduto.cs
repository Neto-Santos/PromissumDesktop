using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class BLLProduto:BllAviso
    {
        private DalConexao conexao;

        public BLLProduto(DalConexao cx)
        {
            this.conexao = cx;
        }
        public void incluir(ModeloProduto modelo)
        {
            if (modelo.ProNome.Trim().Length == 0)
            {
                aviso("Nome é obrigatório."); return;
            }
            if (modelo.pro_ref.Trim().Length == 0)
            {
                aviso("A referência é obrigatória"); return;
            }
            if (modelo.ProDescricao.Trim().Length == 0)
            {
                aviso("A descrição do produto é obrigatória"); return;
            }

            if (modelo.ProValorvenda <= 0)
            {
                aviso("O valor de venda do produto é obrgatório"); return;
            }
            if (modelo.ProValorpago <= 0)
            {
                aviso("O valor de custo do produto é obrgatório"); return;
            }
            //if (modelo.ProQtde <= 0)
            //{
            //    aviso("A quantidade do protudo deve ser maior ou igual a zero"); return;
            //}
            if (String.IsNullOrEmpty(modelo.UmedCod))
            {
                aviso("Por favor. Informe uma unidade de medida"); return;
            }
            if (modelo.ScatCod <= 0)
            {
                aviso("O código da sub Categoria é obrigatório"); return;
            }
            if (modelo.CatCod <= 0)
            {
                aviso("O código da  Categoria é obrigatório"); return;
            }
            if (modelo.for_cod <= 0)
            {
                aviso("Por favor. Informe um fornecedor para este produto"); return;
            }
            else
            {
                try
                {
                    DALProduto dal = new DALProduto(conexao);
                    dal.incluir(modelo);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
                }

            }           
        }
        public void Excluir(int codigo)
        {
            try
            {
                DALProduto dal = new DALProduto(conexao);
                dal.Excluir(codigo);
                BllAviso.aviso("Operação realizada com sucesso!!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
            }

        }
        public void Alterar(ModeloProduto modelo)
        {
            if (modelo.ProCod <= 0)
            {
                aviso("Não há produto selecionado"); return;
            }
            if (modelo.pro_ref.Trim().Length == 0)
            {
                aviso("A referência é obrigatória"); return;
            }
            if (modelo.ProNome.Trim().Length == 0)
            {
                aviso("O nome do Produto é obrigatório."); return;
            }
            if (modelo.ProDescricao.Trim().Length == 0)
            {
                aviso("A descrição do produto é obrigatória"); return;
            }

            if (modelo.ProValorvenda <= 0)
            {
                aviso("O valor de venda do produto é obrgatório"); return;
            }
            if (modelo.ProValorpago <= 0)
            {
                aviso("O valor de custo do produto é obrgatório"); return;
            }
            //if (modelo.ProQtde <= 0)
            //{
            //    aviso("A quantidade do protudo deve ser maior ou igual a zero"); return;
            //}
            if (String.IsNullOrEmpty(modelo.UmedCod))
            {
                aviso("Por favor. Informe uma unidade de medida"); return;
            }
            if (modelo.ScatCod <= 0)
            {
                aviso("O código da sub Categoria é obrigatório"); return;
            }
            if (modelo.CatCod <= 0)
            {
                aviso("O código da  Categoria é obrigatório"); return;
            }
            if (modelo.for_cod <= 0)
            {
                aviso("Por favor. Informe um fornecedor para este produto"); return;
            }
            else
            {
                try
                {
                    DALProduto dal = new DALProduto(conexao);
                    dal.Alterar(modelo);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
                }

            }
        }
        public DataTable Localizar(String valor)
        {
            DALProduto dal = new DALProduto(conexao);
            return dal.Localizar(valor);
        }

        public DataTable Localizar(String valor,string valorPadrao)
        {
            DALProduto dal = new DALProduto(conexao);
            return dal.Localizar(valor,valorPadrao);
        }
        public DataTable LocalizaProdutos()
        {
            DALProduto dal = new DALProduto(conexao);
            return dal.LocalizaProdutos();
        }
        public DataTable LocalizarProdutoCategoria(string valor)
        {
            DALProduto dal = new DALProduto(conexao);
            return dal.LocalizarProdutoCategoria(valor);
        }
        public DataTable LocalizarProdutoReferencia(string valor)
        {
            DALProduto dal = new DALProduto(conexao);
            return dal.LocalizarProdutoReferencia(valor);
        }
        public DataTable LocalizarProdutoCodigo(string valor)
        {
            DALProduto dal = new DALProduto(conexao);
            return dal.LocalizarProdutoCodigo(valor);
        }
        public DataTable LocalizarProdutoSubCategoria(string valor)
        {
            DALProduto dal = new DALProduto(conexao);
            return dal.LocalizarProdutoSubCategoria(valor);
        }
        public DataTable RelatorioProdutoAnalitico(string produto, string dtInicio, string dtFim, string categoria, string subCategoria,string referencia)
        {
            DALProduto dal = new DALProduto(conexao);
            return dal.RelatorioProdutoAnalitico(produto, dtInicio, dtFim, categoria, subCategoria,referencia);
        }
        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DALProduto dal = new DALProduto(conexao);
            return dal.CarregaModeloProduto(codigo);
        }
        public void IncrementarProduto(int codProduto, double quantidade)
        {
            DALProduto dal = new DALProduto(conexao);
            dal.IncrementarProduto( codProduto,quantidade);
        }
        public void DecrementarProduto(int codProduto, double quantidade)
        {
            DALProduto dal = new DALProduto(conexao);
            dal.DecrementarProduto(codProduto, quantidade);
        }

    }
}
