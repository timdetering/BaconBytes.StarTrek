using System;

namespace StarTrekClassic.TestFramework
{
    public static class Phasers
    {
        public static void FirePhasers1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.FirePhasers +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "FirePhasers1.txt");
        }

        public static void FirePhasers2(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.SetCourse +
                           "2" + Environment.NewLine +  //  Course
                           "1" + Environment.NewLine +  //  Warp factor
                           Command.FirePhasers +
                           "100" + Environment.NewLine +  //  Units of energy
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "FirePhasers2.txt");
        }

        public static void FirePhasers3(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.Shields +
                           "52" + Environment.NewLine + //  Energy units
                           Command.SetCourse +
                           "2" + Environment.NewLine +  //  Course
                           "1" + Environment.NewLine +  //  Warp factor
                           Command.FirePhasers +
                           "310" + Environment.NewLine +  //  Units of energy
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "FirePhasers3.txt");
        }
    }
}
