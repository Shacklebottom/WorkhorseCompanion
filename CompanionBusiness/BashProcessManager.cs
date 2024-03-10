
using CompanionDomain;

namespace CompanionBusiness
{
    public class BashProcessManager(Project currentProject) : ProcessManager(currentProject)
    {
        protected override string FileName => "C:\\Program Files\\Git\\git-bash.exe";
    }
}

