using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lexicon_Methods
{
    internal class AssignmentMethods
    {
        /// <summary>
        /// Asks user to enter its name
        /// </summary>
        /// <returns>Entered name as string</returns>
        public static string DisplayUserName() {
            return AskUser("Please enter your name");
        }

        /// <summary>
        /// Asks user to enter a word.
        /// </summary>
        /// <returns>entered word prefixed with a hashtag</returns>
        public static string PrefixWithHashtag() {
            return "#" + AskUser("Please enter a word");
        }

        /// <summary>
        /// Asks the user something
        /// </summary>
        /// <param name="question">question for the user</param>
        /// <returns>The users answer</returns>
        public static string AskUser(string question) {
            string? answer;
            WriteLine(question);
            answer = ReadLine();
            return answer ?? "No answer was given";
        }

    }
}
