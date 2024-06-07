
using System.Diagnostics;

namespace CompanionBusiness
{
    public class ProcessManager : IProcessManager
    {
        public string Output { get; private set; } = string.Empty;

        public string Error { get; private set; } = string.Empty;

        public void Run(ProcessStartInfo startInfo, bool waitToExit)
        {
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            using (Process process = new())
            {
                process.StartInfo = startInfo;

                process.Start();

                if (waitToExit) { process.WaitForExit(); }

                Output = process.StandardOutput.ReadToEnd();

                Error = process.StandardError.ReadToEnd();
            }
        }
    }
}
