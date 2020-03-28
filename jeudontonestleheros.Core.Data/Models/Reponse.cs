using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    [Table("Reponse")]
    public class Reponse
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }
    
        public int QuestionId { get; set; }
    }

}
