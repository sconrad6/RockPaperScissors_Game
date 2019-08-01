using System;
namespace RockPaperScissors_Game
{
    class RoshamboResult 
    {
        public Player User { get; }
        public Roshambo Result { get; }\

        public RoshamboResult(Player user, Roshambo result)
        {
            User = user;
            Result = result;
        }
    }
}
