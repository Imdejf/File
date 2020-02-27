using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("Contact");
        }

        public ActionResult Privacy()
        {
            
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult cosss()
        {
            MessageBox.Show("Hello, world.");

            return View();
        }

        public ActionResult Smail()
        {
            MailSender mailsender = new MailSender();
            mailsender.SendMail();
            return View("Index");


        }
    }
}
