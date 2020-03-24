using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jeuxdontestlehero.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.Titre = "aventures";
            this.ViewBag.MonTableau = new int[] { 1, 2, 3, 4 };
            return View();
        }
    }
}