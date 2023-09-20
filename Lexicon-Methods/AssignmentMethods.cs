using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    //To not have to specify the Console class everytime i use the console methods

namespace Lexicon_Methods
{
    internal class AssignmentMethods
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
        public static string PrefixWithHashtag() {

            return "#" + EnterSomething("word");
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

            return AskUser("Please enter a " + word);
        }

        /// <summary>
        /// Formats the way a first and last name are displayed
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>lastname, firstname</returns>
        public static string FormatName(string firstName, string lastName) {

            return lastName + ", " + firstName;
        }

    }
}
