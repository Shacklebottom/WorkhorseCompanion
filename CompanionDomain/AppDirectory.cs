

namespace CompanionDomain
{
    public class AppDirectory
    {

        public readonly string RootDir = "C:\\ProjectTracking";

        public Project? CurrentProject { get; set; } = null;

        public string ResourceDir { get; set; } = "";

        public string ProjDir { get; set; } = "";

        public string ImgDir { get; set; } = "";

        public string WebDir { get; set; } = "";

        public string DocDir { get; set; } = "";

        public AppDirectory(Project? project = null)
        {
            if (project != null)
            {
                CurrentProject = project;

                ResourceDir = $"{RootDir}\\Resources";

                ProjDir = $"{ResourceDir}\\{CurrentProject.Name}";

                ImgDir = $"{ProjDir}\\Images";

                WebDir = $"{ProjDir}\\Websites";

                DocDir = $"{ProjDir}\\Documents";

                CreateResourceDirectory();
            }
            CreateRootDirectory();
        }

        private void CreateRootDirectory()
        {
            if (!Directory.Exists(RootDir))
            {
                Directory.CreateDirectory(RootDir);
            }
            else return;
        }

        private void CreateResourceDirectory()
        {
            if (Directory.Exists(ProjDir))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(ProjDir);

                Directory.CreateDirectory(ImgDir);

                Directory.CreateDirectory(WebDir);

                Directory.CreateDirectory(DocDir);
            }
        }
    }
}
