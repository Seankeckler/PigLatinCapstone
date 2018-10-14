using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinCaptstone
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run == true)
            {
                Console.Clear();
                Console.WriteLine("Pig Latin!");
                Console.Write("Enter a word/sentence to be changed into pig latin: ");
                string userEnteredWords = Console.ReadLine();
                string[] split = userEnteredWords.Split();

                foreach (string beenSplit in split)
                {
                    if (beenSplit.StartsWith("a") ||
                        (beenSplit.StartsWith("e")) ||
                        (beenSplit.StartsWith("i")) ||
                        (beenSplit.StartsWith("o")) ||
                        (beenSplit.StartsWith("u")))
                    {
                        Console.WriteLine(beenSplit + "way");
                    }
                    else if (!(beenSplit.StartsWith("a") ||
                        (beenSplit.StartsWith("e")) ||
                        (beenSplit.StartsWith("i")) ||
                        (beenSplit.StartsWith("o")) ||
                        (beenSplit.StartsWith("u"))))
                    {
                        string beenPigLatinified = PigLatinify(beenSplit);
                        Console.WriteLine(beenPigLatinified);


                    }
                    else
                    {
                        Console.WriteLine("I need you to enter a sentence or a word.");
                    }
                }
                run = Continue();

            }

            

        }
        public static string PigLatinify(string latined)
        {
            string vowels = "aeiouAEIOU";
            for (int i = 0; i < latined.Length; i++)
            {
                if (vowels.Contains(latined[i]))
                {
                    string prefix = latined.Substring(0, i);
                    string suffix = latined.Substring(i);
                    latined = suffix + prefix + "ay";
                    break;
                }
            }
            return latined;
        }

        public static bool Continue()
        {
            bool run;

            Console.WriteLine("Do you want to do more translations? y/n");
            string answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "y")
            {
                run = true;
            }
            else if (answer == "n")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Sorry that is not an acceptable answer");
                run = Continue();
            }
            return run;
        }


    }
}
