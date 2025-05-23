﻿using CompanionDomain.Enums;
using CompanionDomain.Objects;

namespace CompanionDomain.Engines
{
    public class ResourceEngine
    {
        private readonly Resource _projectResource;

        private readonly PathBuilder _pathBuilder;

        private const int _maxFileSize = 5 * 1024 * 1024; //5mb

        public string? ResourceError = null;

        public ResourceEngine(Resource resource, PathBuilder pathBuilder)
        {
            _projectResource = resource;
            _pathBuilder = pathBuilder;



            switch (_projectResource.State)
            {
                case ResourceState.Document:
                    HandleDocument();
                    break;
                case ResourceState.Website:
                    HandleWebsite();
                    break;
                case ResourceState.Image:
                    HandleImage();
                    break;
            }
        }

        private bool MoveToAppDirectory(string appDirectory)
        {
            //this will move a file from its location (such as the downloads folder) to the project's dedicated directory and return true, or
            //this will see that the file is not local, and return false.

            if (!File.Exists(_projectResource.Path)) return false;

            var fileName = _projectResource.Path.Split('\\').Last();

            var itemDir = Path.Combine(appDirectory, fileName);

            File.Move(_projectResource.Path, itemDir);

            return true;
        }

        private async void HandleImage()
        {
            if (MoveToAppDirectory(_pathBuilder.ImgDir)) return;

            using HttpClient client = new();

            try
            {
                client.Timeout = TimeSpan.FromSeconds(30);

                if (!Uri.IsWellFormedUriString(_projectResource.Path, UriKind.Absolute))
                {
                    ResourceError = "Image URL is not valid!";

                    return;
                }

                byte[] image = await client.GetByteArrayAsync(_projectResource.Path);

                if (image.Length > _maxFileSize)
                {
                    ResourceError = "Image file is too large!";

                    return;
                }

                await File.WriteAllBytesAsync($"{_pathBuilder.ImgDir}\\{_projectResource.Name}{_projectResource.FileExtension}", image);
            }
            catch (Exception ex)
            {
                ResourceError = ex.Message;

                return;
            }
        }

        private void HandleWebsite()
        {
            var externalPaths = File.ReadAllLines(_pathBuilder.CombinedWebDir).ToList();

            externalPaths.Add(_projectResource.Path);

            File.WriteAllLines(_pathBuilder.CombinedWebDir, externalPaths);
        }

        private async void HandleDocument()
        {
            if (MoveToAppDirectory(_pathBuilder.DocDir)) return;

            try
            {
                using HttpClient client = new();

                var response = await client.GetAsync(_projectResource.Path);

                if (response.IsSuccessStatusCode)
                {
                    var saveToPathAs = $"{_pathBuilder.DocDir}\\{_projectResource.Name}{_projectResource.FileExtension}";

                    using var fileStream = new FileStream(saveToPathAs, FileMode.Create);

                    await response.Content.CopyToAsync(fileStream);
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
            catch (Exception ex)
            {
                ResourceError = ex.Message;

                return;
            }
        }
    }
}
