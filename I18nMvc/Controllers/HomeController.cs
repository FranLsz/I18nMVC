using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using I18nMvc.Models;

namespace I18nMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta(Persona model)
        {
            return View();
        }

        public ActionResult Correo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Correo(Correo model)
        {
            var msg = new MailMessage();
            msg.Subject = model.Asunto;
            msg.Body = model.Mensaje;
            msg.To.Add(model.Destino);
            msg.IsBodyHtml = true;

            var stmp = new SmtpClient();

            try
            {
                stmp.Send(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return View();
        }
    }
}