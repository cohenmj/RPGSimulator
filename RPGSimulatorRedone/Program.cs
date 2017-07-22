using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorRedone
{
    class RPGSimulator
    {
        static void Main(string[] args)
        {
            int playerHitPoints = 0;        // Player Hit Points
            int moveIndicator = 0;          // Indicates which move to execute
            int enemyHitPoints = 0;         // Enemy Hit Points

            string inPHP = "";           // input player HP
            string playerName = "";      // input player Name
            string inEHP = "";           // input enemy HP
            Random random = new Random();                   // Predefined Class to be used as a Random Number Generator

            PlayerInfo playerOne = new PlayerInfo(); // from PlayerInfo Class

            int randomNumber = random.Next(0, 100); // 0-99


            Console.WriteLine("==========================================================================================================================================");
            Console.WriteLine("     @@@@@@@@    @@@@@@@     @@@@@@@@@                   "); // Introduction
            Console.WriteLine("     @      @    @      @    @                           ");
            Console.WriteLine("     @      @    @      @    @                           ");
            Console.WriteLine("     @     @     @      @    @                           ");
            Console.WriteLine("     @@@@@@      @@@@@@@     @    @@@@@                  ");
            Console.WriteLine("     @ @         @           @        @                  ");
            Console.WriteLine("     @  @        @           @        @                  ");
            Console.WriteLine("     @   @       @            @       @                  ");
            Console.WriteLine("     @    @      @             @@@@@@@                   ");
            Console.WriteLine("");
            Console.WriteLine(" @@@@@@@     @@@@@@@          @           @           @        @    @                   @          @@@@@@@@@@     @@@@@@@@    @@@@@@@@@@     ");
            Console.WriteLine(" @              @            @ @         @ @          @        @    @                  @ @              @        @        @   @         @    ");
            Console.WriteLine(" @              @           @   @       @   @         @        @    @                 @   @             @        @        @   @         @    ");
            Console.WriteLine(" @              @          @     @     @     @        @        @    @                @     @            @        @        @   @@@@@@@@@@     ");
            Console.WriteLine(" @@@@@@@        @         @       @   @       @       @        @    @               @@@@@@@@@           @        @        @   @   @          ");
            Console.WriteLine("       @        @        @         @ @         @      @        @    @              @         @          @        @        @   @    @         ");
            Console.WriteLine("       @        @       @           @           @     @        @    @             @           @         @        @        @   @     @        ");
            Console.WriteLine("       @        @      @                         @    @        @    @            @             @        @        @        @   @      @       ");
            Console.WriteLine(" @@@@@@@     @@@@@@@  @                           @    @@@@@@@@     @@@@@@@@@   @               @       @         @@@@@@@@    @       @      ");
            Console.WriteLine("==========================================================================================================================================");
            Console.WriteLine("Welcome to the RPG Simulator! This program allows you to experience the basic form of a text based RPG."); //Game Intro
            Console.WriteLine("");





            playerOne.PlayerName = AskForPlayerName();

            Console.Write("Enter your total Hit Points: "); // Set Player Hit Points
            inPHP = Console.ReadLine();
            playerHitPoints = int.Parse(inPHP);
            Console.Write("Enter the enemies Hit Points: "); // Set Enemy Hit Points
            inEHP = Console.ReadLine();
            enemyHitPoints = int.Parse(inEHP);
            // Start Game/Scenario Introduction
            Console.WriteLine("");
            Console.WriteLine("Welcome!");
            Console.WriteLine("You have resided in a small town called Phandalin for several years as a town guard.");
            Console.WriteLine("In your youth, you had always heard of stories about valiant knights performing heroic deeds around the neighboring large towns.");
            Console.WriteLine("Aspiring to be like the knights from the stories told to you throughout the years, you feel that the life of a town guard isn't satisfying your need for adventure.");
            Console.WriteLine("You pack all of the necessitites you need along with your sword and shield and head out to start exploring the world!");
            Console.WriteLine("You figure that maybe one of the neighboring towns might be more inclined to have mercenary work, which is about a full day and a half away from Phandalin.");
            Console.WriteLine("Several hours down the trail, as the sun starts to set on the horizon, you hear some rustling come from the bushes followed by a vicious growl....");
            Console.WriteLine("");
            Console.WriteLine("SUDDENLY! out of the bushes jumps a ferocious Wolf!");
            Console.WriteLine("You prepare yourself by unsheathing your blade.");


            if (randomNumber > 80)
            {
                Console.WriteLine("*");
                Console.WriteLine("You feel a warm light overcome and engulf your body. You have a feeling that it may become useful with the right move....."); // if Charge Attack will Critically hit
                Console.WriteLine("*");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You feel normal");
                Console.WriteLine("");

            }



            while (enemyHitPoints > 1 && playerHitPoints > 1)
            {

                if (enemyHitPoints <= 20)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Your foe appears to be forcing itself to go on fighting...");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");
                }

                moveIndicator = AskForAttackOption(); //Ask for Move Option

                if (moveIndicator == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You ready your sword in one hand and begin to charge towards your foe."); // text explaining "Attack"
                    Console.WriteLine("You ferociously swing at your enemy dealing 8 damage!");
                    enemyHitPoints = enemyHitPoints - 8;
                    Console.WriteLine(""); // SPACE
                    Console.WriteLine("After being struck, your foe begins to charge at you, swiping at you and hitting you for 7 damage!"); // enemy text
                    playerHitPoints = playerHitPoints - 7;
                    Console.WriteLine(""); // SPACE
                    Console.WriteLine("Your Current Hit Points: {0}", playerHitPoints);
                    Console.WriteLine("Enemy's Current Hit Points: {0}", enemyHitPoints);
                    Console.WriteLine("");


                }
                else if (moveIndicator == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You ready your sword with both hands and begin concentrating on a single point"); // text explaining "Charge Attack"
                    Console.WriteLine("Your focused strike hits a vulnerable part of your foe dealing 16 damage!");
                    enemyHitPoints = enemyHitPoints - 16;

                    if (randomNumber > 80)
                    {
                        enemyHitPoints = enemyHitPoints - 10;
                        Console.WriteLine("Charge Attack has critically hit! Dealing 10 points of additional damage!");
                        Console.WriteLine(""); // SPACE
                    }

                    Console.WriteLine("");
                    Console.WriteLine("You take a moment to catch your breath after executing such a massive attack...");
                    Console.WriteLine("During that time, the enemy lunges at you twice! biting you and dealing a total of 14 Damage!");
                    Console.WriteLine("");
                    playerHitPoints = playerHitPoints - 14;
                    Console.WriteLine("Your Current Hit Points: {0}", playerHitPoints);
                    Console.WriteLine("Enemy's Current Hit Points: {0}", enemyHitPoints);
                    Console.WriteLine("");

                }
                else if (moveIndicator == 3)
                {
                    Console.WriteLine("You take the Wooden shield that had been resting on your back and hold it out in front of you, bracing for an attack from your foe."); // text explaining "Guard"
                    playerHitPoints = playerHitPoints - 2;
                    Console.WriteLine("");
                    Console.WriteLine("Your Current Hit Points: {0}", playerHitPoints);
                    Console.WriteLine("Enemy's Current Hit Points: {0}", enemyHitPoints);
                    Console.WriteLine("");

                }
                else if (moveIndicator == 4)
                {
                    Console.WriteLine("You drop both your weapon and shield and throw your hands up in the air!"); // text explaining "Surrender"
                    Console.WriteLine("Your foe does not take pity!");
                    playerHitPoints = playerHitPoints - playerHitPoints;

                }
                else
                {
                    Console.WriteLine("Incorrect Input (try again)");
                    Console.WriteLine("");
                }

            }


            if (enemyHitPoints <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("              /|         ");
                Console.WriteLine("             / |         ");
                Console.WriteLine("            /  |        As your foe attacks you. You see it lose consiousness and bleed out! ");
                Console.WriteLine("           /   |         ");
                Console.WriteLine("          / || |         ");
                Console.WriteLine("          | || |         @    @   @@@@@    @     @    ");
                Console.WriteLine("          | || |          @  @   @     @   @     @    ");
                Console.WriteLine("          | || |           @     @     @   @     @    ");
                Console.WriteLine("          | || |           @     @     @   @     @   ");
                Console.WriteLine("          | || |           @     @     @   @     @   ");
                Console.WriteLine("          | || |           @      @@@@@     @@@@@       ");
                Console.WriteLine("          | || |                                         ");
                Console.WriteLine("          | || |      @             @   @@@@@@@   @    @   @@@  ");
                Console.WriteLine("          | || |       @     @     @       @      @ @  @   @$@ ");
                Console.WriteLine("          | || |        @   @ @   @        @      @  @ @   @@@  ");
                Console.WriteLine("          | || |         @ @   @ @         @      @   @@      ");
                Console.WriteLine("    ______|_--_|_______   @     @       @@@@@@@   @    @   @@@      ");
                Console.WriteLine("   |______  @@  _______|                              ");
                Console.WriteLine("   |______      _______|  ");
                Console.WriteLine("          |====|  ");
                Console.WriteLine("          |====|   ");
                Console.WriteLine("          |====|   ");
                Console.WriteLine("         /_____|   ");
                Console.WriteLine("Congrats " + playerName + " You have vanquished your foe!");
                Console.WriteLine("You feel that you could easily continue on your journey to face what lies ahead!");
                Console.WriteLine("Your total Hit Points left: {0}", playerHitPoints);
            }
            else
            {
                Console.WriteLine("You have been slain!");
                Console.WriteLine("you should've stayed on guard duty.....");
            }

            Console.Read();
        }
        public static int AskForAttackOption()
        {

            string inValue = "";
            int inputValue = 0;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Move List: ");
            Console.WriteLine("1: Attack");
            Console.WriteLine("2: Charge Attack");
            Console.WriteLine("3: Guard");
            Console.WriteLine("4: Surrender");
            Console.WriteLine("Choose which move you would like to Execute(1-4): ");
            inValue = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------");
            inputValue = int.Parse(inValue);

            return inputValue;
        }
        public static string AskForPlayerName()
        {
            string inValue;
            Console.Write("Enter the Name of your Character: ");
            inValue = Console.ReadLine();
            return inValue;
        }
    }
}