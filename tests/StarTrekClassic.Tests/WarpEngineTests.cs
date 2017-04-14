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
            WarpEngines.SetCourse1(Program.Main);
        }

        [Test]
        public void SetCourse2()
        {
            WarpEngines.SetCourse2(Program.Main);
        }

        [Test]
        public void SetCourse3()
        {
            WarpEngines.SetCourse3(Program.Main);
        }

        [Test]
        public void SetCourse4()
        {
            WarpEngines.SetCourse4(Program.Main);
        }
    }
}
