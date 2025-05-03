
namespace CompanionDomain.Interfaces
{
    public interface IDirectoryHandler
    {
        void EnsureDirectoryExists(string path);

        Task EnsureFileExistsAsync(string path);
    }
}
