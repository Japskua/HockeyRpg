using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HockeyRpg.Actors;
using HockeyRpg.Generators;

namespace HockeyRpg
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create the team generator
            TeamGenerator teamGenerator = new TeamGenerator();

            // Generate the first team
            Team team = teamGenerator.GenerateTeam();

            // Write the outcome
            Console.WriteLine("Team: " + team.name);
            team.ListPlayers();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
