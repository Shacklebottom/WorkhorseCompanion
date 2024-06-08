


namespace CompanionDomain
{
    public class AppDirectory
    {
        public readonly string RootDir = "C:\\ProjectTracking";

        public Project? CurrentProject = null;

        public string UtilityDir = "";

        public string ResourceDir = "";

        public string DocumentationDir = "";

        public string MusicDir = "";

        public string ProjDir = "";

        public string ImgDir = "";

        public string WebDir = "";

        public string DocDir = "";

        public AppDirectory(Project? project = null)
        {
            if (project != null)
            {
                CurrentProject = project;

                UtilityDir = $"{RootDir}\\Utility";

                ResourceDir = $"{RootDir}\\Resources";

                DocumentationDir = $"{UtilityDir}\\Documentation";

                MusicDir = $"{UtilityDir}\\Music";

                ProjDir = $"{ResourceDir}\\{CurrentProject.Name}";

                ImgDir = $"{ProjDir}\\Images";

                WebDir = $"{ProjDir}\\Websites";

                DocDir = $"{ProjDir}\\Documents";

                CreateResourceDirectory();

                CreateUtilityDirectory();
            }
            CreateRootDirectory();
        }

        private void CreateRootDirectory()
        {
            if (Directory.Exists(RootDir))
            {
                return;    
            }
            else
            {
                Directory.CreateDirectory(RootDir);
            }
        }

        private void CreateUtilityDirectory()
        {
            if (Directory.Exists(UtilityDir))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(UtilityDir);

                Directory.CreateDirectory(DocumentationDir);

                Directory.CreateDirectory(MusicDir);
            }
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
