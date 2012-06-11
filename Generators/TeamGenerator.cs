using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HockeyRpg.Actors;

namespace HockeyRpg.Generators
{
    public class TeamGenerator
    {

        public List<string> listAdjectives;
        public List<string> listNouns;

        private PlayerGenerator playerGenerator;

        private Random random;

        public TeamGenerator()
        {
            // Instantiate the player generator
            playerGenerator = new PlayerGenerator();

            // Create the randomizer
            random = new Random();

            // Create the adjectives list
            listAdjectives = new List<string>();

            listAdjectives.Add("Flaming");
            listAdjectives.Add("Mighty");
            listAdjectives.Add("Icy");
            listAdjectives.Add("Furious");
            listAdjectives.Add("Hardy");
            listAdjectives.Add("Flying");
            listAdjectives.Add("Red");
            listAdjectives.Add("Green");
            listAdjectives.Add("Uber");
            listAdjectives.Add("Rolling");

            // Create the nouns list
            listNouns = new List<string>();

            listNouns.Add("Penguins");
            listNouns.Add("Bears");
            listNouns.Add("Rocks");
            listNouns.Add("Skates");
            listNouns.Add("Fists");
            listNouns.Add("Giants");
            listNouns.Add("Dolphins");
            listNouns.Add("Coats");
            listNouns.Add("Gloves");
            listNouns.Add("Masks");
            listNouns.Add("Squirrels");
            listNouns.Add("Waves");
            listNouns.Add("Tackles");
            listNouns.Add("Fighters");
        }


        public Team GenerateTeam()
        {
            // Instantiate the team
            Team team = new Team();

            // Generate a name for the team
            team.name = GenerateName();

            // Generate the players for the team
            team = GeneratePlayers(team);

            // Return the team
            return team;
        }

        /// <summary>
        /// Generates all the players for the team to start with
        /// </summary>
        /// <param name="team">The team for whom to create the players</param>
        /// <returns>The newly populated team</returns>
        public Team GeneratePlayers(Team team)
        {
            // Add all the players to the list
            team.AddPlayer(playerGenerator.CreatePlayer(PlayingPosition.AttackLeft));
            team.AddPlayer(playerGenerator.CreatePlayer(PlayingPosition.AttackRight));
            team.AddPlayer(playerGenerator.CreatePlayer(PlayingPosition.Center));
            team.AddPlayer(playerGenerator.CreatePlayer(PlayingPosition.DefenceLeft));
            team.AddPlayer(playerGenerator.CreatePlayer(PlayingPosition.DefenceRight));
            team.AddPlayer(playerGenerator.CreatePlayer(PlayingPosition.Goalie));


            // Return the team populated with the new players
            return team;
        }


        /// <summary>
        /// Generates a name for the team from one adjective and one noun, using the words in the respective lists
        /// </summary>
        /// <returns>The name for the team</returns>
        public string GenerateName()
        {
            // Randomize the position for the team
            int position = random.Next(0, listAdjectives.Count);

            // Get the adjective
            string adjective = listAdjectives[position];

            // Randomize the next position
            position = random.Next(0, listNouns.Count);

            // Get the noun
            string noun = listNouns[position];

            // Merge the adjective and the noun to make a name
            string name = adjective + " " + noun;

            // Return the name
            return name;

        }

    }
}
