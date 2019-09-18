using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Ferramentas
{
    public class EnviodeEmail
    {
        public static void EnviaEmail(string para, string cc, string bcc, string subjetc, string texto, string anexo, string remetente, string senha)
        {
            string[] quantEmail = para.Split(';');
            for (int i = 0; i < quantEmail.Length; i++)
            {
                MailMessage email = new MailMessage();
                //Email da Pessoa que vai Enviar.
                email.From = new MailAddress(remetente);

                //Email do Destinatário
                email.To.Add(new MailAddress(quantEmail[i]));

                //Cria cópia caso haja algo escrito
                if (cc != "")
                {
                    email.CC.Add(new MailAddress(cc));
                }

                //Cria cópia oculta caso haja algo escrito
                if (bcc != "")
                {
                    email.Bcc.Add(new MailAddress(bcc));
                }

                //Informa o Assunto
                email.Subject = subjetc;
                //Campo do Texto, onde vai ficar realmente o conteúdo.
                email.Body = texto;
                //Aceita as tags html ex:(<h1></h1>)
                email.IsBodyHtml = true;

                //Criação do Protocolo de Segurança
                SmtpClient smtp = new SmtpClient();
                //Aqui informa qual o host/Cliente que será usada para o envio de email, ex(smtp.gmail.com,smtp.yahoo.com,smtp.live.com)
                smtp.Host = ("smtp.gmail.com");
                //Aqui informa a porta que será usada para o envio do email, cada host tem uma porta específica
                smtp.Port = 587;

                //Uso do Attachment para anexar algum documento, entre parênteses é passado uma string com o endereço do arquivo ex:(c://Users//document//imagem.jpg)
                if (!String.IsNullOrEmpty(anexo))
                {
                    Attachment anexar = new Attachment(anexo);
                    email.Attachments.Add(anexar);
                }                

                using (smtp)
                {
                    //Informa as Credenciais, aqui passa o email do remetente e a senha, para que o acesso por ser aberto.
                    smtp.Credentials = new System.Net.NetworkCredential(remetente, senha);
                    smtp.EnableSsl = true;
                    try
                    {
                        //Envio enfim do email
                        smtp.Send(email);
                        MessageBox.Show("Email Enviado", "Sucesso de Envio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Email não pode ser enviado. Verifique se usuário e senha foram digitados corretamente,verifique também se você tem acesso a internet,caso o erro persista entre em contato com o desenvolvedor", "Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
