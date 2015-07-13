namespace Minesweeper
{
    public class Person
    {
        private string name;
        private int score;

        public Person(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public string Name { get; set; }

        public int Score { get; set; }
    }
}
