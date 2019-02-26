using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelLandon.Models
{
    

    public class Client : BaseModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public HashSet<Reservation> Reservations { get; set; }
    }

    public class Room : BaseModel
    {
        [Required]
        public int Floor { get; set; }

        [Required]
        public int Number { get; set; }

        public HashSet<Reservation> Reservations { get; set; }
    }

    public class Reservation : BaseModel
    {
        public Client Client { get; set; }
        [Required]
        public int ClientId { get; set; }

        public Room Room { get; set; }
        [Required]
        public int RoomId { get; set; }

        [Required]
        [Display(Name = "Start date")]
        public DateTime Start { get; set; }

        [Required]
        [Display(Name = "End date")]
        public DateTime End { get; set; }
    }

    public class HotelLandonUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class HotelLandonRole : IdentityRole<int>
    {

    }
}