using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class ModeloCliente
    {




        private int cli_cod;
        private String cli_nome;
        private String cli_cpfcnpj;
        private String cli_rgie;
        private String cli_cep;
        private String cli_endereco;
        private String cli_bairro;
        private String cli_fone;
        private String cli_cel;
        public String cli_tipo;
        public string cli_razaoSocial;
        private String cli_email;
        private String cli_endnumero;
        private String cli_cidade;
        private String cli_estado;
       
        public DateTime cli_cadastro { get; set; }
        public string cli_observacao { get; set; }
        public int CliCod
        {
            get
            {
                return cli_cod;
            }

            set
            {
                cli_cod = value;
            }
        }

        public string CliNome
        {
            get
            {
                return cli_nome;
            }

            set
            {
                cli_nome = value;
            }
        }

        public string CliCpfCnpj
        {
            get
            {
                return cli_cpfcnpj;
            }

            set
            {
                cli_cpfcnpj = value;
            }
        }

        public string Clirgie
        {
            get
            {
                return cli_rgie;
            }

            set
            {
                cli_rgie = value;
            }
        }



        public String CliTipo
        {
            get
            {
                return cli_tipo;
            }

            set
            {
                cli_tipo = value;
            }
        }

        public string CliCep
        {
            get
            {
                return cli_cep;
            }

            set
            {
                cli_cep = value;
            }
        }

        public string CliEndereco
        {
            get
            {
                return cli_endereco;
            }

            set
            {
                cli_endereco = value;
            }
        }

        public string CliBairro
        {
            get
            {
                return cli_bairro;
            }

            set
            {
                cli_bairro = value;
            }
        }

        public string CliFone
        {
            get
            {
                return cli_fone;
            }

            set
            {
                cli_fone = value;
            }
        }

        public string CliCel
        {
            get
            {
                return cli_cel;
            }

            set
            {
                cli_cel = value;
            }
        }

        public string CliEmail
        {
            get
            {
                return cli_email;
            }

            set
            {
                cli_email = value;
            }
        }

        public string CliEndnumero
        {
            get
            {
                return cli_endnumero;
            }

            set
            {
                cli_endnumero = value;
            }
        }

        public string CliCidade
        {
            get
            {
                return cli_cidade;
            }

            set
            {
                cli_cidade = value;
            }
        }

        public string CliEstado
        {
            get
            {
                return cli_estado;
            }

            set
            {
                cli_estado = value;
            }
        }

    }
}
