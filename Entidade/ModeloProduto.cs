using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
   public  class ModeloProduto
    {
        //Construtor Foto Nula (Não Existe)
        public ModeloProduto()
        {
            this.ProCod = 0;
            this.ProNome = "";
            this.ProDescricao = "";
            //this.ProFoto = "";
            this.ProValorpago = 0;
            this.ProValorvenda = 0;
            this.ProQtde = 0;
            this.UmedCod ="" ;
            this.CatCod = 0;
            this.ScatCod = 0;

        }

        //Construtor Recebe a foto passando a string ProFoto para o método Carrega Imagem
       

        //Construtor recebe a foto já pelo array de bytes
        public ModeloProduto(int proCod, String proNome, String proDescricao, string proFoto, Double proValorPago, Double proValorVenda, Double proQtde, string umedCod, int catCod, int sCatCod)
        {
            this.ProCod = proCod;
            this.ProNome = proNome;
            this.ProDescricao = proDescricao;
            this.ProFoto = proFoto;
            this.ProValorpago = proValorPago;
            this.ProValorvenda = proValorVenda;
            this.ProQtde = proQtde;
            this.umed_cod = umedCod;
            this.CatCod = catCod;
            this.ScatCod = sCatCod;

        }

        private int pro_cod;
        private String pro_nome;
        private String pro_descricao;
        private string pro_foto;
        private Double pro_valorpago;
        private Double pro_valorvenda;
        private Double pro_qtde;
        private string umed_cod;
        private int cat_cod;
        private int scat_cod;
        public string pro_ref { get; set; }
        public int for_cod { get; set; }
        public DateTime pro_cadastro { get; set; }
        public string localizacao { get; set; }

        public int ProCod
        {
            get
            {
                return pro_cod;
            }

            set
            {
                pro_cod = value;
            }
        }

        public string ProNome
        {
            get
            {
                return pro_nome;
            }

            set
            {
                pro_nome = value;
            }
        }

        public string ProDescricao
        {
            get
            {
                return pro_descricao;
            }

            set
            {
                pro_descricao = value;
            }
        }

        public string ProFoto
        {
            get
            {
                return pro_foto;
            }

            set
            {
                pro_foto = value;
            }
        }

        public double ProValorpago
        {
            get
            {
                return pro_valorpago;
            }

            set
            {
                pro_valorpago = value;
            }
        }

        public double ProValorvenda
        {
            get
            {
                return pro_valorvenda;
            }

            set
            {
                pro_valorvenda = value;
            }
        }

        public double ProQtde
        {
            get
            {
                return pro_qtde;
            }

            set
            {
                pro_qtde = value;
            }
        }

        public string UmedCod
        {
            get
            {
                return umed_cod;
            }

            set
            {
                umed_cod = value;
            }
        }

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

        public int ScatCod
        {
            get
            {
                return scat_cod;
            }

            set
            {
                scat_cod = value;
            }
        }

       public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                {
                    return;
                }
                else
                {
                    //Fornece propriedades e métodos de instância para criar, copiar
                    //excluir,mover, e abrir arquivos, e ajuda na criação de objetos FileStream.
                    FileInfo arqImagem = new FileInfo(imgCaminho);
                    //Expõe um Stream ao redor de um arquivo de suporte.
                    //Síncrono e assíncrono operações de leitura e gravação.
                    FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                    //Aloca memória para o vetor.
                    //this.ProFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                    //Lê um bloco de bytes do fluxo e grava os dados em um buffer fornecido
                    //int iBytesRead = fs.Read(this.ProFoto, 0, Convert.ToInt32(arqImagem.Length));
                    fs.Close();
                }
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
