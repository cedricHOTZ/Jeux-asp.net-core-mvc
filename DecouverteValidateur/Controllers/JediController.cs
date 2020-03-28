using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DecouverteValidateur.Controllers
{
    public class JediController : Controller
    {
        //GET
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Models.Jedi jedi)
        {
            if (ModelState.IsValid)
            {
                //Je pourrai aller enregistrer en BDD
            }
            return this.View(jedi);
        }
    }
}