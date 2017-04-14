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
            Shields.Shields1(Program.Main);
        }

        [Test]
        public void Shields2()
        {
            Shields.Shields2(Program.Main);
        }
    }
}
