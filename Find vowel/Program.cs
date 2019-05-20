using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_vowel
{
    //This is used to find the vowel//
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any char");
            char ch = char.Parse(Console.ReadLine());
            String str = ch.ToString().ToLower();
            switch (str)
            {
                case "a":
                    Console.Write(str + " is a vowel");
                    break;
                case "e":
                    Console.Write(str + " is a vowel");
                    break;
                case "i":
                    Console.Write(str + " is a vowel");
                    break;
                case "o":
                    Console.Write(str + " is a vowel");
                    break;
                case "u":
                    Console.Write(str + " is a vowel");
                    break;
                default:
                    Console.Write(str + " is not a vowel");
                    break;

            }
        }
    }
}
