using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MesqPremiersTestsAvecEntityCodeFirst
{
    //Pour lui dire que la table est Droide dans la BDD si différent
    [Table("Droide")]
    public class Droide
    {
        public int Id { get; set; }
       // public Arme arme { get; set; }

        public string Matricule { get; set; }
    }
}
