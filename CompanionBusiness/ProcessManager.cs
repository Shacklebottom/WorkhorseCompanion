
using CompanionDomain;
using System.Diagnostics;

namespace CompanionBusiness
{
    public class ProcessManager
    {
        public string Output { get; private set; } = string.Empty;

        public string Error { get; private set; } = string.Empty;

        private Project _currentProject { get; set; }

        public ProcessManager(Project currentProject) 
        {
            _currentProject = currentProject;
        }

        public void Run(string args)
        {
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = "git",
                Arguments = $"{args}",
                WorkingDirectory = $"{_currentProject.Folder}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
            };

            using (Process process = new()) 
            {
                process.StartInfo = info;
                
                process.Start();

                process.WaitForExit();

                Output = process.StandardOutput.ReadToEnd();

                Error = process.StandardError.ReadToEnd();
            }
        }
    }
}
