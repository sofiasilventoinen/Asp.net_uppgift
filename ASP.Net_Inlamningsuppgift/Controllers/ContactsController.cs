﻿using ASP.Net_Inlamningsuppgift.Models.Forms;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Inlamningsuppgift.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index(string ReturnUrl = null!)
        {
            var form = new ContactForm { ReturnUrl = ReturnUrl ?? Url.Content("~/") };
            return View(form);
        }

        [HttpPost]
        public IActionResult Index(ContactForm form)
        {
            return View();
        }
    }
}
