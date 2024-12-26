using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersSystem.Data.Models
{
    public class Test
    {

        public int ID { get; set; }

        public string City { get; set; }
        [Required]
        [Range(10,20)]
        public int SSN { get; set; }
        
        public string Contact { get; set; }

    }
}
