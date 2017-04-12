using System;
using System.Diagnostics;
using BaconBytes.IO;

namespace StarTrek.Test.PlayRecorder
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //
            //  TODO: Parse the app arguments.
            //
            string outputFilePath = null;
            string inputFilePath = null;
            if (null != args)
            {
                if (0 < args.Length)
                {
                    outputFilePath = args[0];
                }
                if (1 < args.Length)
                {
                    inputFilePath = args[1];
                }
            }

            ConsoleListener listener = null;
            try
            {
                if (null != inputFilePath)
                {
                    listener = new ConsoleListener(outputFilePath, inputFilePath);
                }
                else if (null != outputFilePath)
                {
                    listener = new ConsoleListener(outputFilePath);
                }
                else
                {
                    listener = new ConsoleListener();
                }

                StarTrekClassic.Program.Main(new string[]{ "1" });
                //Debug.WriteLine(listener.ToString());
                Debug.WriteLine(listener.InputRecord);

            }
            finally
            {
                if (null != listener)
                {
                    listener.Dispose();
                }
            }
        }
    }
}
