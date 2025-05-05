using CompanionDomain.Objects;
using CompanionDomain.Interfaces;
using ICommand = CompanionDomain.Interfaces.ICommand;

namespace CompanionDomain.CommandObjs
{
    public class GitStatusCommand(Project project, IProcessManager processManager, Action<string, string> displayAction) : ICommand
    {
        private readonly Project _project = project;

        private readonly IProcessManager _processManager = processManager;

        private readonly Action<string, string> _displayAction = displayAction;

        public void Execute()
        {
            if (_project.Folder == string.Empty) return;

            StartInfo start = new("git", "status", _project.Folder);

            _processManager.Run(start.Info);

            _displayAction(_processManager.Output, _processManager.Error);
        }
    }
}
