using System;

namespace BaconBytes.StarTrekNet
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //
            //  Parse the command-line arguments for the random number seed.
            //
            Random random;
            if (1 == args.Length)
            {
                int seed;
                if (int.TryParse(args[0], out seed))
                {
                    random = new Random(seed);
                }
                else
                {
                    random = new Random();
                }
            }
            else
            {
                random = new Random();
            }

            var game = new StarTrekGame(random);
            game.Run();
        }
    }
}
