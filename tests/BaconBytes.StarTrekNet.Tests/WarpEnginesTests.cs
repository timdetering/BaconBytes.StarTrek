using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace BaconBytes.StarTrekNet.Tests
{
    [TestFixture]
    public class WarpEnginesTests
    {
        [Test]
        public void SetCourse1()
        {
            WarpEngines.SetCourse1(Program.Main);
        }
    }
}
