namespace CompanionDomain.Objects
{
    public class AppDirectory
    {
        //this mthfkr needs to be refactored so badly :O
        //app paths
        public readonly string RootDir = "C:\\ProjectTracking";

        public readonly string PortfolioDir = "C:\\Code_Portfolio";

        public string DocumentationDir = "";

        public readonly string ExternalDocumentation = "External Documents.txt";

        public string ExternalDir = "";

        public string CombinedExternalDir = "";

        public string InternalDir = "";

        //project paths
        public Project? CurrentProject = null;

        public string ResourceDir = "";

        public string ProjDir = "";

        public string ImgDir = "";

        public string WebDir = "";

        public string CombinedWebDir = "";

        public string DocDir = "";

        public AppDirectory(Project? project = null)
        {
            DocumentationDir = $"{RootDir}\\Documentation";

            ExternalDir = $"{DocumentationDir}\\External Resource";

            CombinedExternalDir = $"{ExternalDir}\\{ExternalDocumentation}";

            InternalDir = $"{DocumentationDir}\\Internal Resource";

            if (project != null)
            {
                CurrentProject = project;

                ResourceDir = $"{RootDir}\\Resources";

                ProjDir = $"{ResourceDir}\\{CurrentProject.Name}";

                ImgDir = $"{ProjDir}\\Images";

                WebDir = $"{ProjDir}\\Websites";

                CombinedWebDir = $"{WebDir}\\WebsiteResources.txt";

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

        private async void CreateDocumentationDirectory()
        {
            if (Directory.Exists(DocumentationDir))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(DocumentationDir);

                Directory.CreateDirectory(ExternalDir);

                await File.WriteAllTextAsync(CombinedExternalDir, "");

                Directory.CreateDirectory(InternalDir);
            }
        }

        private async void CreateResourceDirectory()
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

                await File.WriteAllTextAsync(CombinedWebDir, "");

                Directory.CreateDirectory(DocDir);
            }
        }
    }
}
