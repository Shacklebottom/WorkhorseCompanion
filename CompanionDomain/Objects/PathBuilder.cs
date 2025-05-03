
namespace CompanionDomain.Objects
{
    public class PathBuilder
    {
        public readonly PathConfig AppDirectory;

        public readonly Project? CurrentProject = null;

        public readonly string ResourceDir = "";

        public readonly string ProjDir = "";

        public readonly string ImgDir = "";

        public readonly string WebDir = "";

        public readonly string DocDir = "";

        public static string WebsiteResources => "WebsiteResources.txt";

        public readonly string CombinedWebDir = "";

        public PathBuilder(PathConfig config, Project? project = null)
        {
            AppDirectory = config;
            CurrentProject = project;

            if (CurrentProject == null) return;

            ResourceDir = Path.Combine(AppDirectory.RootDir, "Resources");
            ProjDir = Path.Combine(ResourceDir, CurrentProject.Name);
            ImgDir = Path.Combine(ProjDir, "Images");
            WebDir = Path.Combine(ProjDir, "Websites");
            DocDir = Path.Combine(ProjDir, "Documents");
            CombinedWebDir = Path.Combine(WebDir, WebsiteResources);
        }
    }
}
