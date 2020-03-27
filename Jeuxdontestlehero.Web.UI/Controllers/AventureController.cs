using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Core.Data;
using jeudontonestleheros.Core.Data.Models;
using Jeuxdontestlehero.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Jeuxdontestlehero.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        private readonly DefaultContext _context = null;
        public AventureController(DefaultContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            this.ViewBag.Titre = "aventures";
            var query = from item in this._context.Aventure
                        select item;
            return View(query.ToList());
        }
    }
}