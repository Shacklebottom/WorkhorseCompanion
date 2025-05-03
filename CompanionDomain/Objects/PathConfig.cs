
namespace CompanionDomain.Objects
{
    public class PathConfig
    {
        public string RootDir { get; init; } = "C:\\ProjectTracking";

        public static string PortfolioDir => "C:\\Code_Portfolio";

        public static string LibraryDir => "C:\\Code_Library";
        
        public string DocumentationDir => Path.Combine(RootDir, "Documentation");
        
        public static string ExternalDocumentation => "External Documents.txt";
        
        public string ExternalDir => Path.Combine(DocumentationDir, "External Resource");
        
        public string CombinedExternalDir => Path.Combine(ExternalDir, ExternalDocumentation);
        
        public string InternalDir => Path.Combine(DocumentationDir, "Internal Resource");
    }
}
