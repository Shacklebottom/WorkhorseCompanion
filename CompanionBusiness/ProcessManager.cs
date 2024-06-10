
using System.Diagnostics;

namespace CompanionBusiness
{
    public class ProcessManager : IProcessManager
    {
        public string Output { get; private set; } = string.Empty;

        public string Error { get; private set; } = string.Empty;

        public void Run(ProcessStartInfo startInfo, bool waitToExit)
        {

            using (Process process = new())
            {
                process.StartInfo = startInfo;

                process.Start();

                if (waitToExit) { process.WaitForExit(); }

                if (startInfo.RedirectStandardOutput) { Output = process.StandardOutput.ReadToEnd(); }

                if (startInfo.RedirectStandardError) { Error = process.StandardError.ReadToEnd(); }
            }
        }
    }
}
