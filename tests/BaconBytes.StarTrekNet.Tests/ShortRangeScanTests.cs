using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace BaconBytes.StarTrekNet.Tests
{
    [TestFixture]
    public class ShortRangeScanTests
    {
        [Test]
        public void ShortRangeScan1()
        {
            Commands.ShortRangeSensorScan1(Program.Main);
        }

    }
}
