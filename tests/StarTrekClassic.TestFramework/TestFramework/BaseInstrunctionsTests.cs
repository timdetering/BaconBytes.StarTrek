using System;

namespace StarTrekClassic.TestFramework
{
    public static class BaseInstrunctionsTests
    {
        public static void Print1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll +
                           PlaybackTest.Seed +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "Instructions1.txt");
        }

        public static void Print2(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintPage +
                           "1" + Environment.NewLine +
                           "2" + Environment.NewLine +
                           "3" + Environment.NewLine +
                           PlaybackTest.Seed +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "Instructions2.txt");
        }

        public static void Print3(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.Skip +
                           PlaybackTest.Seed +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "Instructions3.txt");
        }
    }
}
