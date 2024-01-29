using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanionDomain
{
    public class Task
    {
        public int Id { get; set; } = 0;

        public string? Name { get; set; }

        public string? Description { get; set; }

        public TaskPriority Priority { get; set; }

        public TaskType Type { get; set; }

        public bool Active { get; set; } = true;

        public DateTime TaskStart { get; set; }

        public DateTime TaskEnd { get; set; }
    }
}
