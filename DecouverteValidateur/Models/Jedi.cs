﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DecouverteValidateur.Models
{
    public class Jedi
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Le nom doit être renseigné")]
        public string Name { get; set; }
        //entre 1 et 3M
        [Range(1,300, ErrorMessage ="La taille est en cm,elle doit être comprise entre 1 et 300 cm")]
        public int Size { get; set; }
    }
}
