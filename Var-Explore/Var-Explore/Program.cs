namespace Var_Explore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string heroFirstName = "Adam";
            string heroLastName = "Goltsman";
            string heroFullName;
            string villainTitle = "Doom and Peril";
            string minionTitle = "Minimum Wage Underling";
            string villainName;
            string minion1Name;
            string minion2Name;

            //begin code:

            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Here comes the hero! Put your hands together for " + heroFullName);

            villainName = heroFirstName + "'s evil future self";
            minion1Name = "Gavin";
            minion2Name = "Devin";

            Console.WriteLine(heroFullName + "'s nemesis! " + villainTitle + "!" + " (" + villainName + ")");
            Console.WriteLine("But this isn't a fair fight! " + heroFirstName + " is also up against two of " + villainTitle + "'s " + minionTitle + "s! " + minion1Name + " and " + minion2Name + "!");
            Console.WriteLine("They're not even uninionized!!!");
        }
    }
}
