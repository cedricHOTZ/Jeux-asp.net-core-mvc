using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Core.Data;
using jeudontonestleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeuxdontonestleheros.Backoffice.WEB.UI.Controllers
{
    public class QuestionController : Controller
    {
        private DefaultContext _context = null;
        public QuestionController(DefaultContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            this.ViewBag.ParagrapheList = this._context.Paragraphes.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Add(Question question)
        {
            if (this.ModelState.IsValid)
            {
                this._context.Questions.Add(question);
                this._context.SaveChanges();
            }
            this.ViewBag.ParagrapheList = this._context.Paragraphes.ToList();
            return View(question);
        }
    }
}