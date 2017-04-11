using System;
using System.Diagnostics;
using System.IO;
using NUnit.Framework;

namespace StarTrekClassic.TestFramework
{
    public static class PlaybackTest
    {
        public static void TestCase(Action<string[]> entryPoint, string input, string expectedOutputFileName)
        {
            Debug.Assert(null != entryPoint);

            string expectedFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "ExpectedOutput");
            expectedFilePath = Path.Combine(expectedFilePath, expectedOutputFileName);

            string expectedOutput = File.ReadAllText(expectedFilePath);

            using (var test = new PlaybackRunner(input, false))
            {
                entryPoint(ProgramArgs);
                Assert.That(test.ToString(), Is.EqualTo(expectedOutput));
            }
        }

        public static readonly string[] ProgramArgs = new[] { "1" };
        public static readonly string Seed = "1" + Environment.NewLine;
    }
}
