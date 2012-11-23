using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTTANE
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] board = new string[9];
			board[0] = "4";
			board[1] = "3";
			board[2] = "8";
			board[3] = "9";
			board[4] = "5";
			board[5] = "1";
			board[6] = "2";
			board[7] = "7";
			board[8] = "6";


			//	static void StartBoard ()
			//	{
			Console.WriteLine(" " + board[0] + " | " + board[1] + " | " + board[2]);
			Console.WriteLine("---|---|---");
			Console.WriteLine(" " + board[3] + " | " + board[4] + " | " + board[5]);
			Console.WriteLine("---|---|---");
			Console.WriteLine(" " + board[6] + " | " + board[7] + " | " + board[8]);
			Console.WriteLine("---|---|---");
			//}
			Console.Read();

			//	| 4  | 3  | 8  |
			//	| 9  | 5  | 1  |
			//	| 2  | 7  | 6  |
		}
	}
}

