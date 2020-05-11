﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SonsGame
{
    class Sons
    {
        public Player newPlayer;
        public MainScene currentScene;
        public void start()
        {
            newPlayer = new Player(0,0);
            currentScene = new MainScene();
            WriteLine("Welcome to sons!");
            // source: https://asciiart.club/
            //art source Danthepest SaintsRowWiki
            WriteLine(@"
          ██████████████████└▄    ▐█████████████████████████████████████████████

████████████████████████████▓█▌▄   █████████████████████████████████████████████

█████████████▒████████████████▀`   ▀▀███████████████████████████████████████████

████████████▌╫Ω██████████▄|╜           ⁿ▀███████████████████████████████████████

██████████████∩`╚┘████████/      .       ╣██████████████████████████████████████

██████████████¡. ,~███████¿.  ,'``        ╙█████████████████████████████████████

██████████████▄`, '████████▒▒  .'           ░▀██████████████████████████████████

████████████████▒b' ▀███████~     '.   ``  '  ▀█████████████████████████████████

█████████████████╢~  ▀█████░,  '░¡:¡░.``       ▐████████████████████████████████

█████████████████▒K.   ██░''   :░░'└░~,`   `    └███████████████████████████████

██████████████████╢█` '     ▄█. '` .```      `    ▀█████████████████████████████

███████████████████▓█    ,████─  :'  ''`       .   └████████████████████████████

███████████████████▒██▌███████   ' .,` `       ▄    ████████████████████████████

███████████████████▌▒█████████`   :`,`..  .  ▄██`   ²███████████████████████████

████████████████████▌████████▒▄███¡=':``. ` ████     ███████████████████████████

█████████████████████▒███████████ '=.¡```  `████ `   ▐██████████████████████████

█████████████████████▌██████████▌        .  ▀███'`.  :██████████████████████████

███████████████████████████████┘         '   ███U░░░'███████████████████████████

██████████████████████████████            ',   ██L└░░▐██████████████████████████

████████████████████████████▀              '   ▐██,'.██████████████████████████

████████████████████████████'``         '      ████' ███████████████████████████

███████████████████████████':`      ▄█▄'       ████▌▐███████████████████████████

█████████████████████████▌`'`      ▓███` `.`   █████████████████████████████████

█████████████████████████         ████▌ '`'``  ▐████████████████████████████████

████████████████████████ .`     ,█████Ü `''``   ████████████████████████████████

███████████████████████└'      ▄██████▄ , `'`.  ████████████████████████████████

███████████████████████:.     ██████████▌.`:~,  '███████████████████████████████

███████████████████████⌐.''`  ████████████ '':`` └██████████████████████████████

████████████████████████      █████████████    ..  █████████████████████████████

████████████████████████U      ▀███████████▌  ```   ████████████████████████████

█████████████████████████       ████████████   ```   ╙██████████████████████████

█████████████████████████U       ███████████▌   `.'    █████████████████████████

█████████████████████████▌        ███████████µ  ```.   '████████████████████████

██████████████████████████        '███████████   .'`    ▐███████████████████████

██████████████████████████         ▐███████████  ````    ███████████████████████

██████████████████████████▌ ` `     ████████████  ````    ██████████████████████

███████████████████████████⌐`       ▐███████████W `'`'`   ▐█████████████████████

██████████████████████████▀:└:      ╟████████████. '`'`    █████████████████████

█████████████████████████@     ,█▌  ██████████████¿`'.'   ¬█████████████████████

██████████████████████|░╓,,,,▄████████████████████▌` `.    █████████████████████

██████████████████████████████████████████████████████.`.   ████████████████████

██████████████████████████████████████████████████████▌.'`   ███████████████████

█████████████████████████████████████████████████████████▓▄;▄███████");
            ReadKey();
            Clear();
            //source http://www.patorjk.com/
            WriteLine(@"
 _______  _______  _        _______ 
(  ____ \(  ___  )( (    /|(  ____ \
| (    \/| (   ) ||  \  ( || (    \/
| (_____ | |   | ||   \ | || (_____ 
(_____  )| |   | || (\ \) |(_____  )
      ) || |   | || | \   |      ) |
/\____) || (___) || )  \  |/\____) |
\_______)(_______)|/    )_)\_______)
                                    ");
            ReadKey();
            Clear();
            WriteLine("After being shot to near death by the saints... Mr.Sunshine wakes up after a 3 year coma.");
            WriteLine("\n\nThe saints were nice enough not to finish him off...Mr.Sunshine then sees how far the saints have took over the US and decides that he has no business in the US.");
            WriteLine("\n\nHe decides to pack his bags and go back to his home. Time to build an empire where he should have from the beginning.");
            ReadKey();
            Clear();
            WriteLine("Okay welcome to Haiti!!!");
            
            WriteLine("\n\nWe're getting right to it! What would you like to earn first?");
            for (; ; ) 
            {
                WriteLine("\n\nMoney or followers or jump straight into a mission?");
                string MoFAnswer= ReadLine().ToLower().Trim();
                if (MoFAnswer == "money")
                {
                    currentScene.Money(newPlayer);
                    
                }
                else if (MoFAnswer == "followers")
                {
                    currentScene.Followers(newPlayer);
                }
                else if (MoFAnswer == "mission")
                {
                    currentScene.Mission(newPlayer);
                }
                else
                {
                    WriteLine("You only have three choices Djol Santi!");
                    ReadKey();
                }
                ReadKey();
            }

            





        }
    }
}
