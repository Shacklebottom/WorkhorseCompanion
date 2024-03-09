﻿
namespace CompanionDomain
{
    public class Ticket
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public TicketPriority Priority { get; set; }

        public TicketType Type { get; set; }

        public bool Active { get; set; } = true;

        public DateTime TicketStart { get; set; }

        public DateTime TicketEnd { get; set; }
    }
}
