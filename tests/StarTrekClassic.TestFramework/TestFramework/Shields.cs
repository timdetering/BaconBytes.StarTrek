using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace StarTrekClassic.TestFramework
{
    public class Shields
    {
        public static void Shields1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.Shields +
                           "3001" + Environment.NewLine + //  Invalid units
                           "3000" + Environment.NewLine + //  Valid unit
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "Shields1.txt");
        }

        public static void Shields2(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.Shields +
                           "100" + Environment.NewLine + //  Energy units
                           Command.SetCourse +
                           "2" + Environment.NewLine +  //  Course
                           "1" + Environment.NewLine +  //  Warp factor
                           Command.FirePhasers +
                           "100" + Environment.NewLine +  //  Units of energy
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "Shields2.txt");
        }
    }
}
