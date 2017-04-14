using NUnit.Framework;
using StarTrekClassic.TestFramework;

namespace BaconBytes.StarTrekNet.Tests
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void ListCommands1()
        {
            Commands.ListCommands1(Program.Main);
        }
    }
}
