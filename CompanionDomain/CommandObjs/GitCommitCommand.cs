
using CompanionDomain.Interfaces;
using CompanionDomain.Objects;
using ICommand = CompanionDomain.Interfaces.ICommand;

namespace CompanionDomain.CommandObjs
{
    public class GitCommitCommand(Project project, IProcessManager processManager, Action<string, string> displayAction, string capturedInput) : ICommand
    {
        private readonly Project _project = project;
        private readonly IProcessManager _processManager = processManager;
        private readonly Action<string, string> _displayAction = displayAction;
        private readonly string _capturedInput = capturedInput;

        public void Execute()
        {
            if (_project.Folder == string.Empty) return;

            StartInfo start = new("git", "add .", _project.Folder);

            _processManager.Run(start.Info);

            start.Info.Arguments = $"commit -m\"{_capturedInput}\"";

            _processManager.Run(start.Info);

            _displayAction(_processManager.Output, _processManager.Error);
        }
    }
}
