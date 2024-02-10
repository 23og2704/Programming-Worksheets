using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace W100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random rand = new Random();
            int num = rand.Next(1, 10);
            Console.WriteLine(num);
            double doub = rand.NextDouble();
            Console.WriteLine(doub);
            if (doub <= 0.5) 
            {
                Console.WriteLine("Heads");
            } else 
            {
                Console.WriteLine("Tails");
            }
            Console.ReadKey();
            */
            string result = "";
            int streak = 0;
            int beststreak = 0;
            Random rnd = new Random();
            while (true)
            {
                int coin = rnd.Next(2);
                if (coin == 0)
                {
                     result = "heads";
                }else if (coin == 1)
                {
                     result = "tails";
                }
                Console.WriteLine("Guess either heads or tails: ");
                string guess = Console.ReadLine();
                Console.WriteLine($"Coin landed on {result}!\n");
                if  (guess == "heads" && result == "heads")
                {
                    streak++;
                    Console.WriteLine($"Correct! Your streak is currently {streak}. Your best streak is {beststreak}\n");
                    if (streak > beststreak)
                    {
                        beststreak = streak;
                    }
                } 
                else if (guess == "tails" && result == "tails")
                {
                    streak++;
                    Console.WriteLine($"Correct! Your streak is currently {streak}. Your best streak is {beststreak}\n");
                    if (streak > beststreak)
                    {
                        beststreak = streak;
                    }
                }
                else
                {
                    Console.WriteLine($"Incorrect, your streak has been reset! Your best streak is {beststreak}\n");
                    streak = 0;
                }
            }

        }
    }
}
