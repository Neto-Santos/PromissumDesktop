using DAL;
using Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace BLL
{
    public class BLLCategoria : BllAviso
    {
        private DalConexao conexao;
        public BLLCategoria(DalConexao cx)
        {
            this.conexao = cx;
        }       

        public void Incluir(ModeloCategoria modelo)
        {

            if (String.IsNullOrEmpty(modelo.cat_nome))
            {
                aviso("O nome da categoria é obrigatório"); return;
            }
            else
            {
                try
                {
                    DALCategoria dalCategoria = new DALCategoria(conexao);
                    dalCategoria.Incluir(modelo);
                    aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(),"Ops. Parece que algo deu errado"); return;
                }
                
            }

        }

        public void Alterar(ModeloCategoria modelo)
        {
            if (modelo.cat_cod <= 0)
            {
                aviso("O código da categoria é obrigatório"); return;
            }
            if (modelo.cat_nome.Trim().Length == 0)
            {
                aviso("O nome da categoria é obrigatório"); return;
            }
            else
            {
                try
                {
                    DALCategoria dalCategoria = new DALCategoria(conexao);
                    dalCategoria.Alterar(modelo);
                    aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
                }

            }

        }

        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                aviso("Não há categoria selecionada"); return;
            }
            else
            {
                try
                {
                    DALCategoria dalCategoria = new DALCategoria(conexao);
                    dalCategoria.Excluir(codigo);
                    aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            
        }

        public DataTable Localizar(string valor)
        {
            DALCategoria dalCategoria = new DALCategoria(conexao);
            return dalCategoria.Localizar(valor);
        }
        public DataTable RelatorioCategoria(string categoria, string dtInicio, string dtFim, string produto,string subCategoria)
        {
            DALCategoria dalCategoria = new DALCategoria(conexao);
            return dalCategoria.RelatorioCategoria(categoria, dtInicio, dtFim, produto,subCategoria);
        }
        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            DALCategoria dalCategoria = new DALCategoria(conexao);
            return dalCategoria.CarregaModeloCategoria(codigo);

        }
    }
}
