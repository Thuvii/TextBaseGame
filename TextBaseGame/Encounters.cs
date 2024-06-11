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
            Combat(false, "Human Rouge", 1, 4);
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
                Console.WriteLine("========================");
                Console.WriteLine("  Potion: " + Program.player.potion + "  Health: " + Program.player.health);
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "a" || userInput.ToLower() == "attack")
                {
                    //acttack
                    Console.WriteLine("With haste you surge forth, your sword flying in your hand!\n" +
                    "As you pass. " + n + " strikes you back!!!");
                    int damage = p - Program.player.amorValue;
                    DamageCheck(damage);
                    int attack = rand.Next(0, Program.player.weaponValue) / 2;
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.player.health -= damage;
                    h -= attack;
                }
                else if (userInput.ToLower() == "d" || userInput.ToLower() == "defend")
                {
                    //defend
                    Console.WriteLine("As the " + n + " prepares to strike, you ready your sword in the defensive stance");
                    int damage = (p / 4) - Program.player.amorValue;
                    DamageCheck(damage);
                    int attack = rand.Next(0, Program.player.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.player.health -= damage;
                    h -= attack;
                }
                else if (userInput.ToLower() == "r" || userInput.ToLower() == "run")
                {
                    //run
                    int damage = p - Program.player.amorValue;
                    DamageCheck(damage);
                    int chance = rand.Next(0, 2);
                    if (chance == 0)
                    {
                        Console.WriteLine("As you sprint aways from the " + n + ", its strike catches you in the back,\nsending you spin on the ground");
                        Console.WriteLine("You lose " + damage + " health and unable to escape");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You sprint as fast as you can to evade the " + n + " and you successfully escape");
                        Console.ReadKey();
                        //go to store
                    }

                }
                else if (userInput.ToLower() == "h" || userInput.ToLower() == "heal")
                {
                    //heal

                    if (Program.player.potion == 0)
                    {
                        Console.WriteLine("As you desperatly grasp for a potion in your bag,\n all that you feel are empty glass flasks");
                        int damage = p - Program.player.amorValue;
                        DamageCheck(damage);
                        Console.WriteLine("The" + n + " strikes you with a mighty blow and you lose " + damage + " health");
                    }
                    else
                    {
                        Console.WriteLine("You reach into your bag and pull put a glowing, purple flask.\nYou take a long drink.");
                        int potionV = 5;
                        Console.WriteLine("You gain " + potionV + " health");
                        Program.player.health += potionV;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter A, D, R, or H.");
                    continue;
                }
                Console.ReadKey();
            }
        }
        static int DamageCheck(int damage)
        {
            if (damage < 0)
                return 0;
            else
                return damage;
        }



    }
}
