using System;
using KataBowling;
using NUnit.Framework;

namespace KataBowlingTests
{
    [TestFixture]
    public class InputTests
    {
        [Test]
        public void The_program_should_have_args_passed_in()
        {
            Program.Main(new[] { "foo" });
            Assert.AreEqual(Program.Rolls, "foo");
        }

        [Test]
        public void The_program_should_set_the_rolls_to_the_first_arg_passed_in()
        {
            Program.Main(new[] { "foo", "bar" });
            Assert.AreEqual(Program.Rolls, "foo");
        }

        [Test]
        public void An_empty_args_should_throw_an_InvalidArgumentsException()
        {
            Assert.Throws(typeof(InvalidArgumentsException), () => Program.Main(null));
        }
    }
}
