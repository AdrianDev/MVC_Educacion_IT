using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace com.educacionit.ms.mvc.pet.Models
{
    public class Pet
    {

        [Display(Name = "NameP", ResourceType = typeof(Resources))]

        public string NameP { get; set; }

        [Display(Name = "Description", ResourceType = typeof(Resources))]

        public string Description { get; set; }

        [Display(Name = "AgePet", ResourceType = typeof(Resources))]

        public int AgePet { get; set; }

        public Boolean Adopt { get; set; }

        public Owner Contact { get; set; }

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
        [StringLength(50, ErrorMessageResourceType = typeof(Resources),
                         ErrorMessageResourceName = "AddressLong")]

        public String Address { get; set; }

        [Display(Name = "Email", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceType = typeof(Resources),
                  ErrorMessageResourceName = "EmailRequired")]
        [RegularExpression(".+@.+\\..+", ErrorMessageResourceType = typeof(Resources),
                                         ErrorMessageResourceName = "EmailInvalid")]
        public string Email { get; set; }
    }
}