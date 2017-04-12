using System;

namespace StarTrekClassic.TestFramework
{
    public class BaseCommandTests
    {
        public static void Instructions1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "Instructions1.txt");
        }

        public static void DamageControlReport1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.DamageControlReport +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "DamageControlReport1.txt");
        }


        public static void LongRangeSensorScan1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.LongRangeSensorScan +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LongRangeSensorScan1.txt");
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