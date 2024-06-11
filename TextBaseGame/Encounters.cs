using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBaseGame
{
    public class Encounters
    {
        static Random rand = new Random();
        //Encounter Generic

        //Encounter
        public static void FirstEncounter()
        {
            Console.WriteLine("You throw open the door and grab a rusty metal sword\n" +
            "while charging toward the captor.\n" +
            "He turns...");
            Console.ReadKey();
        }


        //encounter tools
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine("========================");
                Console.WriteLine("|  (A)ttack  (D)efend  |");
                Console.WriteLine("|   (R)un     (H)eal   |");
                Console.WriteLine("========================" +);
                Console.WriteLine("  Potion: " + Program.player.potion + "  Health: " + Program.player.health);
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "a" || userInput.ToLower() == "attack")
                {
                    //acttack
                    Console.WriteLine("With haste you surge forth, your sword flying in your hand!\n" +
                    "As you pass." + n + "strikes you back!!!");
                    int damage = power - Program.player.amorValue;
                    int attack = rand.Next(0, Program.player.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose" + damage + "health and deal " + attack + " damage");
                    Program.player.health -= damage;
                    h -= attack;
                }
                else if (userInput.ToLower() == "d" || userInput.ToLower() == "defend")
                {
                    //defend
                }
                else if (userInput.ToLower() == "r" || userInput.ToLower() == "run")
                {
                    //defend
                }
                else if (userInput.ToLower() == "h" || userInput.ToLower() == "heal")
                {
                    //defend
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter A, D, R, or H.");
                    continue;
                }
            }
        }
    }
}
