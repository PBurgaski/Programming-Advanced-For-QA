using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TeamworkProjects
{
    internal class Teams
    {
        public Teams(string name, string creator)
        {
            TeamName = name;
            User = creator;
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string User { get; set; }
        public List<string> Members { get; set; }
    }
}
