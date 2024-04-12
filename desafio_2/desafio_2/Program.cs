using System;

namespace desafio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Qué tipo de notificación te gustaría usar? (1. Email, 2. Whatsapp, 3. SMS)");
            int tipoNotificacion = Convert.ToInt32(Console.ReadLine());

            if (tipoNotificacion == 1)
            {
                Console.WriteLine("Ingrese la dirección de correo electrónico:");
                string direccionCorreo = Console.ReadLine();
                NotificacionEmail notificacionEmail = new NotificacionEmail(direccionCorreo);
                notificacionEmail.Notifica();
            }
            else if (tipoNotificacion == 2)
            {
                Console.WriteLine("Ingrese el número de teléfono:");
                string numeroTelefono = Console.ReadLine();
                NotificacionWhatsapp notificacionWhatsapp = new NotificacionWhatsapp(numeroTelefono);
                notificacionWhatsapp.Notifica();
            }
            else if (tipoNotificacion == 3)
            {
                Console.WriteLine("Ingrese el número de teléfono:");
                string numeroTelefono = Console.ReadLine();
                NotificacionSMS notificacionSMS = new NotificacionSMS(numeroTelefono);
                notificacionSMS.Notifica();
            }
            else
            {
                Console.WriteLine("Tipo de notificación no reconocido.");
            }
        }
    }

}