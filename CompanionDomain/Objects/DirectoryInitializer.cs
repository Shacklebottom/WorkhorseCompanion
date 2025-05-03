

using CompanionDomain.Interfaces;

namespace CompanionDomain.Objects
{
    public class DirectoryInitializer(PathBuilder pathbuilder, IDirectoryHandler directoryHandler)
    {
        private readonly PathBuilder _pathBuilder = pathbuilder;
        private readonly IDirectoryHandler _directoryHandler = directoryHandler;


        public async Task InitializeAsync(Project? project)
        {
            _directoryHandler.EnsureDirectoryExists(_pathBuilder.AppDirectory.RootDir);
            _directoryHandler.EnsureDirectoryExists(_pathBuilder.AppDirectory.DocumentationDir);
            _directoryHandler.EnsureDirectoryExists(_pathBuilder.AppDirectory.ExternalDir);
            _directoryHandler.EnsureDirectoryExists(_pathBuilder.AppDirectory.InternalDir);

            await _directoryHandler.EnsureFileExistsAsync(_pathBuilder.AppDirectory.CombinedExternalDir);

            if (project != null)
            {
                _directoryHandler.EnsureDirectoryExists(_pathBuilder.ProjDir);
                _directoryHandler.EnsureDirectoryExists(_pathBuilder.ImgDir);
                _directoryHandler.EnsureDirectoryExists(_pathBuilder.WebDir);
                _directoryHandler.EnsureDirectoryExists(_pathBuilder.DocDir);
                
                await _directoryHandler.EnsureFileExistsAsync(_pathBuilder.CombinedWebDir);
            }
        }
    }
}
