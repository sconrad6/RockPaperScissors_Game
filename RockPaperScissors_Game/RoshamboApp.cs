using System;

namespace RockPaperScissors_Game
{
    class RoshamboApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rock, Paper, Scissors game simulator");
            string userName = UserName();
            int gameCount = 0;
            int winCount = 0;
            do
            {
                Player opponent = OpponentSelector();
                Player user = UserPlay(userName);
                Player winner = PlayGame(user, opponent);
                Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                Console.WriteLine($"{opponent.Name}: {opponent.RoshamboValue}");
                if (winner != null)
                {
                    if (winner == user)
                    {
                        winCount++;
                    }
                    Console.WriteLine($"{winner.Name} wins!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
                gameCount++;
            } while (Continue());
            Console.WriteLine($"You won {winCount}/{gameCount} games!!! Go you!!!!!");
        }

        public static string UserName()
        {
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();
            return userName;
        }

        public static Player OpponentSelector()
        {
            Console.WriteLine("Would you like to play against Hank or Carl?");
            string opponent;
            do
            {
                opponent = Console.ReadLine().ToLower();

            } while (!Validator.NameValidator(opponent));

            Player player;
            if(opponent == "hank")
            {
                player = new Hank();
            }
            else 
            {
                player = new Carl();
            }
            return player;
        }

        public static bool Continue()
        {
            Console.WriteLine("Would you like to continue? Y/N");
            string choice = Console.ReadLine().ToLower();
            if (choice == "y" && Validator.ChoiceValidator(choice))
            {
                return true;
            }
            Console.WriteLine("Great! Thanks for playing!");
            return false;
        }

        public static Player UserPlay(string userName)
        {
            Console.WriteLine("Would you like to play rock, paper, or scissors?");
            string userInput;
            Player player;
            while (true)
            {
                userInput = Console.ReadLine().ToLower();
                try
                {
                    player = new User(userInput, userName);
                    break;
                }
                catch (RoshamboException)
                {
                    Console.WriteLine("Invalid play.");
                }
            }
            return player;
        }

        public static Player PlayGame(Player user, Player opponent)
        {
            Roshambo userPlay = user.GenerateRoshambo();
            Roshambo opponentPlay = opponent.GenerateRoshambo();

            if (userPlay == Roshambo.rock && opponentPlay == Roshambo.scissors)
            {
                return user;
            }
            else if (userPlay == Roshambo.scissors && opponentPlay == Roshambo.paper)
            {
                return user;
            }
            else if (userPlay == Roshambo.paper && opponentPlay == Roshambo.rock)
            {
                return user;
            }
            else if (userPlay == opponentPlay)
            {
                return null;
            }
            else
            {
                return opponent;
            }
        }   
    }
}
