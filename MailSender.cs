using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Windows;
using MVC.Controllers;
using MVC.Models;

namespace MVC.Models
{
    public class MailSender
    {
        public void SendMail()
        {
            string host = "smtp.gmail.com";
            SmtpClient client = new SmtpClient(host, 587);
            client.Credentials = new NetworkCredential("jablonskidawid0202@gmail.com","Dawid02021999");
            client.EnableSsl = true;
            MailAddress from = new MailAddress("jablonskidawid0202@gmail.com");

            MailAddress to = new MailAddress("dawidjablonski@op.pl");
            MailMessage message = new MailMessage(from, to);
            message.Body = "This is a test email message please don't answer";
            message.Subject = "E-Mail testowy";
            client.Send(message);
            client.Dispose();
            



        }
    }
}