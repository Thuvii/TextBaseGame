using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextBaseGame
{
    internal class Program
    {

        public static Player player = new Player();



        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEncounter();
        }

        static void Start()
        {
            Console.WriteLine("Dark's Dungeon");
            Console.WriteLine("Name:");
            player.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake in a cold, stone, dark room. " +
                "\nYou feel dazed and are having trouble remebering" +
                "\nanything about your past.");
            if (player.name != "")
            {
                player.name = player.name.Substring(0, 1).ToUpper() + player.name.Substring(1);
                Console.WriteLine($"\'{player.name}\'");
            }
            else
            {
                Console.WriteLine("You can't even remember your own name...");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You grope around in darknes until you find the door handle.\n" +
                "You feel some resistance as you turn the handle, but the rusty lock breaks with little effort.\n" +
                "You see your captor standing with his back to you outside the door.");
        }
    }
}
