using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace UsersSystem.Services.Services
{
    public class EmailService : IEmailService
    {
       

        private readonly string SenderEmail;
        private readonly string Password;

        public EmailService(IConfiguration configuration)
        {
            var emailSettings = configuration.GetSection("EmailSettings");
            SenderEmail = emailSettings["SenderEmail"];
            Password = emailSettings["Password"];
        }
        public Task SendEmailAsync(string receiverEmail, string subject, string message)
            {
                var client = new SmtpClient("smtp-mail.outlook.com", 587)
                {
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(SenderEmail, Password)
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(SenderEmail),
                    Subject = subject,
                    Body = message,
                    IsBodyHtml = true, // Set to true if the message contains HTML
                };
                mailMessage.To.Add(receiverEmail);

                return client.SendMailAsync(mailMessage);
            }
        

    }
}
