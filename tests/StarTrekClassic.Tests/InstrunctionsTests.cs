using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace StarTrekClassic.Tests
{
    [TestFixture]
    public class InstrunctionsTests
    {
        [Test]
        public void Print1()
        {
            BaseInstrunctionsTests.Print1(Program.Main);
        }

        [Test]
        public void Print2()
        {
            BaseInstrunctionsTests.Print2(Program.Main);
        }

        [Test]
        public void Print3()
        {
            BaseInstrunctionsTests.Print3(Program.Main);
        }
    }
}
