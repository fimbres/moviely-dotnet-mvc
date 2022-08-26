using System;
using System.ComponentModel.DataAnnotations;

namespace Moviely.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool isSubscribedToNewsLetter { get; set; }
        public MemberShipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
    }
}
