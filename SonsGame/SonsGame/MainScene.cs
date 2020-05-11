using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Console;

namespace SonsGame
{
    class MainScene
    {
        
        
        public void Money(Player player)
        {
            
            WriteLine("Okay lets get this money!");
            WriteLine("\n\nYou can only do this every once in a while");
            ReadKey();
            Clear();
            WriteLine("Okay you now may continue! You've earned $1000 now!");
            player.Money += 1000;
            WriteLine($"You have ${player.Money}");
            WriteLine(@"
___________________________________
|#######====================#######|
|#(1)*HAITI BUCKS BOIIIIIIIIII*(1)#|
|#**          /===\   ********  **#|
|*# {G}      | (')|              #*|
|#*  ******  | /v\|    O N E     *#|
|#(1)         \===/    THOUSAND(1)#|
|##======ONETHOUDOLLAR===========##|
------------------------------------");
            ReadKey();
                
            



        }
       
        public void Followers(Player player)
        {
            WriteLine("okay lets get some followers!");
            WriteLine("\n\nYou may only do this every once in a while");
            ReadKey();
            Clear();
            WriteLine("Okay you now may continue! You've earned 150 followers now!");
            player.Followers += 150;
            WriteLine($"You now have {player.Followers} followers ready to fight for you!");
            WriteLine(@"
 .----.-----.-----.-----.
 /      \     \     \     \
|  \/    |     |   __L_____L__
|   |    |     |  (           \
|    \___/    /    \______/    |
|        \___/\___/\___/       |
 \      \     /               /
  |                        __/
   \_                   __/
    |        |         |
    |                  |
    |                  |");
            ReadKey();
        }



        public void Mission(Player player)
        {
            WriteLine("1st mission... Checking to see if you have required followers and money..");
            WriteLine("Required followers: 15");
            WriteLine("Required Money: $500");
            if (player.Money >= 500||player.Followers>=15)
            {
                WriteLine("Alright... Seems you are clear");
                Clear();
                WriteLine("Were going to break into a stronghold...");
                WriteLine("You can buy body armor for you and your goons for $900");
                WriteLine("\n\nWould you like to???");
                WriteLine("Doing so may help your chances!");
                string ArmorYN = ReadLine().ToLower().Trim();
                if (ArmorYN == "yes")
                {
                    WriteLine("Alright you've got a chance now with these weaklings...");
                    player.Money -= 800;
                    WriteLine($"You've now got ${player.Money}");
                    player.Followers -= 85;
                    player.Money += 300;
                    WriteLine("You've entered their drug facility...They tried to resist but since they were so small time you were able to take them down but you lost 85 followers in the process... Turns out those vest were fakes. Let this be a lesson learned... You still got the drugs and gained 300 dollars in the process.");
                }
                else if(ArmorYN=="no")
                {
                    WriteLine("Good luck then you'll need it.");
                    WriteLine($"You've got ${player.Money}");
                    player.Followers -= player.Followers;
                    player.Money += 50;
                    Clear();
                    WriteLine("You went in there guns blazing with your followers and lost every single one... HAHAHAHAHAHAHAHAHAHA! Somehow you got some of the drugs... Know what it's Mr.Sunshine... You've got to complete the mission right? Well you only gained 50 dollars");
                    WriteLine($"You now have {player.Followers} Followers ");
                    WriteLine($"You now have ${player.Money}.");
                }

            }
            else
            {
                WriteLine("\n\nGet out of here expeditiously...B4 You die XD");
            }
            
            
           
            
            ReadKey();
        }
    }
}
