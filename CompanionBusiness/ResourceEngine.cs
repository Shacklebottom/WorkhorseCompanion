using CompanionDomain;
using System.Transactions;

namespace CompanionBusiness
{
    public class ResourceEngine
    {
        private AppDirectory AppDirectory;

        public Project CurrentProject { get; private set; }

        private Resource Resource;

        public ResourceEngine(Resource resource, Project project)
        {
            CurrentProject = project;

            Resource = resource;

            AppDirectory = new AppDirectory(CurrentProject);

            switch (Resource.State)
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
            if (!File.Exists(Resource.Path)) return false;

            var fileName = Resource.Path.Split('\\').Last();

            var itemDir = Path.Combine(appDirectory, fileName);

            File.Move(Resource.Path, itemDir);

            Resource.Path = itemDir;

            CurrentProject.Resources.Add(Resource);

            Project.SaveProject(CurrentProject);

            return true;
        }

        private async void HandleImage()
        {
            if (MoveToAppDirectory(AppDirectory.ImgDir)) return;

            

            HttpClient httpClient = new HttpClient();

            HttpResponseMessage message = await httpClient.GetAsync(new Uri(Resource.Path));

            string content = await message.Content.ReadAsStringAsync();
            
        }

        private void HandleWebsite()
        {
            throw new NotImplementedException();
        }

        private void HandleDocument()
        {
            if (MoveToAppDirectory(AppDirectory.DocDir)) return;


        }
    }
}
