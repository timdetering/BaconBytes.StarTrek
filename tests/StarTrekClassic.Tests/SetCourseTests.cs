using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace StarTrekClassic.Tests
{
    [TestFixture]
    public class SetCourseTests
    {
        [Test]
        public void SetCourse1()
        {
            BaseSetCourseTests.SetCourse1(Program.Main);
        }

        [Test]
        public void SetCourse2()
        {
            BaseSetCourseTests.SetCourse2(Program.Main);
        }

        [Test]
        public void SetCourse3()
        {
            BaseSetCourseTests.SetCourse3(Program.Main);
        }
    }
}
