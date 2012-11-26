using System;

namespace TTTANE
{
    public class Runner
    {
        
        public virtual void Run()
        {
            var game = new GameLogic {CurrPlayer = "X"};
            Console.Title = "Awesome TicTacToe!";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome: Let's play some TicTacToe!");
            Console.ResetColor();
            Play(game);
        }

        public virtual void Play(GameLogic game)
        {
            do
            {
                game.DrawBoard();
                Console.WriteLine("Player: " + game.CurrPlayer + " make your move!");
                var move = Convert.ToInt32(Console.ReadLine()) - 1;
                game.SetPlayerInput(move, game.CurrPlayer);
                //game.CheckWinner();
                game.ChangePlayer();
            } while (!game.Winner);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player " + game.CurrPlayer + " has won the game!");
            Console.ResetColor();
            string readLine;
            do
            {
                Console.WriteLine("Play again? (Y)");
                readLine = Console.ReadLine();
                if (readLine != null)
                {
                    var playAgain = readLine.ToUpper();
                    if (playAgain == "Y")
                    {
                        Run();
                    }
                }
            } while (readLine!="N");
        }
    }
}
