using System;
namespace RockPaperScissors_Game
{
    class Carl : Player
    {
        public Carl()
        {
            Name = "Carl";
        }
        public int NumberGenerator()
        {
            Random randomNum = new Random();
            return randomNum.Next(1, 4);
        }

        public override Roshambo GenerateRoshambo()
        {
            switch (NumberGenerator())
            {
                case 1:
                    RoshamboValue = Roshambo.rock;
                    break;
                case 2:
                    RoshamboValue = Roshambo.paper;
                    break;
                case 3:
                    RoshamboValue = Roshambo.scissors;
                    break;
                default:
                    RoshamboValue = Roshambo.rock;
                    break;
            }

            return RoshamboValue;
        }
    }
}
