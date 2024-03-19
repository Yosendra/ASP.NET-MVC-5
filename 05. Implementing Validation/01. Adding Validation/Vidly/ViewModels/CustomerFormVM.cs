using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormVM
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}