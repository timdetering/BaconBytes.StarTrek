using System;

namespace StarTrekClassic.TestFramework
{
    public static class BaseFirePhotonTorpedoTests
    {
        public static void FirePhotonTorpedo1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.FirePhotonTorpedo +
                           "1" + Environment.NewLine +  //  Course
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "FirePhotonTorpedo1.txt");
        }

        public static void FirePhotonTorpedo2(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.FirePhotonTorpedo +
                           "6" + Environment.NewLine +  //  Course
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "FirePhotonTorpedo2.txt");
        }
    }
}
