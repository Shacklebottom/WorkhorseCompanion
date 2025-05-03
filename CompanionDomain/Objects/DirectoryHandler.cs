

using CompanionDomain.Interfaces;

namespace CompanionDomain.Objects
{
    public class DirectoryHandler : IDirectoryHandler
    {
        public void EnsureDirectoryExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public async Task EnsureFileExistsAsync(string path)
        {
            if (!File.Exists(path))
            {
                var dir = Path.GetDirectoryName(path);

                if (dir == null) return;
                
                if (string.IsNullOrEmpty(dir)) Directory.CreateDirectory(dir);

                await File.WriteAllTextAsync(path, "");
            }
        }
    }
}
