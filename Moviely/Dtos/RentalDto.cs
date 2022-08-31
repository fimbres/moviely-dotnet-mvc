using System.Collections.Generic;

namespace Moviely.Dtos
{
    public class RentalDto
    {
        public int CustomerID { get; set; }
        public List<int> MoviesID { get; set; }

    }
}
