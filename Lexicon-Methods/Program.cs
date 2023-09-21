using static Lexicon_Methods.AssignmentMethods;     //with this line i don't have to specify the AssignmentMethods class everytime i call a method from it
using static System.Console;    //same thing for the Console

namespace Lexicon_Methods
{
    internal class Program
    {
        static void Main(string[] args) {

            //Just some personal testruns of the methods

            WriteLine(DisplayUserName());
            WriteLine(PrefixUserInputWithHashtag());
            WriteLine(FormatName("Thord", "Möller"));
            WriteLine(Formatter("tHoRd", "mÖlLeR"));
        }
    }
}