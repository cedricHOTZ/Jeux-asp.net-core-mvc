using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    [Table("Paragraphe")]
    public class Paragraphe
    {
        public int Id { get; set; }
        public int Numero { get; set; }

        public string Titre { get; set; }

        public string Description { get; set; }

        //Question du paragraphe
        [NotMapped]
        public Question MaQuestion { get; set; }
    }
}
