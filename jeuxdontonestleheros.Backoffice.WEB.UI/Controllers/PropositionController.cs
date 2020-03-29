using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Core.Data;
using jeudontonestleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeuxdontonestleheros.Backoffice.WEB.UI.Controllers
{
    public class PropositionController : Controller
    {
        private DefaultContext _context = null;
        public PropositionController(DefaultContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            this.SetQuestionList();
            return View();
        }
        [HttpPost]
        public IActionResult Add(Reponse reponse)
        {
            if (this.ModelState.IsValid)
            {
                this._context.Reponses.Add(reponse);
                this._context.SaveChanges();
            }
            this.ViewBag.QuestionList = this._context.Questions.ToList();
            return View(reponse);
        }
        private void SetQuestionList()
        {
            this.ViewBag.QuestionList = this._context.Questions.ToList();
        }
    }
}