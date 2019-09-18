using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Sdk;
using Microsoft.SqlServer.Management.Smo;

namespace Ferramentas
{
    public class Backup
    {
        public static void BackupBanco(string servidor, string banco)
        {
            var server = new Server(servidor);
            var backup = new Microsoft.SqlServer.Management.Smo.Backup();
            backup.Database = banco;
            backup.Incremental = false;
            string nomeArquivoBackup = string.Format("{0}_{1:yyyyMMdd_HHmmss}.bak", banco, DateTime.Now);
            backup.Devices.AddDevice(nomeArquivoBackup, Microsoft.SqlServer.Management.Smo.DeviceType.File);
            backup.SqlBackup(server);
            MessageBox.Show(string.Format("Backup '{0}' concluído com sucesso.", nomeArquivoBackup), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void RestaurarBanco(string servidor, string banco, string physical_device_name,string friendlyName)
        {
            var server = new Server(servidor);
            var restore = new Microsoft.SqlServer.Management.Smo.Restore();
            restore.Database = banco;
            restore.Devices.AddDevice(physical_device_name, Microsoft.SqlServer.Management.Smo.DeviceType.File);
            server.KillAllProcesses(banco);
            restore.SqlRestore(server);
            MessageBox.Show(string.Format("Backup '{0}' restaurado com sucesso.", friendlyName), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DataTable listarBackup(string servidor, string banco)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(string.Format(DAL.DadosConexao.stringConexao)))
            {
                DataTable tabela = new DataTable();
                connection.Open();

                using (var command = new System.Data.SqlClient.SqlCommand(
                    "SELECT physical_device_name FROM msdb.dbo.backupmediafamily " +
                    "INNER JOIN msdb.dbo.backupset ON msdb.dbo.backupmediafamily.media_set_id = msdb.dbo.backupset.media_set_id " +
                    "WHERE (msdb.dbo.backupset.database_name LIKE @DatabaseName)", connection))
                {
                    command.Parameters.AddWithValue("DatabaseName", banco);

                    var reader = command.ExecuteReader();
                    tabela.Load(reader);

                    //backupsComboBox.DataSource = table;
                    //backupsComboBox.DisplayMember = "FriendlyName";
                    //backupsComboBox.ValueMember = "physical_device_name";

                }

                return tabela;
            }
        }

    }
}


