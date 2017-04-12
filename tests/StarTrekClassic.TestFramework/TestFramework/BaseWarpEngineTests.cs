using System;

namespace StarTrekClassic.TestFramework
{
    public static class BaseWarpEngineTests
    {
        public static void SetCourse1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.SetCourse +
                           Command.SetCourse.InvalidCourse +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "SetCourse1.txt");
        }

        public static void SetCourse2(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.SetCourse +
                           "6" + Environment.NewLine +  //  Course
                           "4" + Environment.NewLine +  //  Warp factor
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "SetCourse2.txt");
        }

        public static void SetCourse3(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.SetCourse +
                           "2" + Environment.NewLine +  //  Course
                           "1" + Environment.NewLine +  //  Warp factor
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "SetCourse3.txt");
        }

    }
}
