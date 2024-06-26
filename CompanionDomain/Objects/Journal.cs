
namespace CompanionDomain.Objects
{
    public class Journal
    {
        public int Id { get; set; } = 0;

        public string Page { get; set; } = "";

        public DateTime EntryDate { get; set; } = new DateTime();

        public int Commits { get; set; }

        public int Lines { get; set; }
    }
}
