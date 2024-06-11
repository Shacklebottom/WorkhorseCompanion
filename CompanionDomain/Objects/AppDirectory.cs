namespace CompanionDomain.Objects
{
    public class AppDirectory
    {
        //app paths
        public readonly string RootDir = "C:\\ProjectTracking";

        public readonly string PortfolioDir = "C:\\Code_Portfolio";

        public string DocumentationDir = "";

        public readonly string ExternalDocumentation = "External Documents.txt";

        public string ExternalDir = "";

        public string CombinedExternalPath = "";

        public string InternalDir = "";

        //project paths
        public Project? CurrentProject = null;

        public string ResourceDir = "";

        public string ProjDir = "";

        public string ImgDir = "";

        public string WebDir = "";

        public string DocDir = "";

        public AppDirectory(Project? project = null)
        {
            DocumentationDir = $"{RootDir}\\Documentation";

            ExternalDir = $"{DocumentationDir}\\External Resource";

            CombinedExternalPath = $"{ExternalDir}\\{ExternalDocumentation}";

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
            }
            CreateRootDirectory();

            CreateDocumentationDirectory();
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

                File.Create($"{CombinedExternalPath}");

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
