using System;

namespace StarTrekClassic.TestFramework
{
    public static class BasePhotonTorpedoTests
    {
        public static void FireTorpedo1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.FirePhotonTorpedo +
                           "1" + Environment.NewLine +  //  Course
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "FirePhotonTorpedo1.txt");
        }

        public static void FireTorpedo2(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.FirePhotonTorpedo +
                           "6" + Environment.NewLine +  //  Course
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "FirePhotonTorpedo2.txt");
        }

        public static void FireTorpedo3(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.SetCourse +
                           "2" + Environment.NewLine +  //  Course
                           "1" + Environment.NewLine +  //  Warp factor
                           Command.CallOnLibraryComputer +
                           Command.CallOnLibraryComputer.TorpedoData +
                           Command.Exit +
                           Command.FirePhotonTorpedo +
                           "4" + Environment.NewLine +  //  Course
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "FirePhotonTorpedo3.txt");
        }
    }
}
