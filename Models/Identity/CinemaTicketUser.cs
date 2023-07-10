using CinemaTickets_201519.Models.Domain;

namespace CinemaTickets_201519.Models.Identity
{
    public class CinemaTicketUser : Microsoft.AspNetCore.Identity.IdentityUser

    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set;}

        public virtual ShoppingCart UserCart{ get; set; }

    }
}
