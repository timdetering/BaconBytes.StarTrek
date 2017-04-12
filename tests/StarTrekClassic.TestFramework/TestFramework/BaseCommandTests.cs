using System;
using System.IO;
using NUnit.Framework;

namespace StarTrekClassic.TestFramework
{
    public class BaseCommandTests
    {
        public static void Instructions1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "Instructions1.txt");
        }

        public static void DamageControlReport1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.DamageControlReport +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "DamageControlReport1.txt");
        }

        public static void FirePhasers1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.FirePhasers +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "FirePhasers1.txt");
        }

        public static void LongRangeSensorScan1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.LongRangeSensorScan +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LongRangeSensorScan1.txt");
        }

        public static void ShieldControl1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.ShieldControl +
                           "3001" + Environment.NewLine + //  Invalid units
                           "3000" + Environment.NewLine + //  Valid unit
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "ShieldControl1.txt");
        }

        public static void ShortRangeSensorScan1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.ShortRangeSensorScan +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "ShortRangeSensorScan1.txt");
        }
    }
}