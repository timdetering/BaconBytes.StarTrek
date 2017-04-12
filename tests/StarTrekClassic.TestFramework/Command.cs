using System;

namespace StarTrekClassic
{
    public static class Command
    {
        /// <summary>
        /// WARP ENGINE CONTROL (0)
        /// </summary>
        public static readonly WarpEngineControl SetCourse = new WarpEngineControl();

        /// <summary>
        /// SHORT RANGE SENSOR SCAN
        /// </summary>
        public static readonly string ShortRangeSensorScan = "1" + Environment.NewLine;

        /// <summary>
        /// LONG RANGE SENSOR SCAN
        /// </summary>
        public static readonly string LongRangeSensorScan = "2" + Environment.NewLine;

        /// <summary>
        /// FIRE PHASERS
        /// </summary>
        public static readonly string FirePhasers = "3" + Environment.NewLine;

        /// <summary>
        /// Fire photon torpedo (4)
        /// </summary>
        public static readonly string FirePhotonTorpedo = "4" + Environment.NewLine;

        /// <summary>
        /// SHIELD CONTROL");
        /// </summary>
        public static readonly string ShieldControl = "5" + Environment.NewLine;

        /// <summary>
        /// DAMAGE CONTROL REPORT
        /// </summary>
        public static readonly string DamageControlReport = "6" + Environment.NewLine;

        /// <summary>
        /// CALL ON LIBRARY COMPUTER (7)
        /// </summary>
        public static readonly LibraryComputer CallOnLibraryComputer = new LibraryComputer();

        /// <summary>
        /// EXIT (9)
        /// </summary>
        public static readonly string Exit = "9" + Environment.NewLine;

        /// <summary>
        /// LIBRARY COMPUTER
        /// </summary>
        public class LibraryComputer
        {
            /// <summary>
            /// CUMULATIVE GALATIC RECORD
            /// </summary>
            public readonly string CumulativeGalaticRecord = "0" + Environment.NewLine;

            /// <summary>
            /// STATUS REPORT
            /// </summary>
            public readonly string StatusReport = "1" + Environment.NewLine;

            /// <summary>
            /// Photon torpedo data (2)
            /// </summary>
            public readonly PhotonTorpedoData TorpedoData = new PhotonTorpedoData();

            public override string ToString()
            {
                return "7" + Environment.NewLine;
            }

            public class PhotonTorpedoData
            {
                public readonly string UseCalculator = "1" + Environment.NewLine;

                public override string ToString()
                {
                    return "2" + Environment.NewLine;
                }
            }


        }

        /// <summary>
        /// WARP ENGINE CONTROL
        /// </summary>
        public class WarpEngineControl
        {
            public readonly string InvalidCourse = "0" + Environment.NewLine;

            public override string ToString()
            {
                return "0" + Environment.NewLine;
            }
        }
    }
}