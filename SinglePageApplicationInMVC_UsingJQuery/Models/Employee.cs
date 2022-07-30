using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinglePageApplicationInMVC_UsingJQuery.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]      
        public string FullName { get; set; }


        
        //[DataType(DataType.Password)]   ////performing validation with a regular expression
        [Required]
        public string Password { get; set; }


        //[Required(ErrorMessage = "Email is Requirde")]
        //[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
        //            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
        //            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
        //            ErrorMessage = "Email is not valid")]
        [Required]
        [DataType(DataType.EmailAddress)]   
        public string Email { get; set; }

        //[Required(ErrorMessage = "You must provide a phone number")]
        //[Display(Name = "Home Phone")]
        //[DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Required]
        public string Telephone { get; set; }

        [Required]        
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }

        
        public bool IsActive { get; set; }

        [Required]
        [Display(Name="Country")]
        public int CountryId { get; set; }
        //Here i m set second parameter for validation message in helper class
    }
}