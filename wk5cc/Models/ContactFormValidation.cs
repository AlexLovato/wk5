using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace wk5cc.Models
{
    //create a partial class for contact form so we can connect the validation properties with MetaData
    [MetadataType(typeof(ContactFormValidation))]
    public partial class contact
    {

    }
    public class ContactFormValidation
    { 
        [Required, Display(Name="First Name"), MaxLength(50)]
        public string FirstName { get; set; }
        [Required, Display(Name = "Last Name"), MaxLength(50)]
        public string LastName { get; set; }
        [Required, Display(Name = "Phone Number"), MaxLength(50)]
        public string PhoneNumber { get; set; }
        [Required, Display(Name = "Company Name"), MaxLength(50)]
        public string CompanyName { get; set; }
        [Required, Display(Name = "Email Address"), MaxLength(50)]
        public string Email { get; set; }
        [Required, Display(Name = "Project Description"), MaxLength(250)]
        public string ProjectDescription { get; set; }
         [Required, Display(Name = "Comments"), MaxLength(250)]
        public string Comment { get; set; }
    }
}