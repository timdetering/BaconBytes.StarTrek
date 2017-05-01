using System;

namespace BaconBytes.StarTrekNet
{
    internal sealed class Enterprise
    {
        internal Enterprise()
        {
            this.Condition = AlertState.Green;
            this.Engery = 3000.0;
            this.Torpedoes = 10;
        }

        internal AlertState Condition { get; private set; }

        internal double Engery { get; private set; }

        internal MapCoordinates Position { get; set; }

        internal double Shields { get; set; }

        internal int Torpedoes { get; private set; }
    }
}
