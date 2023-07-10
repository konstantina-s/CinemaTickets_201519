using CinemaTickets_201519.Models.Identity;

namespace CinemaTickets_201519.Models.Domain
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }

        public string OwnerId { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCart{ get; set; }

        public CinemaTicketUser Owner { get; set; }

        public int Quantity { get; set; }
    }
}
