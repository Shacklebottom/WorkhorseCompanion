using System.Diagnostics;

namespace CompanionBusiness
{
    public interface IProcessManager
    {
        string Output { get; }

        string Error { get; }

        void Run(ProcessStartInfo startInfo, bool waitToExit);
    }
}
