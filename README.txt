Board.cs testing!
Does board consist of 9 integers from 1-9?
Does board have 'X' or 'O' in it already?
Was the board correctly reset (if player/s want to play another game)?
Does setX(int id) work? 			//Here or 
Does setO(int id) work?				//Here or

----------------------------------------------------------------------
GameLogic.cs
Does the game grab correct input from user?
Is checkWinner() working?
Is checkBox(int id) working (ie. if 'X' is in Array[3] then you can't put 'O' in Array[3]
Does setX(int id) work?				//Here?
Does setO(int id) work?				//Here?
If getInput(String input) is empty, input failed, ask player again for input

----------------------------------------------------------------------
User.cs
Does stringArray[0] insert correct names of players? (ie Player1 name is Bjarni, then is stringArray[0] == "Bjarni" 
Is stringArray[0] or stringArray[1] left intentionally empty by player? if so they should say Player1 or Player2


----------------------------------------------------------------------
Program.cs
Ekki glóru
Héðan er leikurinn keyrður

protected bool winner = false;

While(winner == false)
{
	//run game
	//call checkWinner();
}

eitthvað svona