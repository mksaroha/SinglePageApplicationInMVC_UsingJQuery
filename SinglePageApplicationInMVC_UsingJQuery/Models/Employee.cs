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
        [Required(ErrorMessage ="Please Enter Name")]
        public string FullName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        [Display(Name="Country")]
        public int CountryId { get; set; }
    }
}