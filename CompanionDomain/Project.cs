
namespace CompanionDomain
{
    public class Project
    {
        public int Id { get; set; } = 0;

        public string? Name { get; set; }

        public string? Folder {  get; set; }

        public Task[]? Tasks { get; set; }
    }
}
