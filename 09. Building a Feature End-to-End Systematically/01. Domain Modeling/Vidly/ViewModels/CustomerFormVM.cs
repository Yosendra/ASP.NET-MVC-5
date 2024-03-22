using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormVM
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string Title 
        { 
            get => Customer != null && Customer.Id != 0 
                ? "Edit Customer"
                : "New Customer"; 
        }
    }
}