using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Methods
{
    internal class AssignmentMethods
    {
        public static void DisplayUserMessage() {
            string? name;
            string? text;
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter a statement that represents you");
            text = Console.ReadLine();
            Console.WriteLine(name + " says: " + text);
        }

    }
}
