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
            Phasers.FirePhasers1(Program.Main);
        }

        [Test]
        public void FirePhasers2()
        {
            Phasers.FirePhasers2(Program.Main);
        }

        [Test]
        public void FirePhasers3()
        {
            Phasers.FirePhasers3(Program.Main);
        }
    }
}
