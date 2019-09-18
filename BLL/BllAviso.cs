using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace BLL
{
    public abstract class BllAviso
    {
        public static void aviso(string mensagem)
        {
            PopupNotifier aviso = new PopupNotifier();
            aviso.TitleText = "Aviso";
            aviso.ContentText = mensagem;
            aviso.Popup();
        }
    }
}
