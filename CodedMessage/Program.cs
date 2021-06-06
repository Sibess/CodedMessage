using System;

namespace CodedMessage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HackerSpeak("javascript is cool"));
        }

        public static string HackerSpeak(string str)
        {
           string replacedMessage= str.Replace("a", "4").Replace("e", "3").Replace("i", "1").Replace("o", "0").Replace("s", "5");
           return replacedMessage;
        }
    }
}
