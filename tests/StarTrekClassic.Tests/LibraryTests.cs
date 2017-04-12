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
            BaseLibraryTests.Computer1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void GalaticRecord1()
        {
            BaseLibraryTests.GalaticRecord1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void StatusReport1()
        {
            BaseLibraryTests.StatusReport1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void TorpedoData1()
        {
            BaseLibraryTests.TorpedoData1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void TorpedoData2()
        {
            BaseLibraryTests.TorpedoData2(StarTrekClassic.Program.Main);
        }

        [Test]
        public void TorpedoData3()
        {
            BaseLibraryTests.TorpedoData3(StarTrekClassic.Program.Main);
        }
    }
}
