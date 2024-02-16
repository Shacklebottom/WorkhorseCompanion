using CompanionDomain;
using System.Transactions;

namespace CompanionBusiness
{
   public class ResourceEngine
    {
        public Project? CurrentProject { get; set; } = null;
        public ResourceEngine(Resource resource, Project project)
        {
            CurrentProject = project;

            switch (resource.State)
            {
                case ResourceState.Document: HandleDocument();
                    break;
                case ResourceState.Website: HandleWebsite();
                    break;
                case ResourceState.Image: HandleImage();
                    break;
            }
        }

        private void HandleImage()
        {
            throw new NotImplementedException();
        }

        private void HandleWebsite()
        {
            throw new NotImplementedException();
        }

        private void HandleDocument()
        {
            throw new NotImplementedException();
        }
    }
}
