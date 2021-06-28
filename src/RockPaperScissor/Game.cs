using System;
namespace RockPaperScissor
{
   public class Game
    {
        private Player humanPlayer;
        private Player koala;

        private static PrintUtil printUtil = new PrintUtil();


        public void StartGame()
        {
            printUtil.Greetings();
            var name = printUtil.GetOpponentName();
            humanPlayer = new Player(name);
            koala = new Player("koala");
            var rounds = printUtil.GetRounds();
            var winningScore = rounds / 2 + 1;
            printUtil.StartGameMessage(humanPlayer);
            
            var roundCounter = 0;
            Player winner;
            while(roundCounter < rounds)
            {   
                roundCounter += 1;
                var humanChoice = printUtil.MakeSelection();
                humanPlayer.Option = humanChoice;
                koala.Option = Choice.MapRandomToMove();
                var roundWinner = Choice.GetRoundWinner(humanPlayer,koala);
                if (roundWinner != null)
                {
                    roundWinner.Scored();
                    Console.WriteLine($"{roundWinner.Name} won this round.");
                }
                else
                    Console.WriteLine("This round is a draw!!");    
                if (roundWinner != null && roundWinner.Score == winningScore)
                    break;
            }
            winner = Choice.GetWinner(humanPlayer,koala);
            Console.WriteLine($"{winner.Name} won the game!!");        

        }
    }
    
}