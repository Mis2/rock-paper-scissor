using System;
namespace RockPaperScissor
{
    class PrintUtil
    {
        public void Greetings()
        {
            Console.WriteLine("Welcome to the game of Rock-Paper-Scissor!!! \n Currently I support only 3 options, i.e, Rock, Paper and Scissor. \n Also, currently this can be played in single player versus computer mode only.");
            Console.WriteLine("I am improving, so please stay tuned. Enjoy the game!!!");

        }

        public string GetOpponentName()
        {
            var ctr = 0;
            string name;
            do
            {
                if (ctr == 0)
                    {
                        Console.WriteLine("Hi I am Koala. I will be your opponent for the game. May I know your name?");
                        name = Console.ReadLine();
                    }
                else
                {
                    Console.WriteLine("Oops! Didn't get you..Please enter your name");
                    name = Console.ReadLine();
                } 
                ctr += 1;       

            } while(String.IsNullOrEmpty(name));

            return name;

        }

        public int GetRounds()
        {
            Console.WriteLine("Enter number of rounds");
            var input = Console.ReadLine();
            int n = Int32.Parse(input);
            return n;

        }

        public void StartGameMessage(Player player)
        {
            Console.WriteLine($"{player.Name} , let's Play!!\n");
        }

        public Choice MakeSelection()
        {
            Choice choice;
           
            do
            {
                Console.WriteLine("Make your selection: \n" +
                               "R - Rock \n" +
                               "P - Paper \n" +
                               "S - Scissor \n");
                string input = Console.ReadLine();
                choice = Choice.MapStringToMove(input); 

            }while(choice==null);
            
            return choice;
                         
        }
    }
}