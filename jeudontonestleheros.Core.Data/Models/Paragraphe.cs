using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    //Table en BDD
    [Table("Paragraphe")]
    public class Paragraphe
    {
        [Key]
        public int Id { get; set; }
        public int Numero { get; set; }

        public string Titre { get; set; }

        public string Description { get; set; }

        //Question du paragraphe
       
        public Question MaQuestion { get; set; }
    }
}
