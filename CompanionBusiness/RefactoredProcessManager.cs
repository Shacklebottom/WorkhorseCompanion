
using System.Diagnostics;

namespace CompanionBusiness
{
    public class RefactoredProcessManager : IProcessManager
    {
        public string Output { get; set; } = string.Empty;

        public string Error { get; set; } = string.Empty;

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
