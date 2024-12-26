using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersSystem.Data.Models
{
    public class Transaction
    {
        public Transaction()
        {
            Timestamp = DateTime.Now;
        }

        [Key]
        
        public int TransactionID { get; set; }

        [ForeignKey("SenderAccount")]
        [Required]
        public int AccountNumber { get; set; }

        [ForeignKey("ReceiverAccount")]       
        public int BeneficiaryNumber { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string TransactionType { get; set; }

        public DateTime Timestamp { get; set; }

        public Account SenderAccount { get; set; }
        public Account ReceiverAccount { get; set; }

    }
}
