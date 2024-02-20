using CompanionDomain;
using System.Transactions;

namespace CompanionBusiness
{
    public class ResourceEngine
    {
        private AppDirectory AppDirectory;

        private Project CurrentProject;

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
        private void MoveToAppDirectory(string appDirectory)
        {
            if (!File.Exists(Resource.Path)) return;

            var fileName = Resource.Path.Split('\\').Last();

            var itemDir = Path.Combine(appDirectory, fileName);

            File.Move(Resource.Path, itemDir);
        }

        private void HandleImage()
        {
            MoveToAppDirectory(AppDirectory.ImgDir);
            
        }



        private void HandleWebsite()
        {
            throw new NotImplementedException();
        }

        private void HandleDocument()
        {
            MoveToAppDirectory(AppDirectory.DocDir);
        }
    }
}
