using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
  public  class Paragraphe
    {
        public int Id { get; set; }
        public int Numero { get; set; }

        public string Titre { get; set; }

        public string Description { get; set; }

        //Question du paragraphe
        public Question MaQuestion { get; set; }
    }
}
