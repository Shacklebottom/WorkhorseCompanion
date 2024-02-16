using Newtonsoft.Json;

namespace CompanionDomain
{
    public class Project
    {
        public string? Name { get; set; }

        public string? Folder { get; set; }

        public string? Solution { get; set; }

        public List<Resource> Resources { get; set; } = new();

        public List<Ticket> Tickets { get; set; } = new();
    
        public static void SaveProject(Project project)
        {
            string json = JsonConvert.SerializeObject(project);

            File.WriteAllText($@"C:\ProjectTracking\{project.Name}.txt", json);
        }

        public static void DeleteProject(Project project)
        {
            File.Delete($@"C:\ProjectTracking\{project.Name}.txt");
        }
    }
}
