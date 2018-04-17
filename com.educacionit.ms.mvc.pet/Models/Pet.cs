using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace com.educacionit.ms.mvc.pet.Models
{
    public class Pet
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public int Age { get; set; }

        public Boolean Adopt { get; set; }

        public Owner Contact { get; set; }
    }
}