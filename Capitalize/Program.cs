using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence :");
            string s = Console.ReadLine(); 
            string[] words= s.Split(' ');   

            foreach(string word in words)
            {
                char[] letters= word.ToCharArray();
                letters[0] = char.ToUpper(letters[0]);
                letters[letters.Length - 1] = char.ToUpper(letters[letters.Length-1]);
                string Cwords = new string(letters);
                Console.Write(" "+Cwords);
            }
        }
    }
}
