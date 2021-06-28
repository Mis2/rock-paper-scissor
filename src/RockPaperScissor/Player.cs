using System;
namespace RockPaperScissor
{
    public class Player
    {
        public string Name
        {
            get;
            private set;
        }

        public Choice Option
        {
            get;
             set;

        }

        public int Score
        {
            get;
            set;
        }

        public Player (string name)
        {
            Name = name;
            Score = 0;
        }

        public void Scored ()
        {
            Score += 1;
        }
    }
}