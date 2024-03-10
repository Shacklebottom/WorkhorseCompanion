
using CompanionDomain;
using System.Diagnostics;

namespace CompanionBusiness
{
    public class ProcessManager
    {
        public string Output { get; private set; } = string.Empty;

        public string Error { get; private set; } = string.Empty;

        private Project _currentProject { get; set; }
        
        #region THESE METHODS CAN BE OVERRIDDEN
        protected virtual string FileName { get; set; } = "";

        protected virtual bool RedirectStandardOutput { get; set; } = false;

        protected virtual bool RedirectStandardError { get; set; } = false;

        protected virtual bool CreateNoWindow { get; set; } = false;
        #endregion

        public ProcessManager(Project currentProject)
        {
            _currentProject = currentProject;
        }

        public void Run(string args, bool wait = false)
        {
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = $"{FileName}",
                Arguments = $"{args}",
                WorkingDirectory = $"{_currentProject.Folder}",
                RedirectStandardOutput = this.RedirectStandardOutput,
                RedirectStandardError = this.RedirectStandardError,
                CreateNoWindow = this.CreateNoWindow
            };

            using (Process process = new())
            {
                process.StartInfo = info;
                
                process.Start();

                if (wait) { process.WaitForExit(); }

                if (RedirectStandardOutput) { Output = process.StandardOutput.ReadToEnd(); }

                if (RedirectStandardError) { Error = process.StandardError.ReadToEnd(); }
            }
        }
    }
}
