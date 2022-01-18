using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Models
{
    public class Facultate
    {
        [Key]
        public int FacultateId { get; set; }
        public string Nume { get; set; }
        public Adresa Adresa { get; set; }
        public ICollection<User> Useri { get; set; }
    }
}
