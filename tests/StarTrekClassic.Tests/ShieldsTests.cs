using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace StarTrekClassic.Tests
{
    [TestFixture]
    public class ShieldsTests
    {
        [Test]
        public void Shields1()
        {
            BaseShieldsTests.Shields1(Program.Main);
        }

        [Test]
        public void Shields2()
        {
            BaseShieldsTests.Shields2(Program.Main);
        }

    }
}
