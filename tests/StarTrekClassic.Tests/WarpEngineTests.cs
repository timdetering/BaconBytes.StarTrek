using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace StarTrekClassic.Tests
{
    [TestFixture]
    public class WarpEngineTests
    {
        [Test]
        public void SetCourse1()
        {
            BaseWarpEngineTests.SetCourse1(Program.Main);
        }

        [Test]
        public void SetCourse2()
        {
            BaseWarpEngineTests.SetCourse2(Program.Main);
        }

        [Test]
        public void SetCourse3()
        {
            BaseWarpEngineTests.SetCourse3(Program.Main);
        }
    }
}
