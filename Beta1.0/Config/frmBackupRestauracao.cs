using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta1._0.Config
{
    public partial class frmBackupRestauracao : Form
    {
        public frmBackupRestauracao()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                Ferramentas.Backup.BackupBanco(txtServidor.Text, txtBanco.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Ferramentas.Backup.RestaurarBanco(txtServidor.Text, txtBanco.Text, cbBanco.SelectedValue.ToString(), cbBanco.SelectedText.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBackupRestauracao_Activated(object sender, EventArgs e)
        {
            cbBanco.DataSource = Ferramentas.Backup.listarBackup(txtServidor.Text, txtBanco.Text);
            cbBanco.DisplayMember = "FriendlyName";
            cbBanco.ValueMember = "physical_device_name";
        }
    }
}
