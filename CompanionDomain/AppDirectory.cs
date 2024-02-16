
namespace CompanionDomain
{
    public class AppDirectory
    {

        public readonly string rootDir = "C:\\ProjectTracking";

        public Project? CurrentProject { get; set; } = null;

        public string resourceDir { get; set; } = "";

        public string projDir { get; set; } = "";

        public AppDirectory(Project? project = null)
        {
            if (project != null)
            {
                CurrentProject = project;

                resourceDir = $"{rootDir}\\Resources";

                projDir = $"{resourceDir}\\{CurrentProject.Name}";

                CreateResourceDirectory();
            }
            CreateRootDirectory();
        }
        
        private void CreateRootDirectory()
        {
            if (!Directory.Exists(rootDir))
            {
                Directory.CreateDirectory(rootDir);
            }
        }

        private void CreateResourceDirectory()
        {
            if (Directory.Exists(projDir))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(projDir);

                Directory.CreateDirectory($"{projDir}\\Images");

                Directory.CreateDirectory($"{projDir}\\Websites");

                Directory.CreateDirectory($"{projDir}\\Documents");
            }
        }
    }
}
