using System;
using System.ComponentModel.DataAnnotations;

namespace Moviely.Dtos
{
    public class MovieDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }
        [Required, MaxLength(15)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [Required, MaxLength(15)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }
        [Required]
        [Range(1, 50)]
        public long numberInStock { get; set; }

    }
}
