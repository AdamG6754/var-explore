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
            string villianTitle = "Doom and Peril";
            string minionTitle = "Minimum Wage Underling";
            string villianName;
            string minion1Name;
            string minion2Name;

            int heroHp = 100;
            int heroStr = 50;
            int bossHp = 100;
            int bossStr = 25;
            int minion1Hp = 50;
            int minion2Hp = 50;
            int minionStr = 5;

            //begin code:

            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Here comes the hero! Put your hands together for " + heroFullName);

            villianName = heroFirstName + "'s evil future self";
            minion1Name = "Gavin";
            minion2Name = "Devin";

            Console.WriteLine(heroFullName + "'s nemesis! " + villianTitle + "!" + " (" + villianName + ")");
            Console.WriteLine("But this isn't a fair fight! " + heroFirstName + " is also up against two of " + villianTitle + "'s " + minionTitle + "s! " + minion1Name + " and " + minion2Name + "!");
            Console.WriteLine("They're not even uninionized!!!");

            //making a clear divide
            Console.WriteLine();

            //fight
            Console.WriteLine("Get ready, fighters!");
            Console.WriteLine("...");
            Console.WriteLine(heroFirstName + "'s HP: " + heroHp);
            Console.WriteLine("E. " + heroFirstName + "'s HP: " + bossHp);
            Console.WriteLine(minion1Name + "'s HP: " + minion1Hp);
            Console.WriteLine(minion2Name + "'s HP: " + minion2Hp);

            //break 2, electric boogaloo
            Console.WriteLine();


            //Time to fight!

            //Boss attacks first
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStr + " damage!");
            //health recalculation
            heroHp = heroHp - bossStr;
            Console.WriteLine(heroFullName + " now has " + heroHp + " health!");
            //Minions attack
            Console.WriteLine("The evil minions attack!");
            Console.WriteLine(minion1Name + " deals " + minionStr + " damage!");
            //health recalculation
            heroHp = heroHp - minionStr;
            Console.WriteLine(heroFullName + " now has " + heroHp + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStr + " damage!");
            //health recalculation
            heroHp = heroHp - minionStr;
            Console.WriteLine(heroFullName + " now has " + heroHp + " health!");

            //Hero turn to attack!
            Console.WriteLine(heroFullName + " attacks each villian for " + heroStr + " damage!");
            //do math
            bossHp -= heroStr;
            minion1Hp -= heroStr;
            minion2Hp -= heroStr;

            //Display results in the console
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHp + " health!");
            Console.WriteLine(minion1Name + " the minion" + " now has " + minion1Hp + " health!");
            Console.WriteLine(minion2Name + " the minion" + " now has " + minion2Hp + " health!");

            //minions die
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been killed");

            Console.WriteLine();

            Console.WriteLine(heroFullName + " has " + heroHp + " health!");
            Console.WriteLine("But " + heroFirstName + " is based, so he heals");
            heroHp++;
            Console.WriteLine(heroFullName + " has " + heroHp + " health!");
            Console.WriteLine();

            //moar killing
            Console.WriteLine("Anyway, back to killing each other.");
            Console.WriteLine(heroFirstName + "'s HP: " + heroHp);
            Console.WriteLine("E. " + heroFirstName + "'s HP: " + bossHp);
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStr + " damage!");
            //health recalculation
            heroHp = heroHp - bossStr;
            Console.WriteLine(heroFullName + " now has " + heroHp + " health!");
            //Hero turn to attack!
            Console.WriteLine(heroFullName + " attacks each villian for " + heroStr + " damage!");
            //do math
            bossHp -= heroStr;
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHp + " health!");
            Console.WriteLine("Good job, " + heroFirstName + ", you killed them. Now you're all done with your homework.");


        }
    }
}
