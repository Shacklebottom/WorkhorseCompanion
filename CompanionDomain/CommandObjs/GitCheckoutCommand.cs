using CompanionDomain.Interfaces;
using CompanionDomain.Objects;
using ICommand = CompanionDomain.Interfaces.ICommand;

namespace CompanionDomain.CommandObjs
{
    public class GitCheckoutCommand(Project project, IProcessManager processManager, Action<string, string> displayAction, string args) : ICommand
    {
        private readonly Project _project = project;
        private readonly IProcessManager _processManager = processManager;
        private readonly Action<string, string> _displayAction = displayAction;
        private readonly string _args = args;

        public void Execute()
        {
            if (_project.Folder == string.Empty) return;

            StartInfo start = new("git", $"checkout {_args}", _project.Folder);

            _processManager.Run(start.Info);

            _displayAction(_processManager.Output, _processManager.Error);
        }
    }
}
