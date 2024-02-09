
using Newtonsoft.Json;

namespace CompanionDomain
{
    public class Project
    {
        public string? Name { get; set; }

        public string? Folder { get; set; }

        public string? Solution { get; set; }

        public List<Task> Tasks { get; set; } = new();
    
        public static void SaveProject(Project project)
        {
            string json = JsonConvert.SerializeObject(project);

            File.WriteAllText($@"C:\ProjectTracking\{project.Name}.txt", json);
        }
    }
}
