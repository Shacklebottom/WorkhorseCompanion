
using CompanionDomain.Objects;

namespace CompanionDomain.Interfaces
{
    public interface IProjectManager
    {
        void Save(Project project);
        void Delete(Project project);
    }
}
