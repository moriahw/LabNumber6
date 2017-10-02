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
            bool programContinue = true;

            Console.WriteLine("Welcome to the Pig Latin Translator");

            while (programContinue == true)
            {

                
                Console.WriteLine("Please enter a word to be translated: ");
                userWord = Console.ReadLine().ToLower();

                //another option
                //str.StartsWith("a") || str.StartsWith("e") || etc...

                //add user validation for yes and no

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
           
                Console.WriteLine("Would you like to enter another word?");

                string UserOption = ValidateUserInput(); //assign variable to call on method

                if (UserOption == "no" || UserOption== "n") //checks user input based off called method conditions and kills program if conditions are met
                    programContinue = false;
            }
           
            
        }

        public static string ValidateUserInput() //create method to validate user response 
        {
            string userResponse = Console.ReadLine().ToLower(); //assigns user input to a variable and converts to lowercase in all instances
            
            while (userResponse != "y" && userResponse != "yes" && userResponse != "n" && userResponse != "no") //checks if user input is NOT any of the listed options and prompts user to enter yes or no
            {
                Console.WriteLine("Please enter yes or no!");
                userResponse = Console.ReadLine().ToLower();
            }

            return userResponse; //returns the user input to the main method 

        }


    }
}
