using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_2
{
    public class NotificacionEmail : INotificable
    {
        public string DireccionCorreo { get; set; }

        public NotificacionEmail(string direccionCorreo)
        {
            DireccionCorreo = direccionCorreo;
        }

        public void Notifica()
        {
            Console.WriteLine($"Enviando notificación por correo electrónico a {DireccionCorreo}");
        }
    }

    public class NotificacionWhatsapp : INotificable
    {
        public string NumeroTelefono { get; set; }

        public NotificacionWhatsapp(string numeroTelefono)
        {
            NumeroTelefono = numeroTelefono;
        }

        public void Notifica()
        {
            Console.WriteLine($"Enviando notificación por WhatsApp al número {NumeroTelefono}");
        }
    }

    public class NotificacionSMS : INotificable
    {
        public string NumeroTelefono { get; set; }

        public NotificacionSMS(string numeroTelefono)
        {
            NumeroTelefono = numeroTelefono;
        }

        public void Notifica()
        {
            Console.WriteLine($"Enviando notificación por SMS al número {NumeroTelefono}");
        }
    }


}
