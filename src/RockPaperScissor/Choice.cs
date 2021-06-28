using System;
namespace RockPaperScissor
{
    public class Choice
    {
        private Move move;

        public enum Move
        {
            Rock,
            Paper,
            Scissors
        }

        public Choice(Move move)
        {
            this.move = move;
        }

        public static Choice MapStringToMove(string input)
        {
            switch(input.ToUpper())
            {
                case "P":
                    return new Choice(Move.Paper);
                case "R":
                    return new Choice(Move.Rock);
                case "S":
                    return new Choice(Move.Scissors);  
                default:
                    return null;        
            }
        }

        public static Choice MapRandomToMove()
        {
            Random random = new Random();
            int option = random.Next(0,2);

            switch(option)
            {
                case 0:
                    return new Choice(Move.Rock);
                case 1:
                    return new Choice(Move.Paper);
                case 2:
                    return new Choice(Move.Scissors);
                default:
                    return null;    
            }

        }

        public static Move GetWinningMove(Move move)
        {
            switch(move)
            {
                case Move.Paper:
                    return Move.Scissors;
                case Move.Rock:
                    return Move.Paper;
                case Move.Scissors:
                    return Move.Rock; 
                default:
                    return Move.Rock;       
            }
        }

        public static Player GetRoundWinner(Player player1, Player player2)
        {
            if(GetWinningMove(player2.Option.move).Equals(player1.Option.move))
                return player1;
            else if (GetWinningMove(player1.Option.move).Equals(player2.Option.move))
                return player2;
            else
                return null;    
                    
        }

        public static Player GetWinner(Player player1, Player player2)
        {
            if (player1.Score > player2.Score)
                return player1;
            else
                return player2;    
        }

    }
}