namespace BaconBytes.StarTrekNet
{
    internal struct Coordinates
    {
        internal Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public string ToDisplayString()
        {
            return $" {this.X},{this.Y} ";
        }

        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }

        /// <summary>
        /// Gets the x-coordinate
        /// </summary>
        internal int X { get; }


        internal int Y { get; }

    }
}
