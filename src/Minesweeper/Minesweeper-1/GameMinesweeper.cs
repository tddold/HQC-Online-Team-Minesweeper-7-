﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Minesweeper
{

	// Аз съм българче и пиша на БЪЛГАРСКИ!

    class GameMinesweeper
    {
        static void Main()
        {

            Dashboard scoreboard = new Dashboard();
            ДайНаново:
            bool displayBoard = true;
            Panel board = new Panel();
            Console.WriteLine("Welcome to the game “Minesweeper”. Try to reveal all cells without mines. Use 'top' to view the scoreboard, 'restart' to start a new game and 'exit' to quit the game.");
            Console.WriteLine();

            while (true)
            {
                if (displayBoard)
                    board.Display();
                displayBoard = true;
                Console.Write("Enter row and column: ");
                Commands.Прочети();

                if (!Commands.NeMojesh)
                {
                    if (Commands.IsGetStatistic)
                    {
                        scoreboard.Покажи();
                        displayBoard = false;
                        Commands.Clear();
                        continue;
                    }
                    if (Commands.Izlez)
                    {
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                    }
                    if (Commands.Nanovo)
                    {//ako iskahs pak skakash neznaino kyde
                        // ama pyk si bachka
                        goto ДайНаново;
                    }

                    int x = Commands.x;
                    int y = Commands.y;
                    if (!board.proverka(x, y) || board.proverka2(x, y))
                    {
                        Console.WriteLine("Illegal move!");
                        Console.WriteLine();
                        displayBoard = false;
                    }
                    else
                    {
                        if (board.proverka3(x, y))
                        {
                            board.Край(x, y);
                            board.Display();
                            Console.WriteLine("Booooom! You were killed by a mine. You revealed " + board.RevealedCells + " cells without mines.");
                            Console.WriteLine();
                            if (board.RevealedCells > scoreboard.MinInTop5() || scoreboard.Count() < 5)
                            {
                                scoreboard.EnterPlayerName(board.RevealedCells);
                            }
                            scoreboard.Покажи();
                            goto ДайНаново;
                        }
                        else
                            board.RevealBlock(x, y);
                    }
                }
                else
                {
                    Console.WriteLine("Illegal command!");
                    displayBoard = false;
                }
            }
        }

        //ai na bas che ne mojehs da napishesh pove4e kod v edin metod!

    }
}
