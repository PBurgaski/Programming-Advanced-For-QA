namespace _03.TeamworkProjects
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int count = int.Parse(Console.ReadLine());
            List<Teams> teams = new List<Teams>();
            string[] userAndTeam;
            // Logic & Rules
            for (int i = 0; i < count; i++)
            {
                userAndTeam = Console.ReadLine()
                                     .Split("-");
                string user = userAndTeam[0];
                string teamName = userAndTeam[1];
                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(t => t.User == user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
                else
                {
                    Teams currentTeam = new Teams(teamName, user);
                    teams.Add(currentTeam);
                    Console.WriteLine($"Team {teamName} has been created by {user}!");
                }
            }
            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                userAndTeam = input.Split("->");
                string user = userAndTeam[0];
                string teamName = userAndTeam[1];
                if (!teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(t => t.Members.Contains(user)) || teams.Any(t => t.User == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Teams memberToAdd = teams.First(t => t.TeamName == teamName);
                    memberToAdd.Members.Add(user);
                }
                input = Console.ReadLine();
            }
            List<Teams> teamsWithMembers = teams.Where(t => t.Members.Count > 0)
                                              .OrderByDescending(t => t.Members.Count)
                                              .ThenBy(t => t.TeamName)
                                              .ToList();
            List<Teams> teamsWithoutMembers = teams.Where(t => !t.Members.Any())
                                                   .OrderBy(t => t.TeamName)
                                                   .ToList();
            // Output
            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.User}");

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            if (teamsWithoutMembers.Any())
            {
                foreach (var team in teamsWithoutMembers)
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }
    }
}