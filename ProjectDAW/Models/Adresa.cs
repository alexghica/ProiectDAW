using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Models
{
    public class Adresa
    {
        [Key]
        public int AdresaId { get; set; }
        public int FacultateId { get; set; }
        public Facultate Facultate { get; set; }
        public string AdresaName { get; set; }

    }
}
