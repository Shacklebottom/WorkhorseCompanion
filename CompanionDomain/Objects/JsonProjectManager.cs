
using CompanionDomain.Interfaces;
using Newtonsoft.Json;

namespace CompanionDomain.Objects
{
    public class JsonProjectManager : IProjectManager
    {
        public void Save(Project project)
        {
            string json = JsonConvert.SerializeObject(project);

            AppDirectory appDirectory = new();

            File.WriteAllText($@"{appDirectory.RootDir}\{project.Name}.txt", json);
        }

        public void Delete(Project project)
        {
            AppDirectory appDirectory = new();

            File.Delete($@"{appDirectory.RootDir}\{project.Name}.txt");
        }
    }
}
