using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace MudBlazorDemo.DTOs
{
    public class UserDTO
    {
        [Required]
        [MaxLength(8, ErrorMessage = "The first name is too long")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Last Name must be 5 chars at least")]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }= DateTime.Now;

        public DateOnly BirthDateOnly
        {
            get => DateOnly.FromDateTime(BirthDate);
            set => BirthDate = value.ToDateTime(new TimeOnly(0, 0));
        }
        [Required]
        [Range(21, 60)]
        public int Age { get; set; }

        [Required]
        public string SSN { get; set; }

        [Required]
        [RegularExpression(@"^\+\d+$", ErrorMessage = "Phone number must start with a + and contain only numbers.")]
         public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Must identify the gender")]
        public  string Gender{ get; set; }

        [Required(ErrorMessage = "Image is required")]
        public IBrowserFile Image { get; set; }

        public int ID { get; set; }

		public string ImageUrl { get; set; }

        public List<AccountDTO> Accounts { get; set; }   
	}


}
