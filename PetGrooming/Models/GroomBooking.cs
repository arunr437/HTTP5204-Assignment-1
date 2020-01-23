using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomBooking
    {
        /*
            A GroomBooking is an agreement between an owner and a groomer to provide services for a pet
            
            Some things that describe a GroomBooking
                - A date and time
                - Price
            
            A GroomBooking must reference
                - A Groomer
                - A Pet
                - An Owner
                - A list of GroomServices
                
        */
        [Key]
        public int GroomBookingID { get; set; }

        public DateTime BookingDate { get; set; }
        public int Price { get; set; }

        public ICollection<GroomService> GroomServices { get; set; }
        public ICollection<Groomer> Groomers { get; set; }
        public ICollection<Owner> Owners { get; set; }
        public ICollection<Pet> Pets { get; set; }



        //Trying to map one to many relationship between GroomBooking and GroomServices
        public int GroomServiceID { get; set; }
        [ForeignKey("GroomServiceID")]
        public virtual GroomService GroomService { get; set; }

        //Trying to map one to many relationship between GroomBooking and Groomer
        public int GroomerID { get; set; }
        [ForeignKey("GroomerID")]
        public virtual Groomer Groomer { get; set; }

        //Trying to map one to many relationship between GroomBooking and Owners
        public int OwnerID { get; set; }
        [ForeignKey("OwnerID")]
        public virtual Owner Owner { get; set; }

        //Trying to map one to many relationship between GroomBooking and Pets
        public int PetID { get; set; }
        [ForeignKey("PetID")]
        public virtual Pet Pet { get; set; }


    }
}