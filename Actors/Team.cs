using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HockeyRpg.Actors
{
    public class Team
    {
        // Team name
        public string name { get; set; }

        // List of the players
        private List<Player> listPlayers;


        /// <summary>
        /// Constructor
        /// </summary>
        public Team()
        {
            // Initialize the team
            listPlayers = new List<Player>();
        }

        /// <summary>
        /// Loops through all the players and writes their information to the Console output
        /// </summary>
        public void ListPlayers()
        {
            // Loop through all the players in the list
            foreach (Player player in listPlayers)
            {
                Console.WriteLine(player.playingPosition.ToString());
                Console.WriteLine("\t" + player.GetFullName());
                Console.WriteLine("\t" + player.nationality);
                Console.WriteLine("\t" + player.age);
                player.DisplaySkills();
            }     
        }

        /// <summary>
        /// Adds the player to the list of playing characters
        /// Checks that the same type of player does not exist
        /// </summary>
        /// <param name="player">The player that is added to the team</param>
        public void AddPlayer(Player player)
        {
            // Find, if the list already contains a player with position
            // of the player that is tried to add
            if (FindPlayerByPosition(player.playingPosition) != null)
                throw new NotImplementedException("Should report an error here: Not possible to add player of this type" +
                    "as it already exists in the list!");

            // Otherwise, keep on going
            listPlayers.Add(player);


        }


  

        /// <summary>
        /// Finds the player according to the defined position
        /// </summary>
        /// <param name="position">The position the player is supposed to play</param>
        /// <returns>The player object if result is found</returns>
        public Player FindPlayerByPosition(PlayingPosition position)
        {
            // Set the player to null
            Player player = null;

            // Loop through all the players
            foreach (Player playerPosition in listPlayers)
            {
                // If the player position matches
                if (playerPosition.playingPosition.Equals(position))
                {
                    // Set the position to be the one given
                    player = playerPosition;
                }
            }


            // Return the player
            return player;

        }

    }
}
