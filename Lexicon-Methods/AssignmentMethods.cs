using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Methods
{
    internal class AssignmentMethods
    {
        /// <summary>
        /// Asks user for their name and a statement. Prints both
        /// </summary>
        public static void DisplayUserName() {
            string? name;
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine(name);
        }



    }
}
