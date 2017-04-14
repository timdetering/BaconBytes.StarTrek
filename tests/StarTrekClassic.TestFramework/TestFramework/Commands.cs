using System;

namespace StarTrekClassic.TestFramework
{
    public static class Commands
    {
        public static void ListCommands1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.Skip +
                           PlaybackTest.Seed +
                           Environment.NewLine +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "ListCommands1.txt");
        }

        public static void DamageControlReport1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.DamageControlReport +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "DamageControlReport1.txt");
        }

        public static void ShortRangeSensorScan1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.ShortRangeSensorScan +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "ShortRangeSensorScan1.txt");
        }
    }
}
