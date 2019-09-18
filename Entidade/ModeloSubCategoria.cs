using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class ModeloSubCategoria
    {
        public ModeloSubCategoria()
        {
            this.CatCod = 0;
            this.SCatNome = "";
            this.CatCod = 0;
        }

        public ModeloSubCategoria(int sCatCod, int CatCod, string SCatNome)
        {
            this.CatCod = CatCod;
            this.SCatNome = SCatNome;
            this.SCat_Cod = sCatCod;
        }

        private int SCatCod;
        public DateTime scat_cadastro { get; set; }
        public int SCat_Cod
        {
            get
            {
                return SCatCod;
            }

            set
            {
                SCatCod = value;
            }
        }

        private String sCat_nome;
        public string SCatNome
        {
            get
            {
                return sCat_nome;
            }

            set
            {
                sCat_nome = value;
            }
        }

        private int cat_cod;
        public int CatCod
        {
            get
            {
                return cat_cod;
            }

            set
            {
                cat_cod = value;
            }
        }


    }
}
