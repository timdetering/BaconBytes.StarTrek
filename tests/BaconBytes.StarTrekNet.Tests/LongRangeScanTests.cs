using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace BaconBytes.StarTrekNet.Tests
{
    [TestFixture]
    public class LongRangeScanTests
    {
        [Test]
        public void ShortRangeScan1()
        {
            LongRangeScan.LongRangeSensorScan1(Program.Main);
        }
    }
}
