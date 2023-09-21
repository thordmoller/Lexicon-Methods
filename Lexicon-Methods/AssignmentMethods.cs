using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    //To not have to specify the Console class everytime i use the console methods

namespace Lexicon_Methods
{
    public class AssignmentMethods
    {
        /// <summary>
        /// Task 1: Asks user to enter its name
        /// </summary>
        /// <returns>Entered name as string</returns>
        public static string DisplayUserName() {

            //the EnterSomething method is used for ultra simplicity
            return EnterSomething("name");
        }

        /// <summary>
        /// Task 2: Asks user to enter a word.
        /// </summary>
        /// <returns>entered word prefixed with a hashtag</returns>
        public static string PrefixUserInputWithHashtag() {

            return PrefixString("#", EnterSomething("word"));
        }

        /// <summary>
        /// prefixes a given input string with a given prefix
        /// </summary>
        /// <param name="input"></param>
        /// <param name="prefix"></param>
        /// <returns>string input prefixed with string prefix</returns>
        private static string PrefixString(string prefix, string input) {

            //I made this method mostly for the Xunit assignment, but it's also convenient to use in the PrefixUserInputWithHashtag method

            return prefix + input;
        }

        /// <summary>
        /// Task 3: Asks the user something
        /// </summary>
        /// <param name="question">question for the user</param>
        /// <returns>The users answer</returns>
        private static string AskUser(string question) {

            string? answer;

            WriteLine(question);
            answer = ReadLine();

            return answer ?? "No answer was given";
        }

        /// <summary>
        /// Task 4: Asks the user to enter something
        /// </summary>
        /// <param name="word">Subject the user should enter</param>
        /// <returns>The users answer</returns>
        private static string EnterSomething(string word) {

            //i had an idea of overriding the AskUser method instead with an extra parameter, but ended up thinking its clearer if this method has its own name

            return AskUser("Please enter a " + word);
        }

        /// <summary>
        /// Formats the way a first and last name are displayed
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>lastname, firstname</returns>
        public static string FormatName(string firstName, string lastName) {

            firstName = CapitalizeFirstChar(firstName);
            lastName = CapitalizeFirstChar(lastName);

            return lastName + ", " + firstName;
        }

        /// <summary>
        /// Capitalizes first letter of a string while making sure the rest of the letters are lowercase
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Capitalized first letter followed by lowercase letters string</returns>
        private static string CapitalizeFirstChar(string input) {

            // I made this method myself for fun. To convert any string to use the first char as capitalized and the rest as lowercase.
            //Update: Now it's also part of the Xunit assignment that was just released

            string output = input[0].ToString().ToUpper() + input.Substring(1).ToLower();

            return output;
        }

    }
}
