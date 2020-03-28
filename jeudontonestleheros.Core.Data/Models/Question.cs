using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public int ID { get; set; }

        public string Titre { get; set; }

        public int ParagrapheId { get; set; }

        public List<Reponse> MesReponses { get; set; }
    }
}
