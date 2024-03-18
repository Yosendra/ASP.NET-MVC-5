namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        /* this treated as foreign key of MembershipType table 
        */
        public byte MembershipTypeId { get; set; }

        /* this is called a navigation property.
         * It allow us to navigate from one type to another
        */
        public MembershipType MembershipType { get; set; }  
    }
}