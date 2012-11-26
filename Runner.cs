using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TTTANE;

namespace TTTANE
{
    public class Runner
    {
        //private readonly TextReader _input;
        //private readonly TextWriter _output;

        //public Runner(TextReader input, TextWriter output)
        //{
        //    this._input = input;
        //    this._output = output;
        //}
        
        public virtual void Run()
        {
            var game = new GameLogic();
            Console.Title = "Awesome TicTacToe!";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome: Let's play some TicTacToe!");
            Console.WriteLine();
            Console.ResetColor();
            Play(game);
            //game.drawBoard();
            //PlayerSelect(game);
            
            //throw new NotImplementedException();
        }

        public virtual void Play(GameLogic game)
        {
            //while(!game.IsOver())
            //{
                game.drawBoard();
                //var availableMoves = game.AvailableMoves;
                //Console.WriteLine("Available moves are: " + availableMoves);
                Console.WriteLine("Player: " + game.CurrPlayer + " make your move!");
                var move = Convert.ToInt32(Console.ReadLine());
                game.setPlayerInput(move, game.CurrPlayer);
                //game.ChangePlayer(game.CurrPlayer);
 
                game.ChangePlayer();
           // }
        }
        
        public virtual void PlayerSelect(GameLogic game)
        {
            string name = null;
            string xOrO = null;
            for (var i = 1; i < 2; i++ )
            {
                Console.WriteLine("Write your name if you want!");
                var readName = Console.ReadLine();
                if (readName != null) name = readName;
                if(i==1)
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Choose to play X or O!");
                        Console.ResetColor();
                        var readLine = Console.ReadLine();
                        if (readLine != null) xOrO = readLine.ToUpper();
                    } while (!"XO".Contains(xOrO));
                }
                SetUser(new User(name, xOrO));
                xOrO = "XO".Replace(xOrO, "");
            }
        }

        private void SetUser(User user)
        {
            Console.WriteLine(user.UserName+ "-" +user.Value);
        }
    }
}
