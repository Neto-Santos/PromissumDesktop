using DAL;
using Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllUsuario : BllAviso
    {
        private DalConexao conexao;
        public BllUsuario(DalConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUsuario modelo)
        {

            if (modelo.usu_nome.Trim().Length == 0 || modelo.usu_nome == null)
            {
                aviso("O nome do usuário é obrigatório");
            }
            else
            {
                DalUsuario DalUsuario = new DalUsuario(conexao);
                DalUsuario.Incluir(modelo);
            }

        }

        public void Alterar(ModeloUsuario modelo)
        {
            if (modelo.usu_cod <= 0)
            {
                aviso("O código do usuário é obrigatório");
            }
            if (modelo.usu_nome.Trim().Length == 0)
            {
                aviso("O nome do usuário é obrigatório");
            }
            else
            {
                DalUsuario DalUsuario = new DalUsuario(conexao);
                DalUsuario.Alterar(modelo);
            }

        }

        public void Excluir(int codigo)
        {
            DalUsuario DalUsuario = new DalUsuario(conexao);
            DalUsuario.Excluir(codigo);
        }

        public DataTable Localizar(string valor)
        {
            DalUsuario DalUsuario = new DalUsuario(conexao);
            return DalUsuario.Localizar(valor);
        }
        //public DataTable RelatorioCategoria(string categoria, string dtInicio, string dtFim, string produto, string subCategoria)
        //{
        //    DalUsuario DalUsuario = new DalUsuario(conexao);
        //    return DalUsuario.RelatorioCategoria(categoria, dtInicio, dtFim, produto, subCategoria);
        //}

        public bool VerificaUsuario(string login, string senha)
        {
            DalUsuario DalUsuario = new DalUsuario(conexao);
            return DalUsuario.VerificaUsuario(login,senha);
        }

        public bool VerficaLoginCadastrado(string login)
        {
            DalUsuario DalUsuario = new DalUsuario(conexao);
            return DalUsuario.VerficaLoginCadastrado(login);
        }
        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            DalUsuario DalUsuario = new DalUsuario(conexao);
            return DalUsuario.CarregaModeloUsuario(codigo);

        }
    }
}
