using Newtonsoft.Json;

namespace CompanionDomain
{
    public class Project
    {
        public string Name { get; set; } = string.Empty;

        public string Folder { get; set; } = string.Empty;

        public string Solution { get; set; } = string.Empty;

        public List<Ticket> Tickets { get; set; } = new();
    
        public static void SaveProject(Project project)
        {
            string json = JsonConvert.SerializeObject(project);

            AppDirectory appDirectory = new AppDirectory(project);

            File.WriteAllText($@"{appDirectory.RootDir}\{project.Name}.txt", json);
        }

        public static void DeleteProject(Project project)
        {
            AppDirectory appDirectory = new AppDirectory();

            File.Delete($@"{appDirectory.RootDir}\{project.Name}.txt");
        }
    }
}
