namespace CinemaTickets_201519.Models.Domain
{
    public class TicketInShoppingCart
    {
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public Guid ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
