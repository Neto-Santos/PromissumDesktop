using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Ferramentas
{
   public class enviaSMS
    {
        public static void enviaSms(String telefone, String mensagem)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                MailMessage message = new MailMessage();
                smtp.Credentials = new NetworkCredential("usuario", "senha");
                smtp.Host = "ipipi.com";
                message.From = new MailAddress(String.Format("{0}@ipipi.com", "usuario"));
                message.To.Add(string.Format("{0}@sms.ipipi.com", "telefone"));
                message.Subject = "Lembrete de Visita Betel";
                message.Body = "mensagem";
                smtp.Send(message);
                MessageBox.Show("Mensagem Enviada!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar Enviar a Mensagem");

            }
           
        }
        

    }
}
