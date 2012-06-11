using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HockeyRpg.Actors
{
    public enum PlayingPosition
    {
        Goalie,
        DefenceLeft,
        DefenceRight,
        AttackLeft,
        AttackRight,
        Center
    }


    public class Player
    {

        // Attributes
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nationality { get; set; }
        public int age { get; set; }

        public PlayingPosition playingPosition { get; set; }

        // Skills
        public int speed { get; set; }
        public int tackle { get; set; }
        public int avoid { get; set; }
        public int pass { get; set; }
        public int shoot { get; set; }
        public int goalkeeping { get; set; }
        

        // Level & EXP
        public int level { get; set; }
        public int experience { get; set; }

        public Player()
        {
            // Set the basics
            level = 1;
            experience = 0;


        }

        public void DisplaySkills()
        {
            Console.WriteLine("\t\tGoalkeeping: " + goalkeeping + "\tSpeed: " + speed);
            Console.WriteLine("\t\tAvoid: " + avoid + "\tTackle: " + tackle);
            Console.WriteLine("\t\tShoot: " + shoot + "\tPass: " + pass);
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
}
