using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWord;

            Console.WriteLine("Welcome to the Pig Latin Translator");
            userWord = Console.ReadLine().ToLower();

            if (userWord[0] == 'a' || userWord[0] == 'e' || userWord[0] == 'i' || userWord[0] == 'o' || userWord[0] == 'u') //isolates the first index of the string and checks if it's a vowel 
            {
                Console.WriteLine(userWord + "way");
            }
            else
            {
                char[] chars = { 'a', 'e', 'i', 'o', 'u' };
                int firstInstance = userWord.IndexOfAny(chars);
                Console.WriteLine(userWord.Substring(firstInstance) + userWord.Substring(0, firstInstance) + "ay");
                
            }
             
            

        }


    }
}
