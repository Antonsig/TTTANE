using System;

namespace TTTANE
{
    public class Runner
    {
        /// <summary>
        /// Byrjar nýjan leik, með X sem byrjunarleikmann!
        /// </summary>
        public virtual void Run()
        {
            var game = new GameLogic {CurrPlayer = "O"};
            Console.Title = "Awesome TicTacToe!";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome: Let's play some TicTacToe!");
            Console.ResetColor();
            Play(game);
        }
        /// <summary>
        /// Byrjar leikinn, kallar í föll frá gamelogic og skrifar svör notanda í console 
        /// </summary>
		
        /// <param name="game"></param>
        public virtual void Play(GameLogic game)
        {
            do
            {
                game.ChangePlayer();
                game.DrawBoard();
                Console.WriteLine("Player: " + game.CurrPlayer + " make your move!");
                var move = Convert.ToInt32(Console.ReadLine()) - 1;
                game.SetPlayerInput(move, game.CurrPlayer);
                game.CheckWinner();
            } while (!game.Winner);

            game.DrawBoard();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player " + game.CurrPlayer + " has won the game!");
            Console.ResetColor();
            string readLine;

            do
            {
                Console.WriteLine("Play again? (Y or N)");
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
