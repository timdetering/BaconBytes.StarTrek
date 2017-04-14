using System;

namespace BaconBytes.StarTrekNet
{
    public enum AlertState
    {
        Green,
        Yellow,
        Red,
        Docked,
    }

    public static class AlertStateExtensions
    {
        public static string ToDisplayString(this AlertState state)
        {
            return state.ToString().ToUpper();
        }
    }
}
