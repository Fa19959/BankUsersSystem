using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UsersSystem.API.DTOs
{
    public class AccountDto
    {

        public int AccountNumber { get; set; }

        public int UserID { get; set; }

        public string AccountType { get; set; }

        public decimal Balance { get; set; }
    }
}
