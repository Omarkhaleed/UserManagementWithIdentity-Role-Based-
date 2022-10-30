using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace UserManagementWithIdentity.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromMail = "Omar.Khalid@fci.suezuni.edu.eg";
            var fromPassword = "9112000kh##";


            var message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = subject;
            message.To.Add(email);
            message.Body = $"<html><body>{htmlMessage}</body></html>";
            message.IsBodyHtml = true;
            var stmpClient = new SmtpClient(host: "smtp-mail.outlook.com")
            {
                Port = 587,
                Credentials= new NetworkCredential(fromMail,fromPassword),
                EnableSsl = true

            };

            stmpClient.Send(message);
           
        }
    }
}
