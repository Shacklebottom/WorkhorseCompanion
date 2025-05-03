
using CompanionDomain.Objects;

namespace CompanionDomain.Interfaces
{
    public interface IProjectManager
    {
        void Save(Project project, PathBuilder pathBuilder);
        void Delete(Project project, PathBuilder pathBuilder);
        Project Load(string path);
    }
}
