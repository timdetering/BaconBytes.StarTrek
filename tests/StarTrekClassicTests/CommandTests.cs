using NUnit.Framework;
using StarTrekClassic.Test.PlayTests;

namespace StarTrekClassicTests
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void DamageControlReport1()
        {
            CommandTestsBase.DamageControlReport1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void FirePhasers1()
        {
            CommandTestsBase.FirePhasers1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void FirePhotonTorpedoes1()
        {
            CommandTestsBase.FirePhotonTorpedoes1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void Instructions1()
        {
            CommandTestsBase.Instructions1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void LibraryComputer1()
        {
            CommandTestsBase.LibraryComputer1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void LibraryGalaticRecord1()
        {
            CommandTestsBase.LibraryGalaticRecord1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void LibraryStatusReport1()
        {
            CommandTestsBase.LibraryStatusReport1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void LibraryTorpedoData1()
        {
            CommandTestsBase.LibraryTorpedoData1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void LibraryTorpedoData2()
        {
            CommandTestsBase.LibraryTorpedoData2(StarTrekClassic.Program.Main);
        }

        [Test]
        public void LongRangeSensorScan1()
        {
            CommandTestsBase.LongRangeSensorScan1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void SetCourse1()
        {
            CommandTestsBase.SetCourse1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void ShieldControl1()
        {
            CommandTestsBase.ShieldControl1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void ShortRangeSensorScan1()
        {
            CommandTestsBase.ShortRangeSensorScan1(StarTrekClassic.Program.Main);
        }

    }
}
