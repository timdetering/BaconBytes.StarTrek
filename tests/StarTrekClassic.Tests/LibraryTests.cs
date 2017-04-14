using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace StarTrekClassic.Tests
{
    [TestFixture]
    public class LibraryTests
    {
        [Test]
        public void Computer1()
        {
            LibraryComputer.Computer1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void GalaticRecord1()
        {
            LibraryComputer.GalaticRecord1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void GalaticRecord2()
        {
            LibraryComputer.GalaticRecord2(StarTrekClassic.Program.Main);
        }

        [Test]
        public void StatusReport1()
        {
            LibraryComputer.StatusReport1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void TorpedoData1()
        {
            LibraryComputer.TorpedoData1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void TorpedoData2()
        {
            LibraryComputer.TorpedoData2(StarTrekClassic.Program.Main);
        }

        [Test]
        public void TorpedoData3()
        {
            LibraryComputer.TorpedoData3(StarTrekClassic.Program.Main);
        }
    }
}
