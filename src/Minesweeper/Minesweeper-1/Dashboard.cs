namespace Minesweeper
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dashboard
    {
        private List<Person> participants;

        public Dashboard()
        {
            participants = new List<Person>();
        }

        internal int MinInTop5()
        {
            if (participants.Count > 0)
            {
                return participants.Last().Score;
            }

            return -1;
        }

        internal void EnterPlayerName(int score)
        {
            Console.Write("Please enter your name for the top scoreboard: ");
            string name = Console.ReadLine();
            participants.Add(new Person(name, score));
            participants.Sort(new Comparison<Person>((p1, p2) => p2.Score.CompareTo(p1.Score)));
            participants = participants.Take(5).ToList();
        }

        internal void Покажи()
        {
            Console.WriteLine("Scoreboard:");
            foreach (var p in participants)
            {
                Console.WriteLine(participants.IndexOf(p) + 1 + ". " + p.Name + " --> " + p.Score + " cells");
            }
            Console.WriteLine();
        }

        internal int Count()
        {
            return participants.Count();
        }
    }
}
