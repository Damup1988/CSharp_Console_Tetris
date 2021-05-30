# CSharp_Console_Tetris
C# console tetris

Tasks to do:
- DONE - create new point once the previous one has reached current bottom
- DONE - stack points on each other
- DONE - check if we reach the topline for game over
- DONE - reaplce points with figures
- add rotate func for figures
- create func for creating random figires each time once previous figure has reached current bottom
- DONE - remove levels according Tetris rules (count points for each removing according amount of removed levels)

1. Create a figure
2. Wait 1 sec for an inpute => Check for "right" or "left" or "rotate"
	Was an inupte?
	YES => What inpute?
		Left => Hit the left border?
			YES => Don't move to the left
			NO => Move to the left
		Right => Hit the right border?
			YES => Don't move to the right
			NO => Move to the right
		UP => Rotate the figure
	NO => Go to 3
3. Move the figure down
4. Hit the bottom?
	YES => Add the figure to the bottom
		Full line?
		YES => Remove all full lines and go to 1
		NO => Go to 1
	NO => Go to 2
