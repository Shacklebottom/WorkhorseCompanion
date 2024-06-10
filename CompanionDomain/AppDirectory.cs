


namespace CompanionDomain
{
    public class AppDirectory
    {
        //app paths
        public readonly string RootDir = "C:\\ProjectTracking";
        
        public string DocumentationDir = "";
        //rename this nonsense!
        public readonly string ExternalDocumentTracking = "External Documents.txt";

        public string TrackingDocument = "";

        public string ExternalDir = "";

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

            TrackingDocument = $"{DocumentationDir}\\{ExternalDocumentTracking}";

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

                File.Create($"{TrackingDocument}");

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
