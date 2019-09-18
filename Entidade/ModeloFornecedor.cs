using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class ModeloFornecedor
    {
        //Construtor
        public ModeloFornecedor()
        {
            this.ForCod = 0;
            this.ForNome = "";
            this.ForRsocial = "";
            this.ForIe = "";
            this.ForCnpj = "";
            this.ForCep = "";
            this.ForEndereco = "";
            this.ForBairro = "";
            this.ForFone = "";
            this.ForCel = "";
            this.ForEmail = "";
            this.ForEndnumero = "";
            this.ForCidade = "";
            this.ForEstado = "";

        }
        //Construtor
        public ModeloFornecedor(int codigo, string nome, string rsocial, string ie, string cnpj, string cep, string endereco, string bairro, string fone, string cel, string email, string endnumero, string cidade, string estado)
        {
            this.ForCod = codigo;
            this.ForNome = nome;
            this.ForRsocial = rsocial;
            this.ForIe = ie;
            this.ForCnpj = cnpj;
            this.ForCep = cep;
            this.ForEndereco = endereco;
            this.ForBairro = bairro;
            this.ForFone = fone;
            this.ForCel = cel;
            this.ForEmail = email;
            this.ForEndnumero = endnumero;
            this.ForCidade = cidade;
            this.ForEstado = estado;

        }

        public string ForCpf { get; set; }
        private int for_cod;
        private String for_nome;
        private String for_cnpj;
        private String for_ie;
        private String for_rsocial;
        private String for_cep;
        private String for_endereco;
        private String for_bairro;
        private String for_fone;
        private String for_cel;
        private String for_email;
        private String for_endnumero;
        private String for_cidade;
        private String for_estado;

        //Varável criada apenas para utilização da validação na classe bll
        public string tipo { get; set; }
        public string for_observacao { get; set; }
        public DateTime for_cadastro { get; set; }

        public int ForCod
        {
            get
            {
                return for_cod;
            }

            set
            {
                for_cod = value;
            }
        }

        public string ForNome
        {
            get
            {
                return for_nome;
            }

            set
            {
                for_nome = value;
            }
        }

        public string ForCnpj
        {
            get
            {
                return for_cnpj;
            }

            set
            {
                for_cnpj = value;
            }
        }

        public string ForIe
        {
            get
            {
                return for_ie;
            }

            set
            {
                for_ie = value;
            }
        }

        public string ForRsocial
        {
            get
            {
                return for_rsocial;
            }

            set
            {
                for_rsocial = value;
            }
        }

        public string ForCep
        {
            get
            {
                return for_cep;
            }

            set
            {
                for_cep = value;
            }
        }

        public string ForEndereco
        {
            get
            {
                return for_endereco;
            }

            set
            {
                for_endereco = value;
            }
        }

        public string ForBairro
        {
            get
            {
                return for_bairro;
            }

            set
            {
                for_bairro = value;
            }
        }

        public string ForFone
        {
            get
            {
                return for_fone;
            }

            set
            {
                for_fone = value;
            }
        }

        public string ForCel
        {
            get
            {
                return for_cel;
            }

            set
            {
                for_cel = value;
            }
        }

        public string ForEmail
        {
            get
            {
                return for_email;
            }

            set
            {
                for_email = value;
            }
        }

        public string ForEndnumero
        {
            get
            {
                return for_endnumero;
            }

            set
            {
                for_endnumero = value;
            }
        }

        public string ForCidade
        {
            get
            {
                return for_cidade;
            }

            set
            {
                for_cidade = value;
            }
        }

        public string ForEstado
        {
            get
            {
                return for_estado;
            }

            set
            {
                for_estado = value;
            }
        }
    }
}
