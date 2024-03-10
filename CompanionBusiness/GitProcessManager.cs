using CompanionDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanionBusiness
{
    public class GitProcessManager(Project currentProject) : ProcessManager(currentProject)
    {
        protected override string FileName => "git";

        protected override bool RedirectStandardOutput => true;

        protected override bool RedirectStandardError => true;

        protected override bool CreateNoWindow => true;
    }
}
