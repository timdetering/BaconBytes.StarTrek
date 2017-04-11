using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace StarTrekClassic.Tests
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void DamageControlReport1()
        {
            BaseCommandTests.DamageControlReport1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void FirePhasers1()
        {
            BaseCommandTests.FirePhasers1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void Instructions1()
        {
            BaseCommandTests.Instructions1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void LibraryComputer1()
        {
            BaseCommandTests.LibraryComputer1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void LibraryGalaticRecord1()
        {
            BaseCommandTests.LibraryGalaticRecord1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void LibraryStatusReport1()
        {
            BaseCommandTests.LibraryStatusReport1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void LibraryTorpedoData1()
        {
            BaseCommandTests.LibraryTorpedoData1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void LibraryTorpedoData2()
        {
            BaseCommandTests.LibraryTorpedoData2(StarTrekClassic.Program.Main);
        }

        [Test]
        public void LongRangeSensorScan1()
        {
            BaseCommandTests.LongRangeSensorScan1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void ShieldControl1()
        {
            BaseCommandTests.ShieldControl1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void ShortRangeSensorScan1()
        {
            BaseCommandTests.ShortRangeSensorScan1(StarTrekClassic.Program.Main);
        }

    }
}
