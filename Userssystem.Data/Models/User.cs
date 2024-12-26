using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersSystem.Data.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Address { get; set; }

        public string SSN { get; set; }
        [Required]
        public string Contact { get; set; } 

        [NotMapped]
        public ICollection<Account> Accounts { get; set; }
    }
}
