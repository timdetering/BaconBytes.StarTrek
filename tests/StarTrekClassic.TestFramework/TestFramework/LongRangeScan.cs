using System;

namespace StarTrekClassic.TestFramework
{
    public static class LongRangeScan
    {
        public static void LongRangeSensorScan1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.LongRangeSensorScan +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LongRangeSensorScan1.txt");
        }
    }
}
