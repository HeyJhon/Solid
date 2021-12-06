using System;
using System.Net;
using System.Net.Mail;

namespace Solid{

public class Correo{
      public void SendEmail(double resultado){

            string FROM = Credenciales.USER;
            string FROMNAME = "Figuras felices";
            string TO = Credenciales.EMAILTO;

            string SMTP_USERNAME = Credenciales.USER;
            string SMTP_PASSWORD = Credenciales.PASSWORD;

            string HOST = "smtp.gmail.com";
            int PORT = 587;

            string SUBJECT = "Resultado de la operación";

            // The body of the email
            string BODY = $"Este es el resultado de la operacion Area de la Figura: {resultado}";

            // Create and build a new MailMessage object
            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            message.From = new MailAddress(FROM, FROMNAME);
            message.To.Add(new MailAddress(TO));
            message.Subject = SUBJECT;
            message.Body = BODY;

            using (var client = new System.Net.Mail.SmtpClient(HOST, PORT))
            {
                client.Credentials = new NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);

               client.EnableSsl = true;

                try
                {
                    client.Send(message);
                    Console.WriteLine("Email enviado");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Email no enviado");
                    Console.WriteLine("Detalle del error: " + ex.Message);
                }
            }
    }

}
}