using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MudBlazorDemo.DTOs
{
    public class AccountDTO
    {
        public int AccountNumber { get; set; }

        public int UserID { get; set; }

        public string AccountType { get; set; }

        public decimal Balance { get; set; }
    }
}
