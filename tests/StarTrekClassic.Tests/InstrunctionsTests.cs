using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace StarTrekClassic.Tests
{
    [TestFixture]
    public class InstrunctionsTests
    {
        [Test]
        public void PrintAll()
        {
            Instructions.PrintAll(Program.Main);
        }

        [Test]
        public void PrintPage()
        {
            Instructions.PrintPage(Program.Main);
        }

        [Test]
        public void Skip()
        {
            Instructions.Skip(Program.Main);
        }
    }
}
