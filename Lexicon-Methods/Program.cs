using static Lexicon_Methods.AssignmentMethods;     //with this line i don't have to specify the static AssignmentMethods class everytime i call a method from it
using static System.Console;    //same thing for the Console

namespace Lexicon_Methods
{
    internal class Program
    {
        static void Main(string[] args) {
            WriteLine(DisplayUserName());
            WriteLine(PrefixWithHashtag());
            WriteLine(AskUser("ett nummer"));
        }
    }
}