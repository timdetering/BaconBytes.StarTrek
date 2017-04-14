using System;

namespace StarTrekClassic.TestFramework
{
    public static class Scenario
    {
        public static void Destroyed(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll +
                           PlaybackTest.Seed +
                           Command.SetCourse +
                           Course.Left +
                           "3" + Environment.NewLine +  //  Warp factor
                           Command.FirePhasers +
                           "1" + Environment.NewLine +  //  Energy units
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "Destroyed.txt");
        }
    }
}
