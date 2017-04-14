using System;

namespace StarTrekClassic.TestFramework
{
    public static class LibraryComputer
    {
        public static void Computer1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.CallOnLibraryComputer +
                           "3" + Environment.NewLine +  // Invalid command
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LibraryComputer1.txt");
        }

        public static void GalaticRecord1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.CallOnLibraryComputer +
                           Command.CallOnLibraryComputer.CumulativeGalaticRecord +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LibraryGalaticRecord1.txt");
        }

        public static void GalaticRecord2(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll +
                           PlaybackTest.Seed +
                           Command.LongRangeSensorScan +
                           Command.CallOnLibraryComputer +
                           Command.CallOnLibraryComputer.CumulativeGalaticRecord +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LibraryGalaticRecord2.txt");
        }


        public static void StatusReport1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.CallOnLibraryComputer +
                           Command.CallOnLibraryComputer.StatusReport +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LibraryStatusReport1.txt");
        }

        public static void TorpedoData1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.CallOnLibraryComputer +
                           Command.CallOnLibraryComputer.TorpedoData +
                           "0" + Environment.NewLine +  // Invalid command
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LibraryTorpedoData1.txt");
        }

        public static void TorpedoData2(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.CallOnLibraryComputer +
                           Command.CallOnLibraryComputer.TorpedoData +
                           Command.CallOnLibraryComputer.TorpedoData.UseCalculator +
                           "1,1,1,1" + Environment.NewLine +  //
                           "0" + Environment.NewLine +  // Invalid command
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LibraryTorpedoData2.txt");
        }

        public static void TorpedoData3(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.SetCourse +
                           "2" + Environment.NewLine +  //  Course
                           "1" + Environment.NewLine +  //  Warp factor
                           Command.CallOnLibraryComputer +
                           Command.CallOnLibraryComputer.TorpedoData +
                           Command.Exit +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LibraryTorpedoData3.txt");
        }
    }
}
