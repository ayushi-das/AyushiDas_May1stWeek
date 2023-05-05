using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to check whether it is Palindrome or not");
            string s=Console.ReadLine();
            bool isPalindrome = true;

            for(int i=0; i<s.Length/2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
                    
            }
         Console.WriteLine($"The entered string is {(isPalindrome ? "a palindrome" : "not a palindrome")}");

        }
    }
}
