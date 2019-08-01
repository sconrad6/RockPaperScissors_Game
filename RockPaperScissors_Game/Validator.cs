using System;
namespace RockPaperScissors_Game
{
    class Validator
    {
        public static bool NameValidator(string userInput)
        {
            if (userInput == "hank" || userInput == "carl")
            {
                return true;
            }

            Console.WriteLine("Invalid name");
            return false;
        }

        public static bool ChoiceValidator(string userInput)
        {
            if (userInput == "y" || userInput == "n")
            {
                return true;
            }
            Console.WriteLine("Invalid response");
            return false;
        }

        public static Roshambo RoshamboValidator(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "rock":
                    return Roshambo.rock;
                case "paper":
                    return Roshambo.paper;
                case "scissors":
                    return Roshambo.scissors;
                default:
                    throw new RoshamboException();
            }
        }
    }
}
