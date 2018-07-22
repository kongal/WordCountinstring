using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WordcountInstring
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the string");
            WordCount.Count(Console.ReadLine());

         

        }

        public static class WordCount
        {
            public static int Count(string x)
            {
                int result = 0;

                //Trim whitespace from beginning and end of string
                x = x.Trim();

                //Necessary because foreach will execute once with empty string returning 1
                if (x == "")
                    return 0;

                //Ensure there is only one space between each word in the passed string
                while (x.Contains("  "))
                    x = x.Replace("  ", " ");

                //Count the words
                foreach (string y in x.Split(' '))
                    result++;

                return result;
            }
        }
    }
}
