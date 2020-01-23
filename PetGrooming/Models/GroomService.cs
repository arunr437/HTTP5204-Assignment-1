using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomService
    {
        /*
            A GroomService is a type of activity that a Groomer can do for a pet. Some examples might be nail clipping, shampoo, trim, etc.
            
            Some things that describe a GroomService
                - Service Name
                - Cost
                - Duration
         */
        [Key]
        public int GroomerServiceID { get; set; }

        public string ServiceName { get; set; }
        public int Cost { get; set; }
        public int Duration { get; set; }

        public int GroomerID { get; set; }
        [ForeignKey("GroomerID")]
        public virtual Groomer Groomer { get; set; }
    }
}