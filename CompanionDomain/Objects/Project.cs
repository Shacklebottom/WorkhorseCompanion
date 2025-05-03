using Newtonsoft.Json;

namespace CompanionDomain.Objects
{
    public class Project
    {
        public string Name = string.Empty;

        public string Folder = string.Empty;

        public string Solution = string.Empty;

        public List<Ticket> Tickets = [];

        public List<Journal> Journal = [];

        //public static void SaveProject(Project project)
        //{
        //    string json = JsonConvert.SerializeObject(project);

        //    AppDirectory appDirectory = new();

        //    File.WriteAllText($@"{appDirectory.RootDir}\{project.Name}.txt", json);
        //}

        //public static void DeleteProject(Project project)
        //{
        //    AppDirectory appDirectory = new();

        //    File.Delete($@"{appDirectory.RootDir}\{project.Name}.txt");
        //}
    }
}
