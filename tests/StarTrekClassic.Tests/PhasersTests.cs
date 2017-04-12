using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace StarTrekClassic.Tests
{
    [TestFixture]
    public class PhasersTests
    {
        [Test]
        public void FirePhasers1()
        {
            BasePhasersTests.FirePhasers1(Program.Main);
        }

        [Test]
        public void FirePhasers2()
        {
            BasePhasersTests.FirePhasers2(Program.Main);
        }

        [Test]
        public void FirePhasers3()
        {
            BasePhasersTests.FirePhasers3(Program.Main);
        }
    }
}
