﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionConcoursCore.Models
{
    public class Epreuves
    {
        public int ID { get; set; }
        [Required]
        public string Matiere { get; set; }
        [Required]
        public string Annee { get; set; }
        [Required]
        public string NomFichier { get; set; }
    }
}
