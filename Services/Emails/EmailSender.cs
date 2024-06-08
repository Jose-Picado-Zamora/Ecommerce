using Entities;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Emails
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(Bill bill)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("smarttechuna@gmail.com"));
            email.To.Add(MailboxAddress.Parse(bill.User.email));
            email.Subject = "SmartTech Bill #" + bill.id;

            var emailBody = $"SMART TECH\n";
            emailBody += $"Order confirmation\t\t\tBill ID: #{bill.id}\n";
            emailBody += $"Date: {bill.date}\n";

            emailBody += $"Customer Name: {bill.User.name}\t\tAddress: {bill.User.address}\n";
            emailBody += "Details:\n\tId\tName\tPrice\t\tQuantity\t\tSubtotal\n";

            foreach (var item in bill.Details)
            {
                emailBody += $"\t{item.ProductId}\t{item.Product.name}\t\t{item.Product.price}\t\t{item.quantity}\t\t\t{item.subtotal}";
                emailBody += $"\n----------------------------------------------------------------------------------\n";
            }
            emailBody += $"\n\n=========================================================\n";

            emailBody += $"TOTAL:\t\t\t\t\t\t\t\t\t\t${bill.total}\n\n";

            email.Body = new TextPart("plain")
            {
                Text = emailBody
            };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("smarttechuna@gmail.com", "ayds lgpg xhuk comt");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
