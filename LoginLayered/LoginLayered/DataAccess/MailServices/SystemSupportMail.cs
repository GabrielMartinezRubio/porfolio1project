using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailServices
{
    internal class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "AQUI PONES EL CORREO DESDE EL QUE SE RECUPERAN LAS CONTRASEÑAS";
            password = "AQUI PONES TU CONTRASEÑA";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
