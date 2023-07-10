using System.ComponentModel.DataAnnotations;

namespace CinemaTickets_201519.Models.Domain
{
    public class Ticket
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string MovieTitle { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime ValiUntildDate { get; set;
        }
        [Required]
        public int TicketPrice { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCart { get; set; }
    }
}
