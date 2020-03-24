using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace jeuxdontonestleheros.Backoffice.WEB.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        public IActionResult Create()
        {
            return this.View();
        }
    }
}