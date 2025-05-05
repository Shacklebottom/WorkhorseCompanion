using CompanionDomain.Interfaces;
using CompanionDomain.Objects;
using ICommand = CompanionDomain.Interfaces.ICommand;

namespace CompanionDomain.CommandObjs
{
    public class GitBashCommand(Project project, IProcessManager processManager, Action<string, string> displayAction) : ICommand
    {
        private readonly Project _project = project;
        private readonly IProcessManager _processManager = processManager;
        private readonly Action<string, string> _displayAction = displayAction;

        public void Execute()
        {
            if (_project.Folder == string.Empty) return;

            StartInfo start = new("C:\\Program Files\\Git\\git-bash.exe", args: "", _project.Folder, false, false);

            _processManager.Run(start.Info);

            var displayOutput = "The Bash terminal is being opened [...]";

            _displayAction(displayOutput, "");
        }
    }
}
