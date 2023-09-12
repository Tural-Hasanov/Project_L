using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Project_L.ValidationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_L.Controllers
{
    public class SendMessageController : Controller
    {
        
        public IActionResult Index()
        {
            using var c = new Context();
            ViewBag.AboutAdress = c.Abouts.Select(x => x.AboutAdress).FirstOrDefault();
            ViewBag.AboutEmailAdress = c.Abouts.Select(x => x.AboutEmailAdress).FirstOrDefault();
            ViewBag.AboutPhoneNumber = c.Abouts.Select(x => x.AboutPhoneNumber).FirstOrDefault();
            return View();
        }
                
        [HttpGet]
        public IActionResult SendMessageTo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessageTo(MessageFromExternal p)
        {
            SendMessageValidation mes = new SendMessageValidation();
            ValidationResult result = mes.Validate(p);
            if (result.IsValid)
            {
                using (var c = new Context())
                {

                    c.Add(new MessageFromExternal()
                    {
                        MessageFromExternalName = p.MessageFromExternalName,
                        MessageFromExternalEmail = p.MessageFromExternalEmail,
                        MessageFromExternalSubject = p.MessageFromExternalSubject,
                        MessageFromExternalContent = p.MessageFromExternalContent

                    });
                    c.SaveChanges();
                }
                return RedirectToAction("Index", "SendMessage");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View("Index");

        }

    }
}
