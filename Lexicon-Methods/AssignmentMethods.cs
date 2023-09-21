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
            //Update: I realized that maybe it would result in slightly less code if i simply didnt make a method for this, but i did it anyway since i prefix something at least twice

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
        /// <returns>Lastname, Firstname</returns>
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

        /// <summary>
        /// Xunit assignment: Formats a first and lastname and prefixes it with "#_" followed by capitalized 3 first letters of first and lastname.
        /// The FormatName method will be used for this
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>example: "#_Möller, Thord (MÖLTHO)"</returns>
        public static string Formatter(string firstName, string lastName) {

            string fullName = FormatName(firstName, lastName);  //formatting the first and last name to display in full with lastname first
            string threeFirst = ThreeLetterLastNameFirst(firstName, lastName);  //the 3 letter version

            string output = fullName + " (" + threeFirst + ")";     //combining the two

            output = PrefixString("#_", output);    //adding the prefix to the whole output

            return output;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>A string combining only 3 first letters of first and last name capitalized, with the lastname coming first </returns>
        private static string ThreeLetterLastNameFirst(string firstName, string lastName) {

            string output = ThreeFirstOnlyCapitalized(lastName) + ThreeFirstOnlyCapitalized(firstName);
            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Only the first 3 letters of a string uppercased</returns>
        private static string ThreeFirstOnlyCapitalized(string input) {

            string output = input.Substring(0, 3);  //3 first
            output = output.ToUpper(); //uppercase

            return output;
        }

    }
}
