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

            //Console.WriteLine("Enter the string");
            //WordCount.Count(Console.ReadLine());

            Console.WriteLine("Running as {0}", Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));
            using (HttpListener s = new HttpListener())
            {
                s.Prefixes.Add("http://localhost:49154/vshub/418f29b9cebf4d6bae64d16162f56832/");
                s.Start();
                Console.WriteLine("Server started");
            }

            Console.WriteLine("Server stopped");

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
