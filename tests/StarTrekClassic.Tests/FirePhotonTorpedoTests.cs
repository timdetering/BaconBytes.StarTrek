using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace StarTrekClassic.Tests
{
    [TestFixture]
    public class FirePhotonTorpedoTests
    {
        [Test]
        public void FirePhotonTorpedo1()
        {
            BaseFirePhotonTorpedoTests.FirePhotonTorpedo1(StarTrekClassic.Program.Main);
        }

        [Test]
        public void FirePhotonTorpedo2()
        {
            BaseFirePhotonTorpedoTests.FirePhotonTorpedo2(StarTrekClassic.Program.Main);
        }
    }
}
