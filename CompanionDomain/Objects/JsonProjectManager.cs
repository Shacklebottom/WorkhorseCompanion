
using CompanionDomain.Interfaces;
using Newtonsoft.Json;

namespace CompanionDomain.Objects
{
    public class JsonProjectManager : IProjectManager
    {
        public void Save(Project project, PathBuilder pathBuilder)
        {
            string json = JsonConvert.SerializeObject(project);

            File.WriteAllText($@"{pathBuilder.AppDirectory.RootDir}\{project.Name}.txt", json);
        }

        public void Delete(Project project, PathBuilder pathBuilder)
        {
            File.Delete($@"{pathBuilder.AppDirectory.RootDir}\{project.Name}.txt");
        }

        public Project Load(string path)
        {
            string json = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<Project>(json) ?? throw new Exception("Project JSON was null");
        }
    }
}
