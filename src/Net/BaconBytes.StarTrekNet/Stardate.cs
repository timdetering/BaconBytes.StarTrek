namespace BaconBytes.StarTrekNet
{
    internal struct Stardate
    {
        internal Stardate(int value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        private readonly int _value;
    }
}
