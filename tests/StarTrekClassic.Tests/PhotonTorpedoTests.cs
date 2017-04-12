using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace StarTrekClassic.Tests
{
    [TestFixture]
    public class PhotonTorpedoTests
    {
        [Test]
        public void FirePhotonTorpedo1()
        {
            BasePhotonTorpedoTests.FireTorpedo1(Program.Main);
        }

        [Test]
        public void FirePhotonTorpedo2()
        {
            BasePhotonTorpedoTests.FireTorpedo2(Program.Main);
        }

        [Test]
        public void FirePhotonTorpedo3()
        {
            BasePhotonTorpedoTests.FireTorpedo3(Program.Main);
        }
    }
}
