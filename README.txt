Board.cs testing!
Does board consist of 9 integers from 1-9?;
Does board have 'X' or 'O' in it already?;
Was the board correctly reset (if player/s want to play another game)?;
Does setX(int id) work? 			//Here or ;
Does setO(int id) work?				//Here or;

----------------------------------------------------------------------
GameLogic.cs
Does the game grab correct input from user?;
Is checkWinner() working?;
Is checkBox(int id) working (ie. if 'X' is in Array[3] then you can't put 'O' in Array[3];
Does setX(int id) work?				//Here?;
Does setO(int id) work?				//Here?;
If getInput(String input) is empty, input failed, ask player again for input;

----------------------------------------------------------------------
User.cs
CHECK! Constructor insert correct names of player and if not the player is named "Player"
CHECK! ParseInput takes a string from user from user in the form A1...C3 triggers savemove function with correct values.(if avaliable)
CHECK! ParseInput returnes false if value is illegal or the move has already been made.
CHECK! Total score is saved in moves[{0,3},{1,3},{2,3},{3,3},{3,0},{3,1},{3,2}] (If player has total score of 15 in each of these he wins!)\n;
CHECK! Bool iswinner returns true if totalscore is 15 somewhere in totals.
CHECK! resetmoves sets the values of all moves to 0.
----------------------------------------------------------------------
Program.cs
Ætti að hafa kall í sér klasa sem er svo sjálfur run klasinn. Þannig náum við solid tdd unit testing.
Héðan er kallað í Runner.cs


Sem svo ætti að lúkka eitthvað í þessa áttina. 
protected bool winner = false;

While(winner == false)
{
	//run game
	//call checkWinner();
}

eitthvað svona