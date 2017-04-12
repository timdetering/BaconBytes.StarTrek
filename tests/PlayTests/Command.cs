using System;

namespace StarTrekClassic.Test.PlayTests
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
        /// FIRE PHOTON TORPEDOES
        /// </summary>
        public static readonly string FirePhotonTorpedoes = "4" + Environment.NewLine;

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
            /// PHOTON TORPEDO DATA (2)
            /// </summary>
            //public readonly string PhotonTorpedoData = "2" + Environment.NewLine;
            public readonly PhotonTorpedoData TorpedoData = new PhotonTorpedoData();


            ///// <summary>
            ///// Exit library command (3).
            ///// </summary>
            //public static readonly string Exit = "3" + Environment.NewLine;


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