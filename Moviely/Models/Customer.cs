using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Moviely.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please give us your name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public bool isSubscribedToNewsLetter { get; set; }
        [BindProperty]
        public MemberShipType MembershipType { get; set; }
        [Required]
        public byte MembershipTypeId { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }
    }
}
