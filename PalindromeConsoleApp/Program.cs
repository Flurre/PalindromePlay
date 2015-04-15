using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tdd_Palindrome;

namespace TDD_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeFinder p = new PalindromeFinder();

            while (true)
            {
                Console.WriteLine("Enter a word pls: ");
                var value = Console.ReadLine();
                if (value == "q")
                    break;

                try
                {
                    if (p.IsPalindrome(value))
                    {
                        Console.WriteLine("Yey! The word is a Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("The word is not a palindrome... :(");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
