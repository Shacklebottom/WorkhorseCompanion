


namespace CompanionDomain
{
    public class AppDirectory
    {
        public readonly string RootDir = "C:\\ProjectTracking";

        public Project? CurrentProject = null;

        public string DocumentationDir = "";

        public string ExternalDir = "";

        public string InternalDir = "";

        public string ResourceDir = "";

        public string ProjDir = "";

        public string ImgDir = "";

        public string WebDir = "";

        public string DocDir = "";

        public AppDirectory(Project? project = null)
        {
            DocumentationDir = $"{RootDir}\\Documentation";

            ExternalDir = $"{DocumentationDir}\\External Resource";

            InternalDir = $"{DocumentationDir}\\Internal Resource";

            if (project != null)
            {
                CurrentProject = project;

                ResourceDir = $"{RootDir}\\Resources";

                ProjDir = $"{ResourceDir}\\{CurrentProject.Name}";

                ImgDir = $"{ProjDir}\\Images";

                WebDir = $"{ProjDir}\\Websites";

                DocDir = $"{ProjDir}\\Documents";

                CreateResourceDirectory();

                CreateDocumentationDirectory();
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

        private void CreateDocumentationDirectory()
        {
            if (Directory.Exists(DocumentationDir))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(DocumentationDir);

                Directory.CreateDirectory(ExternalDir);

                Directory.CreateDirectory(InternalDir);
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
