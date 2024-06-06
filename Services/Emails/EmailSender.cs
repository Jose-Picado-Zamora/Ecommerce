using Entities;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services.Emails
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail()
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("smarttechuna@gmail.com"));
            email.To.Add(MailboxAddress.Parse("camposcalvo1@gmail.com"));
            email.Subject = "Test Email";
            email.Body = new TextPart(TextFormat.Html) { Text = "HOla mubndo" };
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("smarttechuna@gmail.com", "ayds lgpg xhuk comt");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
