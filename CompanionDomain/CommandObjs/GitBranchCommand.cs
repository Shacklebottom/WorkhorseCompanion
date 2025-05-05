using CompanionDomain.Interfaces;
using CompanionDomain.Objects;
using System.Reflection.Metadata.Ecma335;
using ICommand = CompanionDomain.Interfaces.ICommand;


namespace CompanionDomain.CommandObjs
{
    public class GitBranchCommand(Project project, IProcessManager processManager, Action<string, string>? displayAction = null) : ICommand
    {
        private readonly Project _project = project;
        private readonly IProcessManager _processManager = processManager;
        private readonly Action<string, string>? _displayAction = displayAction;
        public List<string> Branches = [];

        public void Execute()
        {
            if (_project.Folder == string.Empty) return;

            StartInfo start = new("git", "branch", _project.Folder);

            _processManager.Run(start.Info);

            _displayAction?.Invoke(_processManager.Output, _processManager.Error);

            Branches = new List<string>(_processManager.Output.Split("\n"));
        }
    }
}
