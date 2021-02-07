using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPageWebApp.Models
{
    public class Contact
    {
        [Required]
        [Key]
        public int ContactId { get; set; }

        [Required (ErrorMessage ="Please enter a name")]
        [StringLength(50, ErrorMessage ="Maximum length of name = 50 characters")]
        public string Name { get; set; }

        [Required (ErrorMessage ="Please enter a phone number")]
        [StringLength(10, ErrorMessage ="Maximum ten digits for a phone number. No hyphens or brackets required.")]
        public string Number { get; set; }


        public string Address { get; set; }

        public string Note { get; set; }


    }
}
