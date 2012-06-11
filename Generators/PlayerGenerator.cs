using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HockeyRpg.Actors;

namespace HockeyRpg.Generators
{
    public class PlayerGenerator
    {
        Random random;
        List<string> firstNames;
        List<string> lastNames;
        List<string> nationalities;

        public PlayerGenerator()
        {
            // Instantiate the random generator
            random = new Random();

            // Create the first names
            firstNames = new List<string>();

            firstNames.Add("Pekka");
            firstNames.Add("Ville");
            firstNames.Add("Oskari");
            firstNames.Add("Ivan");
            firstNames.Add("Igor");
            firstNames.Add("Vladimir");
            firstNames.Add("Jack");
            firstNames.Add("Peter");
            firstNames.Add("Miroslav");
            firstNames.Add("Yuri");
            firstNames.Add("Fidel");
            firstNames.Add("Jorge");
            firstNames.Add("Juan");
            firstNames.Add("Pablo");
            firstNames.Add("Pedro");

            // Create the last names
            lastNames = new List<string>();

            lastNames.Add("Polusladkoij");
            lastNames.Add("Putin");
            lastNames.Add("Lehtinen");
            lastNames.Add("Poutanen");
            lastNames.Add("Virtanen");
            lastNames.Add("Yukovic");
            lastNames.Add("Carter");
            lastNames.Add("Smenjonov");
            lastNames.Add("Jonson");
            lastNames.Add("Rodriguez");
            lastNames.Add("Castro");

            // Create the nationalities
            nationalities = new List<string>();

            nationalities.Add("Finland");
            nationalities.Add("Russia");
            nationalities.Add("Norway");
            nationalities.Add("Slovakia");
            nationalities.Add("Serbia");
            nationalities.Add("Denmark");
            nationalities.Add("USA");
            nationalities.Add("Canada");
            nationalities.Add("Cuba");
        }

        /// <summary>
        /// Creates a player with all the attributes and skills
        /// </summary>
        /// <returns>A newly created fresh player, ready for action ;-)</returns>
        public Player CreatePlayer()
        {
            // Instantiate the new player
            Player player = new Player();

            // Randomly generate the player position
            player.playingPosition = GeneratePlayingPosition();
            
            // Generate name, age and nationality for the player
            player = GenerateAttributes(player);

            // Generate all the skills for the player
            player = GenerateAllSkills(player);

            // Return the final result
            return player;
        }

        /// <summary>
        /// Creates the player with the given position
        /// </summary>
        /// <param name="playingPosition">The position where the player should play</param>
        /// <returns>A newly created, fresh player</returns>
        public Player CreatePlayer(PlayingPosition playingPosition)
        {
            // Instantiate the new player
            Player player = new Player();

            // Set the playing position
            player.playingPosition = playingPosition;

            // Generate name, age and nationality for the player
            player = GenerateAttributes(player);

            // Generate all the skills for the player
            player = GenerateAllSkills(player);

            // Return the final result
            return player;
        }

        /// <summary>
        /// Generates randomly a playing position
        /// </summary>
        /// <returns>The position randomly generated</returns>
        public PlayingPosition GeneratePlayingPosition()
        {

            int position = random.Next(1, 6);

            if (position == 1)
                return PlayingPosition.AttackLeft;
            else if (position == 2)
                return PlayingPosition.AttackRight;
            else if (position == 3)
                return PlayingPosition.Center;
            else if (position == 4)
                return PlayingPosition.DefenceLeft;
            else if (position == 5)
                return PlayingPosition.DefenceRight;
            else
                return PlayingPosition.Goalie;

        }

        /// <summary>
        /// Generates the player attributes [the ones that are not affecting the skills,
        /// but the player more generally, e.g. name]
        /// </summary>
        /// <param name="player">The player whom to generate the attributes</param>
        /// <returns>The player with the newly created attributes</returns>
        public Player GenerateAttributes(Player player)
        {
            player.firstName = GenerateFirstName();
            player.lastName = GenerateLastName();
            player.nationality = GenerateNationality();
            player.age = GenerateAge();

            // Return the attributed player
            return player;
        }

        /// <summary>
        /// Randomly generates the age for the player
        /// </summary>
        /// <returns>The age for the player (between 18 and 40)</returns>
        public int GenerateAge()
        {
            int age = random.Next(18, 40);

            return age;
        }

        /// <summary>
        /// Randomly generates the first name for the player by selecting randomly from the list
        /// of available names
        /// </summary>
        /// <returns>The first name of the player</returns>
        public string GenerateFirstName()
        {
            // Get the random name
            int position = random.Next(0, firstNames.Count);

            // Find the position
            string firstName = firstNames[position];

            // Return the name
            return firstName;

        }


        /// <summary>
        /// Randomly generates a last name for the player from the list of last names
        /// </summary>
        /// <returns>The last name</returns>
        public string GenerateLastName()
        {
            // Get the random position in the lastNames list
            int position = random.Next(0, lastNames.Count);

            // Find the name in that position
            string lastName = lastNames[position];

            // Return the name
            return lastName;
        }

        /// <summary>
        /// Randomly generates a nationality for the player from the list of nationalities
        /// </summary>
        /// <returns>The name of the nationality</returns>
        public string GenerateNationality()
        {
            // Get the random position in the nationalities list
            int position = random.Next(0, nationalities.Count);

            // Find the nationality at that position
            string nationality = nationalities[position];

            // Return the nationality
            return nationality;

        }


        /// <summary>
        /// Generates all the skills of one player according to 
        /// GenerateSkill() settings
        /// </summary>
        /// <param name="player">The player for whom to generate the skills</param>
        /// <returns>The player with generated skill set</returns>
        public Player GenerateAllSkills(Player player)
        {
            // Check if the player is goalie or not 
            // Goalies don't need the same skills as the other
            // players
            if (player.playingPosition == PlayingPosition.Goalie)
            {
                player.goalkeeping = random.Next(30, 100);
            }
            else
            {
                player.goalkeeping = 1;
            }

            // Speed
            player.speed = GenerateSkill();

            // Tackle
            player.tackle = GenerateSkill();

            // Avoid
            player.avoid = GenerateSkill();

            // Pass
            player.pass = GenerateSkill();

            // Shoot
            player.shoot = GenerateSkill();

            // Return the result
            return player;
        }

        /// <summary>
        /// Generates a value for the given skill
        /// </summary>
        /// <returns>A skill number between 1 and 100</returns>
        public int GenerateSkill()
        {
            // Create a random value between 1 and 100
            int value = random.Next(1, 100);

            return value;

        }

    }
}
