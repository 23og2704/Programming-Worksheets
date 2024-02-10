using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W109___C__Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter first list separated by spaces: ");
            string words = Console.ReadLine();
            string[] wordsplit = words.Split(' ');
            List<string> list = new List<string>(wordsplit);
            Console.WriteLine("Enter second list separated by spaces: ");
            string words2 = Console.ReadLine();
            string[] wordsplit2 = words2.Split(' ');
            List<string> list2 = new List<string>(wordsplit2);

            List<string> diffList = new List<string>(list);
            
            for (int i = list2.Count - 1; i >= 0; i--)
            {
                if (list.Remove(list2[i]))
                {
                    diffList.Add(list2[i]);
                }
            }
            Console.WriteLine(diffList);

            Console.ReadKey();
            */
            Console.Write("Enter the first string of words with spaces: ");
            string words = Console.ReadLine();
            string[] wordsArray1 = words.Split(' ');
            List<string> wordsList1 = new List<string>(wordsArray1);
            Console.Write("Enter the second string of words with spaces: ");
            string userInput2 = Console.ReadLine();
            string[] wordsArray2 = userInput2.Split(' ');
            List<string> wordsList2 = new List<string>(wordsArray2);
            List<string> diffList = new List<string>();
            for (int i = wordsList2.Count - 1; i >= 0; i--)
            {
                if (wordsList1.Remove(wordsList2[i]))
                {
                    diffList.Add(wordsList2[i]);
                }
            }
            Console.WriteLine("Words in the first list but not in the second list: [" + string.Join(", ", diffList) + "]");
            Console.ReadKey();
        }
    }
}
