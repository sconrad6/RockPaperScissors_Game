using System;
namespace RockPaperScissors_Game
{
    class User : Player
    {

        public User(string userInput, string name)
        {
            RoshamboValue = Validator.RoshamboValidator(userInput);
            Name = name;
        }

        public User(Roshambo choice, string name)
        {
            RoshamboValue = choice;
            Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            return RoshamboValue; 
        }
    }
}
