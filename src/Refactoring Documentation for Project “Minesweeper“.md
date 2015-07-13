 Refactoring Documentation for Project “Minesweeper”                                                                                                                          
------------------------------------------------------

1.  Redesigned the project structure: Team “Minesweeper”
	-   Renamed the project to `Minesweeper`.	-   
	-   Renamed the namespace `Mini` to `Minesweeper`.
	-   Renamed the main class `Program` to `GameMinesweeper`.
	-   Renamed the class `Табло` to `Dashboard`.
	-   Renamed the class `Дъска` to `Panel`.
	Commands-   Renamed the class `Команда` to `Commands`.
	-   renamed the class `Човек` to `Person`.
	-   Extracted each class in a separate file with a good name: `GameMinesweeper.cs`, `Dashboard.cs`, `Panel.cs`, `Commands.cs`, `Person.cs`.
	-   …
2.  Reformatted the source code:
	-   Reformatted class `Person.cs`.
	-   Insert class access modifier.
	-   Insert fields `name` , `score`.
	-   Move constructor before properties.
	-   Inserted empty lines between the properties.

    -   Reformatted class `Dashboard.cs`.
    -   Move using derectives in namespase.
    -   Put **{** and **}** after all conditionals and if statemants
    -   Renamed method `Dobavi` to `EnterPlayerName`.
	-   Move constructor before properties.
	-   Inserted empty lines between the all methods.


	-   Split the lines containing several statements into several simple lines, e.g.:
	
	Before:
	
		if (input\[i\] != ' ') break;
		
	After:

		if (input\[i\] != ' ')
		{
			break;
		}
	
	-   Formatted the curly braces **{** and **}** according to the best practices for the C\# language.
	-   Put **{** and **}** after all conditionals and loops (when missing).
	-   Character casing: variables and fields made **camelCase**; types and methods made **PascalCase**.
	-   Formatted all other elements of the source code according to the best practices introduced in the course “[High-Quality Programming Code](http://telerikacademy.com/Courses/Courses/Details/244)”.
	-   …
3.  Renamed variables:
	-   In class `Fifteen`: `number` to `numberOfMoves`.
	-   In `Main(string\[\] args)`: `g` to `gameFifteen`.
4.  Introduced constants:
	-   `GAME\_BOARD\_SIZE = 4`
	-   `SCORE\_BOARD\_SIZE = 5`. 
5.  Extracted the method `GenerateRandomGame()` from the method `Main()`.
6.  Introduced class `ScoreBoard` and moved all related functionality in it.
7.  Moved method `GenerateRandomNumber(int start, int end)` to separate class `RandomUtils`.
8.  …
