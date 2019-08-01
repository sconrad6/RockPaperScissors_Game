using System;
namespace RockPaperScissors_Game
{
    abstract class Player
    {
        public string Name { get; set; }
        public Roshambo RoshamboValue { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
