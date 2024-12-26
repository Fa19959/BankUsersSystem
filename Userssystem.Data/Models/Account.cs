using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersSystem.Data.Models
{
    public class Account
    {
        [Key]
        public int AccountNumber { get; set; }

        [ForeignKey("User")]
        [Required]
        public int UserID { get; set; }

        [Required]
        public string AccountType { get; set; }

        [Required]
        public decimal Balance { get; set; }

        public User User { get; set; }

        [NotMapped]
        public ICollection<Transaction> Transactions { get; set; }
    }
}
