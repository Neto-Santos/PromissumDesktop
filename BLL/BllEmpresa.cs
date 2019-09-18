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
using Ferramentas;
using System.Windows.Forms;

namespace BLL
{
    public class BllEmpresa
    {
        DalConexao conexao;
        public BllEmpresa(DalConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloEmpresa modelo)
        {
            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome  é Obrigatório");
            }

            //if (modelo.cpfcnpj.Trim().Length == 0)
            //{
            //    throw new Exception("O CPf/CNPJ é Obrigatório");
            //}

            //if (modelo.CliTipo == "Física")
            //{
            //    if (Validacao.IsCpf(modelo.cpfcnpj) == false)
            //    {
            //        throw new Exception("O CPf é inválido");
            //    }
            //}
            //else
            //{
            //    //if (Validacao.IsCnpj(modelo.cpfcnpj) == false)
            //    //{
            //    //    throw new Exception("O CNPJ é inválido");
            //    //}

            //}

            //if (modelo.Clirgie.Trim().Length == 0)
            //{
            //    throw new Exception("O RG/IE é Obrigatório");
            //}
            if (modelo.telefone.Trim().Length == 0)
            {
                throw new Exception("O Telefone é Obrigatório");
            }

            if (Validacao.ValidaEmail(modelo.email) != true)
            {
                throw new Exception("Email Inválido");
            }
            //if (Validacao.ValidaCep(modelo.CliCep) != true)
            //{
            //    throw new Exception("Cep Inválido");
            //}
            try
            {
                DalEmpresa dal = new DalEmpresa(conexao);
                dal.Incluir(modelo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado");
            }


        }

        public void Alterar(ModeloEmpresa modelo)
        {

            if (modelo.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Cliente é Obrigatório");
            }

            if (modelo.cpfcnpj.Trim().Length == 0)
            {
                throw new Exception("O CPf/CNPJ é Obrigatório");
            }

            if (modelo.telefone.Trim().Length == 0)
            {
                throw new Exception("O Telefone é Obrigatório");
            }


            //Se cli_tipo (Tipo de Cliente) = 0 -> Pessoa Física
            //Se cli_tipo (Tipo de Cliente) = 1 -> Pessoa Jurídica

            //verificão de Email, Usando Expressão Regular
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
             + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
             + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.email))
            {
                throw new Exception("Digite um email válido.");
            }
            try
            {
                DalEmpresa dal = new DalEmpresa(conexao);
                dal.Alterar(modelo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado");
            }

        }

        public void Excluir(int codigo)
        {
            try
            {
                DalEmpresa dal = new DalEmpresa(conexao);
                dal.Excluir(codigo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ops. Parece que algo deu errado");
            }

        }

        public DataTable Localizar(string valor)
        {

            DalEmpresa dal = new DalEmpresa(conexao);
            return dal.Localizar(valor);

        }

        public DataTable LocalizarPorCodigo(string valor)
        {
            DalEmpresa dal = new DalEmpresa(conexao);
            return dal.LocalizarPorCodigo(valor);
        }

        public DataTable LocalizarPorCpfCnpj(string valor)
        {
            DalEmpresa dal = new DalEmpresa(conexao);
            return dal.LocalizarPorCpfCnpj(valor);
        }
        //Carrega Modelo Pelo Código do Cliente
        public ModeloEmpresa CarregaModeloEmpresa(int codigo)
        {
            DalEmpresa dal = new DalEmpresa(conexao);
            return dal.CarregaModeloEmpresa(codigo);
        }

        //Carrega Modelo pelo CpfCNPJ do Cliente
        public ModeloEmpresa CarregaModeloEmpresa(String cpfcnpj)
        {
            ModeloEmpresa modelo = new ModeloEmpresa();
            DalEmpresa dal = new DalEmpresa(conexao);
            dal.CarregaModeloEmpresa(cpfcnpj);

            return modelo;


        }
    }
}
