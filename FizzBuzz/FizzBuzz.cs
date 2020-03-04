using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        
        public static void Main(String[] args)
        {
            Dictionary<int, string> fizzAndBuzz = new Dictionary<int, string>();

            fizzAndBuzz.Add(3, "Fizz");
            fizzAndBuzz.Add(5, "Buzz");
            //fizzAndBuzz.Add(7, "Foo");
            //fizzAndBuzz.Add(11, "Bar");

            string outputLine;
            for (int i = 1; i <= 100; i++)
            {
                outputLine = "";
                bool isInDict = false;
                foreach (var item in fizzAndBuzz)
                {
                    
                    if (checkFactors(i, item.Key))
                    {
                        outputLine += item.Value;
                        isInDict = true;
                    }
                }
                if (!isInDict)
                {
                    outputLine = i.ToString();
                }
                Console.WriteLine(outputLine);
            }
            Console.ReadLine();
        }

        private static bool checkFactors(int number, int factor)
        {
            if (number % factor == 0)
            {
                return true;
            } else
            {
                return false;
            }

        }
    }
}
