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
        [Range(1,999999, ErrorMessage ="Le numéro est requis")]
        public int Numero { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Le titre est requis")]
        public string Titre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Le description est requis")]
        public string Description { get; set; }

        //Question du paragraphe
       
        public Question MaQuestion { get; set; }
    }
}
