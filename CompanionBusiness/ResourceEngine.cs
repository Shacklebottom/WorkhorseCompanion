using CompanionDomain;

namespace CompanionBusiness
{
    public class ResourceEngine
    {
        private readonly AppDirectory _appDirectory;

        private Project CurrentProject { get; set; }

        private readonly Resource _projectResource;

        public ResourceEngine(Resource resource, Project project)
        {
            CurrentProject = project;

            _projectResource = resource;

            _appDirectory = new AppDirectory(CurrentProject);

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
            if (!File.Exists(_projectResource.Path)) return false;

            var fileName = _projectResource.Path.Split('\\').Last();

            var itemDir = Path.Combine(appDirectory, fileName);

            File.Move(_projectResource.Path, itemDir);

            return true;
        }

        private async void HandleImage()
        {
            if (MoveToAppDirectory(_appDirectory.ImgDir)) return;

            

            HttpClient httpClient = new HttpClient();

            HttpResponseMessage message = await httpClient.GetAsync(new Uri(_projectResource.Path));

            string content = await message.Content.ReadAsStringAsync();
            
        }

        private void HandleWebsite()
        {
            throw new NotImplementedException();
        }

        private void HandleDocument()
        {
            if (MoveToAppDirectory(_appDirectory.DocDir)) return;


        }
    }
}
