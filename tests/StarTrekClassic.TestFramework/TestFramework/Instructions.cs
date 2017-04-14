using System;

namespace StarTrekClassic.TestFramework
{
    public static class Instructions
    {
        public static void PrintAll(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll +
                           PlaybackTest.Seed +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "InstructionsPrintAll.txt");
        }

        public static void PrintPage(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintPage +
                           "1" + Environment.NewLine +
                           "2" + Environment.NewLine +
                           "3" + Environment.NewLine +
                           PlaybackTest.Seed +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "InstructionsPrintPage.txt");
        }

        public static void Skip(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.Skip +
                           PlaybackTest.Seed +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "InstructionsSkip.txt");
        }
    }
}
