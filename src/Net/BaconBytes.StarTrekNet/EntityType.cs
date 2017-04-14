using System.ComponentModel;

namespace BaconBytes.StarTrekNet
{
    public enum EntityType
    {
        Empty,
        Enterprise,
        Klingon,
        Starbase,
        Star
    }

    public static class EntityTypeExtensions
    {
        public static string ToDisplayString(this EntityType value)
        {
            string str;
            switch (value)
            {
                case EntityType.Empty:
                    str = "   ";
                    break;

                case EntityType.Enterprise:
                    str = "<*>";
                    break;

                case EntityType.Klingon:
                    str = "+++";
                    break;

                case EntityType.Starbase:
                    str = ">!<";
                    break;

                case EntityType.Star:
                    str = " * ";
                    break;

                default:
                    throw new InvalidEnumArgumentException();
            }
            return str;
        }
    }
}
