using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace StarTrekClassic.Tests
{
    [TestFixture]
    public class ScenarioTests
    {
        [Test]
        public void Destroyed()
        {
            Scenario.Destroyed(Program.Main);
        }
    }
}
