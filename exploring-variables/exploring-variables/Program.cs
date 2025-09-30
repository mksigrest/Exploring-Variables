namespace exploringVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string heroFirstName = "Max";
            string heroLastName = "Sigrest";
            string heroFullName;

            string villianTitle = "Evil Lord";
            string minionTitle = "Background Grunt";
            string villianName;
            string minion1Name;
            string minion2Name;

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;

            //Begin Code Instructions
            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold the legendary hero of programming, whose name is: " + heroFullName);

            villianName = "Larry";
            minion1Name = "Moe";
            minion2Name = "Curly";

            Console.WriteLine(heroFullName + "'s arch rival is " + villianName + " the " + villianTitle);

            //Don't forget about the minions!
            Console.WriteLine(villianName + " the " + villianTitle + " is helped out by: " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);
        }
    }
}
