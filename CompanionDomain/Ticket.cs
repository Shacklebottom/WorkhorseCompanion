
namespace CompanionDomain
{
    public class Ticket
    {
        public string Name = string.Empty;

        public string Description = string.Empty;

        public TicketPriority Priority;

        public TicketType Type;

        public bool Active = true;

        public DateTime TicketStart;

        public DateTime TicketEnd;
    }
}
