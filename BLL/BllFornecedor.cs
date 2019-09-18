using DAL;
using Ferramentas;
using Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLLFornecedor
    {
        DalConexao conexao;
        public BLLFornecedor(DalConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                MessageBox.Show("O nome do Fornecedor é Obrigatório"); return;
            }

          
            if (modelo.tipo == "Fisica")
            {
                if (Validacao.IsCpf(modelo.ForCpf) == false)
                {
                    MessageBox.Show("O CPf é inválido"); return;
                }
            }
            else
            {
                if (Validacao.IsCnpj(modelo.ForCnpj) == false)
                {
                    MessageBox.Show("O CNPJ é inválido"); return;
                }
                if (modelo.ForIe.Trim().Length == 0)
                {
                    MessageBox.Show("O RG/IE é Obrigatório"); return;
                }
            }          
            if (modelo.ForFone.Trim().Length == 0)
            {
                MessageBox.Show("O Telefone é Obrigatório"); return;
            }

            if (Validacao.ValidaEmail(modelo.ForEmail) != true)
            {
                MessageBox.Show("Email Inválido"); return;
            }
            if (Validacao.ValidaCep(modelo.ForCep) != true)
            {
                MessageBox.Show("Cep Inválido"); return;
            }
            if (String.IsNullOrEmpty(modelo.ForBairro))
            {
                MessageBox.Show("Informe o Bairro"); return;
            }
            if (String.IsNullOrEmpty(modelo.ForCidade))
            {
                MessageBox.Show("Informe a Cidade"); return;
            }
            if (String.IsNullOrEmpty(modelo.ForEndnumero))
            {
                MessageBox.Show("Informe o Nº"); return;
            }
            if (String.IsNullOrEmpty(modelo.ForEndereco))
            {
                MessageBox.Show("Informe o endereço"); return;
            }
            if (String.IsNullOrEmpty(modelo.ForEstado))
            {
                MessageBox.Show("Informe o estado"); return;
            }
            if (String.IsNullOrEmpty(modelo.ForCel))
            {
                MessageBox.Show("Informe o celular"); return;
            }
            else
            {
                try
                {
                    DalFornecedor dal = new DalFornecedor(conexao);
                    dal.Incluir(modelo);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception)
                {

                    throw;
                }
             
            }
            

        }

        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.ForCod <= 0)
            {
                MessageBox.Show("Selecione um Fornecedor"); return;
            }
            if (modelo.ForNome.Trim().Length == 0)
            {
                MessageBox.Show("O nome do Fornecedor é Obrigatório"); return;
            }


            if (modelo.tipo == "Fisica")
            {
                if (Validacao.IsCpf(modelo.ForCpf) == false)
                {
                    MessageBox.Show("O CPf é inválido"); return;
                }
            }
            else
            {
                if (Validacao.IsCnpj(modelo.ForCnpj) == false)
                {
                    MessageBox.Show("O CNPJ é inválido"); return;
                }
                if (modelo.ForIe.Trim().Length == 0)
                {
                    MessageBox.Show("O RG/IE é Obrigatório"); return;
                }
            }
            if (modelo.ForFone.Trim().Length == 0)
            {
                MessageBox.Show("O Telefone é Obrigatório"); return;
            }

            if (Validacao.ValidaEmail(modelo.ForEmail) != true)
            {
                MessageBox.Show("Email Inválido"); return;
            }
            if (Validacao.ValidaCep(modelo.ForCep) != true)
            {
                MessageBox.Show("Cep Inválido"); return;
            }
            if (String.IsNullOrEmpty(modelo.ForBairro))
            {
                MessageBox.Show("Informe o Bairro"); return;
            }
            if (String.IsNullOrEmpty(modelo.ForCidade))
            {
                MessageBox.Show("Informe a Cidade"); return;
            }
            if (String.IsNullOrEmpty(modelo.ForEndnumero))
            {
                MessageBox.Show("Informe o Nº"); return;
            }
            if (String.IsNullOrEmpty(modelo.ForEndereco))
            {
                MessageBox.Show("Informe o endereço"); return;
            }
            if (String.IsNullOrEmpty(modelo.ForEstado))
            {
                MessageBox.Show("Informe o estado"); return;
            }
            if (String.IsNullOrEmpty(modelo.ForCel))
            {
                MessageBox.Show("Informe o celular"); return;
            }
            else
            {
                try
                {
                    DalFornecedor dal = new DalFornecedor(conexao);
                    dal.Alterar(modelo);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception)
                {

                    throw;
                }

            }


        }

        public void Excluir(int codigo)
        {
            if (codigo > 0)
            {
                try
                {
                    DalFornecedor dal = new DalFornecedor(conexao);
                    dal.Excluir(codigo);
                    BllAviso.aviso("Operação realizada com sucesso!!!");
                }
                catch (Exception)
                {

                    throw;
                }
              
            }
            
        }

        public DataTable LocalizarFornecedorPorNome(string valor)
        {

            DalFornecedor dal = new DalFornecedor(conexao);
            return dal.LocalizarFornecedorPorNome(valor);

        }

        public DataTable LocalizarFornecedorPorCnpj(string valor)
        {
            DalFornecedor dal = new DalFornecedor(conexao);
            return dal.LocalizarFornecedorPorCnpj(valor);
        }

        //Carrega Modelo Pelo Código do Fornecedor
        public ModeloFornecedor CarregaModeloFornecedorPorCodigo(int codigo)
        {
            DalFornecedor dal = new DalFornecedor(conexao);
            return dal.CarregaModeloFornecedorPorCodigo(codigo);
        }
        public DataTable LocalizarFornecedorPorCodigo(string valor)
        {
            DalFornecedor dal = new DalFornecedor(conexao);
            return dal.LocalizarFornecedorPorCodigo(valor);
        }
        //Carrega Modelo pelo CpfCNPJ do Fornecedor
        public ModeloFornecedor CarregaModeloFornecedorPorCNPJ(String cnpj)
        {
            DalFornecedor dal = new DalFornecedor(conexao);
            ModeloFornecedor modelo = dal.CarregaModeloFornecedorPorCNPJ(cnpj);
            return modelo;
        }

        public DataTable RelatorioFornecedor(string fornecedor, string cidade, string estado, string cpf, string cnpj, string cadastroInicio, string cadastroTermino, string produto)
        {
            DalFornecedor dal = new DalFornecedor(conexao);
           
            return dal.RelatorioFornecedor(fornecedor,cidade,estado,cpf,cnpj,cadastroInicio,cadastroTermino,produto);
        }
        public DataTable RelatorioFornecedor(string fornecedor, string cidade, string estado, string cpf, string cnpj, string cadastroInicio, string cadastroTermino)
        {
            DalFornecedor dal = new DalFornecedor(conexao);

            return dal.RelatorioFornecedor(fornecedor, cidade, estado, cpf, cnpj, cadastroInicio, cadastroTermino);
        }
    }
}
