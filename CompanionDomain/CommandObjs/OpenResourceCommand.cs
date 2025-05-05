using CompanionDomain.Interfaces;
using CompanionDomain.Objects;
using ICommand = CompanionDomain.Interfaces.ICommand;

namespace CompanionDomain.CommandObjs
{
    public class OpenResourceCommand(IProcessManager processManager, Action<string, string> displayAction, string args) : ICommand
    {
        private readonly IProcessManager _processManager = processManager;
        private readonly Action<string, string> _displayAction = displayAction;
        private readonly string _args = args;

        public void Execute()
        {
            if (_args == string.Empty) return;

            _displayAction($"{_args} is being opened [...]", "");

            StartInfo start = new($"{_args}", "", null, false, false, useShellExecute: true);

            _processManager.Run(start.Info);
        }
    }
}
