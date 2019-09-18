using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promissum.NFS_e
{
    public partial class frmNFSe : Form
    {
        nfse nfse = null;
        public frmNFSe()
        {
            InitializeComponent();
            this.nfse = new nfse();
        }
       

        private void frmNFSe_Load(object sender, EventArgs e)
        {
            if (nfse.ProxyNFSe.ComponenteNFSe == null)
                throw new Exception("Favor ligar o componente ProxyNFSe ao componente NFSe");

            Text = "Tecnospeed NFSe - Versão: " + nfse.NFSe.Versao;
           

        }

        private void CbCertificado_DropDown(object sender, EventArgs e)
        {
            string Certificados;
            string[] vetor = null;

            Certificados = this.nfse.NFSe.ListarCertificados();

            if (Certificados != null)
            {
                vetor = Certificados.Split('|');
                cbCertificado.Items.Clear();

                foreach (string _cert in vetor)
                {
                    cbCertificado.Items.Add(_cert);
                }
            }
        }
    }
}
