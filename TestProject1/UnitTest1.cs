using Lexicon_Methods;
using static Xunit.Assert;
namespace TestProject1
{
    public class UnitTest1
    {
        /* I have expanded this testcase a little. So instead of using "[Fact]" as shown in the meeting, i use "[Theory]" to test multiple scenarios that should result in the same.
         * Here because i made a method that converts any input name to have the first letter capitalized and the rest lowercase. So i am testing that in different scenarios.*/
        [Theory]
        [InlineData("thord", "möller")]
        [InlineData("THORD", "MÖLLER")]
        [InlineData("tHoRd", "mÖlLeR")]
        public void FormatNameTest(string firstName, string lastName) {

            string expected = "Möller, Thord";

            string actual = AssignmentMethods.FormatName(firstName, lastName);
            Equal(expected, actual);
        }
    }
}