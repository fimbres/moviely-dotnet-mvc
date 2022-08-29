using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Moviely.Dtos
{
    public class CustomerDto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please give us your name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public bool isSubscribedToNewsLetter { get; set; }
        [Required]
        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }
    }
}
