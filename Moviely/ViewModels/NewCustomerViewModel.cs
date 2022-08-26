using System.Collections;
using System.Collections.Generic;
using Moviely.Models;

namespace Moviely.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MemberShipType> MembershipsTypes { get; set; }
        public Customer Customer { get; set; }
    }
}
