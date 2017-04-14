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
            PhotonTorpedo.FireTorpedo1(Program.Main);
        }

        [Test]
        public void FirePhotonTorpedo2()
        {
            PhotonTorpedo.FireTorpedo2(Program.Main);
        }

        [Test]
        public void FirePhotonTorpedo3()
        {
            PhotonTorpedo.FireTorpedo3(Program.Main);
        }
    }
}
