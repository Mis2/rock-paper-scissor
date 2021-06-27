using System;
namespace RockPaperScissors
{
    public class Player
    {
        public string Name
        {
            get;
            private set;
        }

        public Move Handsign
        {
            get;
            private set;

        }

        public Player (string name)
        {
            Name = name;
        }
    }
}