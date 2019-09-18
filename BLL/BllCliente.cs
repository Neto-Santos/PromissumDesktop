using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidade;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Ferramentas;

namespace BLL
{
    public class BllCliente
    {
        DalConexao conexao;
        public BllCliente(DalConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
               MessageBox.Show("O nome do Cliente é Obrigatório"); return;
              
            }
            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
               MessageBox.Show("O CPf/CNPJ é Obrigatório"); return;
               
            }
            if (modelo.CliTipo == "Fisica")
            {
                if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                   MessageBox.Show("O CPf é inválido"); return;
                  
                }

                if (modelo.Clirgie.Trim().Length == 0)
                {
                    MessageBox.Show("O RG/IE é Obrigatório"); return;

                }
            }
            else
            {
                if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                {
                   MessageBox.Show("O CNPJ é inválido"); return;
                 
                }

            }

            if (modelo.CliFone.Trim().Length == 0)
            {
               MessageBox.Show("O Telefone é Obrigatório"); return;
               
            }

            if (Validacao.ValidaEmail(modelo.CliEmail) != true)
            {
               MessageBox.Show("Email Inválido"); return;
                
            }
            if (Validacao.ValidaCep(modelo.CliCep) != true)
            {
               MessageBox.Show("Cep Inválido"); return;
                
            }
            //if (String.IsNullOrEmpty(modelo.CliEndereco))
            //{
            //    MessageBox.Show("Por favor. Informe o endereço"); return;
                
            //}

            if (String.IsNullOrEmpty(modelo.CliBairro))
            {
                MessageBox.Show("Por favor. Informe o Bairro"); return;
                
            }
            if (String.IsNullOrEmpty(modelo.CliFone))
            {
                MessageBox.Show("Por favor. Informe o Telefone"); return;
                
            }
            if (String.IsNullOrEmpty(modelo.CliCel))
            {
                MessageBox.Show("Por favor. Informe o celular"); return;
               
            }
            if (String.IsNullOrEmpty(modelo.CliCel))
            {
                MessageBox.Show("Por favor. Informe o celular"); return;
                
            }
                      if (String.IsNullOrEmpty(modelo.CliCidade))
            {
                MessageBox.Show("Por favor. Informe a Cidade"); return;
                
            }
            if (String.IsNullOrEmpty(modelo.CliEstado))
            {
                MessageBox.Show("Por favor. Informe o estado"); return;
                
            }
            else
            {
                try
                {
                    DalCliente dal = new DalCliente(conexao);
                    dal.Incluir(modelo);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
                }
            }
          
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CliCod <=0)
            {
                MessageBox.Show("Não há cliente selecionado"); return;
               
            }
            if (modelo.CliNome.Trim().Length == 0)
            {
                MessageBox.Show("O nome do Cliente é Obrigatório"); return;
                
            }
            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                MessageBox.Show("O CPf/CNPJ é Obrigatório"); return;
                
            }
            if (modelo.CliTipo == "Fisica")
            {
                if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                    MessageBox.Show("O CPf é inválido"); return;

                }

                if (modelo.Clirgie.Trim().Length == 0)
                {
                    MessageBox.Show("O RG/IE é Obrigatório"); return;

                }
            }
            else
            {
                if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                {
                    MessageBox.Show("O CNPJ é inválido"); return;

                }

            }         
            if (modelo.CliFone.Trim().Length == 0)
            {
                MessageBox.Show("O Telefone é Obrigatório"); return;
                
            }

            if (Validacao.ValidaEmail(modelo.CliEmail) != true)
            {
                MessageBox.Show("Email Inválido"); return;
            }
            if (Validacao.ValidaCep(modelo.CliCep) != true)
            {
                MessageBox.Show("Cep Inválido"); return;
            }
            if (String.IsNullOrEmpty(modelo.CliEndereco))
            {
                MessageBox.Show("Por favor. Informe o endereço"); return;
            }

            if (String.IsNullOrEmpty(modelo.CliBairro))
            {
                MessageBox.Show("Por favor. Informe o Bairro"); return;
            }
            if (String.IsNullOrEmpty(modelo.CliFone))
            {
                MessageBox.Show("Por favor. Informe o Telefone"); return;
            }
            if (String.IsNullOrEmpty(modelo.CliCel))
            {
                MessageBox.Show("Por favor. Informe o celular"); return;
            }
            if (String.IsNullOrEmpty(modelo.CliCel))
            {
                MessageBox.Show("Por favor. Informe o celular"); return;
            }
            //if (String.IsNullOrEmpty(modelo.CliEndnumero))
            //{
            //    MessageBox.Show("Por favor. Informe o número de endereço"); return;
            //}
            if (String.IsNullOrEmpty(modelo.CliCidade))
            {
                MessageBox.Show("Por favor. Informe a Cidade"); return;
            }
            if (String.IsNullOrEmpty(modelo.CliEstado))
            {
                MessageBox.Show("Por favor. Informe o estado"); return;
            }
            else
            {
                try
                {
                    DalCliente dal = new DalCliente(conexao);
                    dal.Alterar(modelo);
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
            if (codigo>0)
            {
                try
                {
                    DalCliente dal = new DalCliente(conexao);
                    dal.Excluir(codigo);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado"); return;
                }
            }
          

        }

        public DataTable Localizar(string valor)
        {

            DalCliente dal = new DalCliente(conexao);
            return dal.Localizar(valor);

        }
        public DataTable LocalizarRelatorioAnalitico(string nome, string dataInicial, string dataFinal, string cidade, string estado,string status,string defeito,string solucao,string referencia)
        {
            DalCliente dal = new DalCliente(conexao);

            return dal.LocalizarRelatorioAnalitico(nome,dataInicial,dataFinal,cidade,estado,status,defeito,solucao,referencia);
        }
        public DataTable LocalizarPorCodigo(string valor)
        {
            DalCliente dal = new DalCliente(conexao);
            return dal.LocalizarPorCodigo(valor);
        }

        public DataTable LocalizarPorCpfCnpj(string valor)
        {
            DalCliente dal = new DalCliente(conexao);
            return dal.LocalizarPorCpfCnpj(valor);
        }
        //Carrega Modelo Pelo Código do Cliente
        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DalCliente dal = new DalCliente(conexao);
            return dal.CarregaModeloCliente(codigo);
        }

        //Carrega Modelo pelo CpfCNPJ do Cliente
        public ModeloCliente CarregaModeloCliente(String cpfcnpj)
        {
            ModeloCliente modelo = new ModeloCliente();
            DalCliente dal = new DalCliente(conexao);
            dal.CarregaModeloCliente(cpfcnpj);

            return modelo;


        }
    }
}
