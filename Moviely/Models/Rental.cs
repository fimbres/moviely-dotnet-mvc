namespace Moviely.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Movie Movie { get; set; }
        public System.DateTime DateRented { get; set; }
        public System.DateTime? DateReturned { get; set; }
    }
}
