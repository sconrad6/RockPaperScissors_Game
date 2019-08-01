using System;
namespace RockPaperScissors_Game
{
    class Hank : Player
    {
        public Hank()
        {
            Name = "Hank";
            RoshamboValue = Roshambo.rock;
        }

        // this player should always select rock
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
