namespace BaconBytes.StarTrekNet
{
    internal struct MapCoordinates
    {
        internal MapCoordinates(int quadrantX, int quadrantY, int sectorX, int sectorY)
        {
            this.Quadrant = new Coordinates(quadrantX, quadrantY);
            this.Sector = new Coordinates(sectorX, sectorY);
        }

        public override string ToString()
        {
            return $"Quadrant {this.Quadrant} Sector {this.Sector}";
        }

        internal Coordinates Quadrant { get; }

        internal Coordinates Sector { get; }
    }
}
