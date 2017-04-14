using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace StarTrekClassic.Tests
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void DamageControlReport1()
        {
            Commands.DamageControlReport1(Program.Main);
        }

        [Test]
        public void ListCommands1()
        {
            Commands.ListCommands1(Program.Main);
        }

        [Test]
        public void LongRangeSensorScan1()
        {
            LongRangeScan.LongRangeSensorScan1(Program.Main);
        }

        [Test]
        public void ShortRangeSensorScan1()
        {
            Commands.ShortRangeSensorScan1(Program.Main);
        }
    }
}
