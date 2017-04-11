﻿using System;
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

        public static void LibraryComputer1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.CallOnLibraryComputer +
                           "3" + Environment.NewLine +  // Invalid command
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LibraryComputer1.txt");
        }

        public static void LibraryGalaticRecord1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.CallOnLibraryComputer +
                           Command.CallOnLibraryComputer.CumulativeGalaticRecord +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LibraryGalaticRecord1.txt");
        }

        public static void LibraryStatusReport1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.CallOnLibraryComputer +
                           Command.CallOnLibraryComputer.StatusReport +
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LibraryStatusReport1.txt");
        }

        public static void LibraryTorpedoData1(Action<string[]> entryPoint)
        {
            string input = InstrunctionsCommand.PrintAll + PlaybackTest.Seed +
                           Command.CallOnLibraryComputer +
                           Command.CallOnLibraryComputer.TorpedoData +
                           "0" + Environment.NewLine +  // Invalid command
                           Command.Exit;

            PlaybackTest.TestCase(entryPoint, input, "LibraryTorpedoData1.txt");
        }

        public static void LibraryTorpedoData2(Action<string[]> entryPoint)
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