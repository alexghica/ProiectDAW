using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int FacultateId { get; set; }
        public Facultate Facultate { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
