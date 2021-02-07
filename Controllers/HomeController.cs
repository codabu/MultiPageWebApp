using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiPageWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MultiPageWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController (ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(g => g.Name).ToList();
            return View(contacts);
        }

    }
}
