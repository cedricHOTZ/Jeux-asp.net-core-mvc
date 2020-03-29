using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Core.Data;
using jeudontonestleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeuxdontonestleheros.Backoffice.WEB.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        private DefaultContext _context = null;
       public ParagrapheController(DefaultContext context)
        {
            this._context = context;
        }
        public IActionResult index()
        {
            
            return this.View();
        }
        public IActionResult Create()
        {
            return this.View();
        }
        //Ajout d'un paragraphe
        [HttpPost]
        public IActionResult Create(Paragraphe paragraphe)
        {
            //Vérification avant enregistrement en BDD coté server 
            if (this.ModelState.IsValid)
            {
                this._context.Paragraphes.Add(paragraphe);
                this._context.SaveChanges();
            }
            return this.View();
        }
        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;

            paragraphe = this._context.Paragraphes.First(item => item.Id == id);
            return this.View(paragraphe);
        }

        //Modification du paragraphe
        [HttpPost]
        public IActionResult Edit(Paragraphe paragraphe)
        {
            this._context.Paragraphes.Update(paragraphe);

          

            this._context.SaveChanges();
            return this.View(paragraphe);
        }
    }
}