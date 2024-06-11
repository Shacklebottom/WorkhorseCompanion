using System.Diagnostics;

namespace CompanionDomain.Interfaces
{
    public interface IProcessManager
    {
        string Output { get; }

        string Error { get; }

        void Run(ProcessStartInfo startInfo, bool waitToExit = false);
    }
}
