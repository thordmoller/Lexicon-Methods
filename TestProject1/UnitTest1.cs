using Lexicon_Methods;
using static Xunit.Assert;
namespace TestProject1
{
    public class UnitTest1
    {
        /* I have expanded this testcase a little. So instead of using "[Fact]" as shown in the meeting, i use "[Theory]" to test multiple scenarios that should result in the same result.
         * Because i made a method that converts any input name to have the first letter capitalized and the rest lowercase. So i am testing that in different scenarios.
         Update: This first testmethod was made before the Xunit assignment was uploaded*/
        [Theory]
        [InlineData("thord", "möller")]
        [InlineData("THORD", "MÖLLER")]
        [InlineData("tHoRd", "mÖlLeR")]
        public void FormatNameTest(string firstName, string lastName) {

            string expected = "Möller, Thord";

            string actual = AssignmentMethods.FormatName(firstName, lastName);
            Equal(expected, actual);
        }

        //Xunit assignment testmethods:
        [Fact]
        public void Test1() {
            string firstName = "nathaniel";
            string lastName = "haWthorNe";

            string actual = AssignmentMethods.Formatter(firstName, lastName);

            string expected = "#_Hawthorne, Nathaniel (HAWNAT)";

            Equal(expected, actual);
        }

        [Fact]
        public void Test2() {
            string firstName = "ELisabeth";
            string lastName = "GEorge";

            string expected = "#_George, Elisabeth (GEOELI)";

            string actual = AssignmentMethods.Formatter(firstName, lastName);

            Equal(expected, actual);

        }
    }
}