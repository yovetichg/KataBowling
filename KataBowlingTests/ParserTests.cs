using KataBowling;
using NUnit.Framework;

namespace KataBowlingTests
{
    [TestFixture]
    public class ParserTests
    {
        [Test]
        public void The_parser_should_have_a_string_to_read()
        {
            var parser = new Parser("X8/91XX8190X7/5/2");
            Assert.AreEqual("X8/91XX8190X7/5/2", parser.Input);
        }

        [TestCase("X8/91XX8190X7/5/2", true)]
        [TestCase("XXX", true)]
        [TestCase("foo", false)]
        [TestCase("123456789.##", false)]
        public void The_parser_should_only_accept_valid_characters(string input, bool expectedValidity)
        {
            var parser = new Parser(input);
            Assert.AreEqual(expectedValidity, parser.IsValidInput());
        }
    }
}
