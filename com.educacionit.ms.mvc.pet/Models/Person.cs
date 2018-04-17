using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace com.educacionit.ms.mvc.pet.Models
{
    public class Person
    {
        [Display(Name = "Name", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceType = typeof(Resources),
                  ErrorMessageResourceName = "NameRequired")]
        [StringLength(50, ErrorMessageResourceType = typeof(Resources),
                          ErrorMessageResourceName = "NameLong")]
        public string Name { get; set; }

        [Display(Name = "Phone", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceType = typeof(Resources),
                  ErrorMessageResourceName = "PhoneRequired")]
        [StringLength(15, ErrorMessageResourceType = typeof(Resources),
                          ErrorMessageResourceName = "PhoneLong")]
        public string Phone { get; set; }

        [Display(Name = "Address", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceType = typeof(Resources),
                  ErrorMessageResourceName = "AddressRequired")]
        [StringLength(50,ErrorMessageResourceType = typeof(Resources),
                         ErrorMessageResourceName = "AddressLong")]

        public String Address { get; set; }

        [Display(Name = "Age", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceType = typeof(Resources),
                  ErrorMessageResourceName = "AgeRequired")]
        [Range(0, 130, ErrorMessageResourceType = typeof(Resources),
                       ErrorMessageResourceName = "AgeRange")]
        public int Age { get; set; }


        [Display(Name = "Email", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceType = typeof(Resources),
                  ErrorMessageResourceName = "EmailRequired")]
        [RegularExpression(".+@.+\\..+", ErrorMessageResourceType = typeof(Resources),
                                         ErrorMessageResourceName = "EmailInvalid")]
        public string Email { get; set; }

        [Display(Name = "ChooseYourLanguage", ResourceType = typeof(Resources))]
        public String ChooseYourLanguage { get; set; }

        [Display(Name = "Enter", ResourceType = typeof(Resources))]
        
        public String Enter { get; set; }

        [Display(Name = "Clean", ResourceType = typeof(Resources))]

        public String Clean { get; set; }
    }
}