using System;

namespace BaconBytes.StarTrekNet
{
    internal class StarTrekGame
    {
        public StarTrekGame(Random random)
        {
            _enterprise = new Enterprise();
            _random = random;
        }

        #region Methods
        private void Initialize()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine();
            }

            Console.WriteLine("                          STAR TREK ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("ENTER 1 OR 2 FOR INSTRUCTIONS (ENTER 2 TO PAGE) ");

            var instructionsCmd = ReadInteger();
            if (1 == instructionsCmd || 2 == instructionsCmd)
            {
                PrintInstructions(2 == instructionsCmd);
            }

            Console.WriteLine();
            Console.Write("ENTER SEED NUMBER ");
            var seedIter = ReadInteger();
            seedIter = Math.Abs(seedIter);
            Console.WriteLine("INITIALIZING...");
            for (int i = 0; i <= seedIter; i++)
            {
                _random.NextDouble();
            }

            Console.WriteLine();
            _enterprise = new Enterprise();
            var date = (int)(_random.NextDouble() * 20 + 20) * 100;
            _currentDate = new Stardate(date);
            //_291: _T[1] = date;
            //_300: _T[2] = 30;
            D = 0;
            K = _enterprise.Engery;
            M = _enterprise.Torpedoes;
            _S[4] = 200;
            Q = 0;
            _Q[1] = (int)(_random.NextDouble() * 8) + 1;
            _Q[2] = (int)(_random.NextDouble() * 8) + 1;
            _S[1] = (int)(_random.NextDouble() * 8) + 1;
            _S[2] = (int)(_random.NextDouble() * 8) + 1;

            var position = new MapCoordinates((int)_Q[1], (int)_Q[2], (int)_S[1], (int)_S[2]);
            _enterprise.Position = position;

            _410: // C array numbers in X,Y notation/display
            _420: // dir 1 = X+1,Y    right
            _421: _C[1, 1] = 1;
            _422: _C[1, 2] = 0;
            _423: // dir 2 = X+1,Y-1  right and up
            _424: _C[2, 1] = 1;
            _425: _C[2, 2] = -1;
            _426: // dir 3 = X, Y-1   up
            _427: _C[3, 1] = 0;
            _428: _C[3, 2] = -1;
            _429: // dir 4 = X-1,Y-1  left and up
            _430: _C[4, 1] = -1;
            _431: _C[4, 2] = -1;
            _432: // dir 5 = X-1,Y    left
            _433: _C[5, 1] = -1;
            _434: _C[5, 2] = 0;
            _435: // dir 6 = X-1,Y+1  left and down
            _436: _C[6, 1] = -1;
            _437: _C[6, 2] = 1;
            _438: // dir 7 = X,Y+1    down
            _439: _C[7, 1] = 0;
            _440: _C[7, 2] = 1;
            _441: // dir 8 = X+1,Y+1  right and down
            _442: _C[8, 1] = 1;
            _443: _C[8, 2] = 1;
            _444: // dir 9 = same as dir 1
            _445: _C[9, 1] = 1;
            _446: _C[9, 2] = 0;
            _450: Fill(_D, 0);

            _490: _B[2] = 0;
            _491: _P[3] = 0;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    _520: F = _random.NextDouble();
                    _530: if (F > .98) goto _580;
                    _540: if (F > .95) goto _610;
                    _550: if (F > .8) goto _640;
                    _560: _P[1] = 0;
                    _570: goto _660;
                    _580: _P[1] = 3;
                    _590: _P[3] = _P[3] + 3;
                    _600: goto _660;
                    _610: _P[1] = 2;
                    _620: _P[3] = _P[3] + 2;
                    _630: goto _660;
                    _640: _P[1] = 1;
                    _650: _P[3] = _P[3] + 1;
                    _660: F = _random.NextDouble();
                    _670: if (F > .96) goto _700;
                    _680: _B[1] = 0;
                    _690: goto _720;
                    _700: _B[1] = 1;
                    _710: _B[2] = _B[2] + 1;
                    _720: _S[3] = (int)(_random.NextDouble() * 8 + 1);
                    _730: _G[i, j] = _P[1] * 100 + _B[1] * 10 + _S[3];
                    _740: _Z[i, j] = 0;
                    _750:;
                }
            }
            _770: _P[2] = _P[3];
            _775: if (_B[2] <= 0 || _P[3] <= 0) goto _490;

            Console.Write("YOU MUST DESTROY {0} KINGONS IN {1} STARDATES WITH {2} STARBASE", _P[3], TIME_LIMIT, _B[2]);
            _791: if (_B[2] == 1) goto _793;
            _792: Console.Write("S");
            _793: Console.WriteLine();
            _800: Console.WriteLine();
            _810: _P[1] = 0;
            _811: _B[1] = 0;
            _812: _S[3] = 0;
            _820: _Q[1] = Math.Min(8, Math.Max(1, _Q[1]));
            _Q[2] = Math.Min(8, Math.Max(1, _Q[2]));
            _S[1] = Math.Min(8, Math.Max(1, _S[1]));
            _S[2] = Math.Min(8, Math.Max(1, _S[2]));
            _830: X = _G[(int)_Q[1], (int)_Q[2]] * 1.00000E-02;
            //X = _G[_enterprise.Position.Quadrant.X, _enterprise.Position.Quadrant.Y] * 1.00000E-02;

            _840: _P[1] = (int)X;
            _850: _B[1] = (int)((X - _P[1]) * 10);
            _860: _S[3] = _G[(int)_Q[1], (int)_Q[2]] - (int)(_G[(int)_Q[1], (int)_Q[2]] * .1) * 10;
            //_S[3] = _G[_enterprise.Position.Quadrant.X, _enterprise.Position.Quadrant.Y] 
            //    - (int)(_G[_enterprise.Position.Quadrant.X, _enterprise.Position.Quadrant.Y] * .1) * 10;
            _870: if (_P[1] == 0) goto _910;
            _880: if (_enterprise.Shields > 200) goto _910;
            _890: Console.WriteLine("COMBAT AREA      CONDITION RED");
            _900: Console.WriteLine("   SHIELDS DANGEROUSLY LOW");
            _910: Fill(_K, 0);
            for (int i = 1; i <= 3; i++)
            {
                _K[i, 3] = 0;
            }
            _942: // A[x,y]:
            _943: // 0="   "
            _944: // 1="<*>"
            _945: // 2="+++"
            _946: // 3=">!<"
            _947: // 4=" * "
            _950: Fill(_A, 0);
            _1000: _A[(int)(_S[1] + .5), (int)(_S[2] + .5)] = 1;
            _1020: for (I = 1; I <= (int)_P[1]; I += 1)
            {
                _1030: _5380();
                _1040: _A[(int)F, (int)G] = 2;
                _1080: _K[(int)I, 1] = F;
                _1090: _K[(int)I, 2] = G;
                _1100: _K[(int)I, 3] = _S[4];
                _1110:;
            }
            _1120: for (I = 1; I <= (int)_B[1]; I += 1)
            {
                _1130: _5380();
                _1140: _A[(int)F, (int)G] = 3;
                _1180:;
            }
            _1190: for (I = 1; I <= (int)_S[3]; I += 1)
            {
                _1200: _5380();
                _1210: _A[(int)F, (int)G] = 4;
                _1250:;
            }
            this.ShortRangeScan();
        }

        private static void PrintInstructions(bool page)
        {
            double temp;

            _5823: Console.WriteLine();
            _5824: Console.WriteLine();
            _5825: Console.WriteLine("     INSTRUCTIONS:");
            _5826: Console.WriteLine();
            _5830: Console.WriteLine("<*> = ENTERPRISE");
            _5840: Console.WriteLine("+++ = KLINGON");
            _5850: Console.WriteLine(">!< = STARBASE");
            _5860: Console.WriteLine(" *  = STAR");
            _5865: Console.WriteLine();
            _5870: Console.WriteLine("COMMAND 0 = WARP ENGINE CONTROL");
            _5880: Console.WriteLine("  'COURSE IS IN A CIRCULAR NUMERICAL         4    3    2");
            _5890: Console.WriteLine("  VECTOR ARRANGEMENT AS SHOWN.                `.  :  .'");
            _5900: Console.WriteLine("  INTERGER AND REAL VALUES MAY BE               `.:.'");
            _5910: Console.WriteLine("  USED.  THEREFORE COURSE 1.5 IS             5---<*>---1");
            _5920: Console.WriteLine("  HALF WAY BETWEEN 1 AND 2.                     .':`.");
            _5930: Console.WriteLine("                                              .'  :  `.");
            _5940: Console.WriteLine("  A VECTOR OF 9 IS UNDEFINED, BUT            6    7    8");
            _5950: Console.WriteLine("  VALUES MAY APPROACH 9.");
            _5960: Console.WriteLine("                                               COURSE");
            _5970: Console.WriteLine("  ONE 'WARP FACTOR' IS THE SIZE OF");
            _5980: Console.WriteLine("  ONE QUADRANT.  THEREFORE TO GET FROM");
            _5990: Console.WriteLine("  QUADRANT 5,6 TO 5,5 YOU WOULD USE COURSE 3, WARP");
            _6000: Console.WriteLine("  FACTOR 1. COORDINATES ARE SPECIFIED USING X,Y NOTATION");
            _6002: Console.WriteLine("  WITH X 1-8 FROM LEFT-RIGHT AND Y 1-8 FROM TOP-BOTTOM.");

            if (page)
            {
                Console.WriteLine();
                Console.Write("ENTER A NUMBER TO CONTINUE...  ");
                ReadInteger();
                Console.WriteLine();
            }

            _6009: Console.WriteLine();
            _6010: Console.WriteLine("COMMAND 1 = SHORT RANGE SENSOR SCAN");
            _6020: Console.WriteLine("  PRINTS THE QUADRANT YOU ARE CURRENTLY IN, INCLUDING");
            _6030: Console.WriteLine("  STARS, KLINGONS, STARBASES, AND THE ENTERPRISE; ALONG");
            _6040: Console.WriteLine("  WITH OTHER PERTINATE INFORMATION.");
            _6045: Console.WriteLine();
            _6050: Console.WriteLine("COMMAND 2 = LONG RANGE SENSOR SCAN");
            _6060: Console.WriteLine("  SHOWS CONDITIONS IN SPACE FOR ONE QUADRANT ON EACH SIDE");
            _6070: Console.WriteLine("  OF THE ENTERPRISE IN THE MIDDLE OF THE SCAN.  THE SCAN");
            _6080: Console.WriteLine("  IS CODED IN THE FORM XXX, WHERE THE UNITS DIGIT IS THE");
            _6090: Console.WriteLine("  NUMBER OF STARS, THE TENS DIGIT IS THE NUMBER OF STAR-");
            _6100: Console.WriteLine("  BASES, THE HUNDREDS DIGIT IS THE NUMBER OF KLINGONS.");
            _6105: Console.WriteLine();
            _6110: Console.WriteLine("COMMAND 3 = PHASER CONTROL");
            _6120: Console.WriteLine("  ALLOWS YOU TO DESTROY THE KLINGONS BY HITTING HIM WITH");
            _6130: Console.WriteLine("  SUITABLY LARGE NUMBERS OF ENERGY UNITS TO DEPLETE HIS ");
            _6140: Console.WriteLine("  SHIELD POWER.  KEEP IN MIND THAT WHEN YOU SHOOT AT");
            _6150: Console.WriteLine("  HIM, HE GONNA DO IT TO YOU TOO.");

            if (page)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine();
                }
                Console.Write("ENTER A NUMBER TO CONTINUE...  ");
                ReadInteger();
                Console.WriteLine();
            }

            _6159: Console.WriteLine();
            _6160: Console.WriteLine("COMMAND 4 = PHOTON TORPEDO CONTROL");
            _6170: Console.WriteLine("  COURSE IS THE SAME AS USED IN WARP ENGINE CONTROL");
            _6180: Console.WriteLine("  IF YOU HIT THE KLINGON, HE IS DESTROYED AND CANNOT FIRE");
            _6190: Console.WriteLine("  BACK AT YOU.  IF YOU MISS, HE WILL SHOOT HIS PHASERS AT");
            _6200: Console.WriteLine("  YOU.");
            _6210: Console.WriteLine("   NOTE: THE LIBRARY COMPUTER (COMMAND 7) HAS AN OPTION");
            _6220: Console.WriteLine("   TO COMPUTE TORPEDO TRAJECTORY FOR YOU (OPTION 2).");
            _6225: Console.WriteLine();
            _6230: Console.WriteLine("COMMAND 5 = SHIELD CONTROL");
            _6240: Console.WriteLine("  DEFINES NUMBER OF ENERGY UNITS TO ASSIGN TO SHIELDS");
            _6250: Console.WriteLine("  ENERGY IS TAKEN FROM TOTAL SHIP'S ENERGY.");
            _6255: Console.WriteLine();
            _6260: Console.WriteLine("COMMAND 6 = DAMAGE CONTROL REPORT");
            _6270: Console.Write("  GIVES STATE OF REPAIRS OF ALL DEVICES.");
            _6275: Console.WriteLine("  A STATE OF REPAIR");
            _6280: Console.WriteLine("  LESS THAN ZERO SHOWS THAT THAT DEVICE IS TEMPORARALY");
            _6290: Console.WriteLine("  DAMAGED.");

            if (page)
            {
                for (int i = 1; i <= 6; i++)
                {
                    Console.WriteLine();
                }
                Console.Write("ENTER A NUMBER TO CONTINUE...  ");
                ReadInteger();
                Console.WriteLine();
            }

            _6299: Console.WriteLine();
            _6300: Console.WriteLine("COMMAND 7 = LIBRARY COMPUTER");
            _6310: Console.WriteLine("  THE LIBRARY COMPUTER CONTAINS THREE OPTIONS:");
            _6320: Console.WriteLine("    OPTION 0 = CUMULATIVE GALACTIC RECORD");
            _6330: Console.WriteLine("     SHOWS COMPUTER MEMORY OF THE RESULTS OF ALL PREVIOUS");
            _6340: Console.WriteLine("     LONG RANGE SENSOR SCANS");
            _6350: Console.WriteLine("    OPTION 1 = STATUS REPORT");
            _6360: Console.WriteLine("     SHOWS NUMBER OF KLINGONS, STARDATES AND STARBASES");
            _6370: Console.WriteLine("     LEFT.");
            _6380: Console.WriteLine("    OPTION 2 = PHOTON TORPEDO DATA");
            _6390: Console.WriteLine("     GIVES TRAJECTORY AND DISTANCE BETWEEN THE ENTERPRISE");
            _6400: Console.WriteLine("     AND ALL KLINGONS IN YOUR QUADRANT");

            if (page)
            {
                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }

        private static Command ReadCommand()
        {
            var cmd = Command.ListCommands;
            int value;
            if (int.TryParse(Console.ReadLine(), out value))
            {
                cmd = (Command)value;
            }
            return cmd;
        }


        private static double ReadDouble()
        {
            double value;
            if (false == Double.TryParse(Console.ReadLine(), out value))
            {
                value = -1.0;
            }
            return value;
        }

        private static int ReadInteger()
        {
            int value;
            if (false == int.TryParse(Console.ReadLine(), out value))
            {
                value = -1;
            }
            return value;
        }

        public void Run()
        {
            this.Initialize();

            Command command;
            do
            {
                Console.Write("COMMAND ");
                command = ReadCommand();

                switch (command)
                {
                    case Command.ListCommands:
                        Console.WriteLine();
                        Console.WriteLine("   0 = SET COURSE");
                        Console.WriteLine("   1 = SHORT RANGE SENSOR SCAN");
                        Console.WriteLine("   2 = LONG RANGE SENSOR SCAN");
                        Console.WriteLine("   3 = FIRE PHASERS");
                        Console.WriteLine("   4 = FIRE PHOTON TORPEDOES");
                        Console.WriteLine("   5 = SHIELD CONTROL");
                        Console.WriteLine("   6 = DAMAGE CONTROL REPORT");
                        Console.WriteLine("   7 = CALL ON LIBRARY COMPUTER");
                        Console.WriteLine("   9 = EXIT");
                        Console.WriteLine();
                        break;

                    case Command.SetCourse:
                        this.SetCourse();
                        break;

                    case Command.ShortRangeScan:
                        ShortRangeScan();
                        break;

                    case Command.LongRangeScan:
                        LongRangeScan();
                        break;
                            ;
                }
            }
            while (Command.Exit != command);

        }
        #endregion

        public static void Fill(double[] array, double value)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                array[i] = value;
            }
        }

        public static void Fill(double[,] array, double value)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = value;
                }
            }
        }


        private static void Input(out double a)
        {
            try
            {
                a = Double.Parse(Console.ReadLine());
            }
            catch
            {
                a = -1;
            }
        }

        private void LongRangeScan()
        {
            if (0 <= _D[3])
            {
                Console.WriteLine("LONG RANGE SENSOR SCAN FOR QUADRANT{0}", _enterprise.Position.Quadrant.ToDisplayString());
                //Console.Write("LONG RANGE SENSOR SCAN FOR QUADRANT");
                //_2371: _V[4] = _Q[1];
                //_2372: _V[5] = _Q[2];
                //_2373: _9000();
                //_2374: Console.WriteLine();

                Console.WriteLine("-------------------");
                for (double j = _Q[2] - 1; j <= _Q[2] + 1; j++)
                {
                    _2400: Fill(_N, 0);
                    for (double i = _Q[1] - 1; i <= _Q[1] + 1; i++)
                    {
                        _2420: if (i < 1 || i > 8 || j < 1 || j > 8) goto _2460;
                        _2430: _N[(int)(i - _Q[1] + 2)] = _G[(int)i, (int)j];
                        _2440: if (_D[7] < 0) goto _2460;
                        _2450: _Z[(int)i, (int)j] = _G[(int)i, (int)j];
                        _2460:;
                    }
                    _2470: Console.WriteLine("| {0:D3} | {1:D3} | {2:D3} |", (int)_N[1], (int)_N[2], (int)_N[3]);
                    _2480: Console.WriteLine("-------------------");
                }
            }
            else
            {
                Console.WriteLine("LONG RANGE SENSORS ARE INOPERABLE");
            }
        }

        private void SetCourse()
        {
            double course;
            do
            {
                Console.Write("COURSE (1-9) ");
                course = ReadDouble();
                if (0 == (int)course)
                {
                    break;
                }

                Console.Write("WARP FACTOR (0-8) ");
                var warp = ReadDouble();

            }
            while (1.0 > course || 9.0 <= course);
        }

        private void ShortRangeScan()
        {
            _4120: for (I = _S[1] - 1; I <= _S[1] + 1; I += 1)
            {
                for (double j = _S[2] - 1; j <= _S[2] + 1; j++)
                {
                    _4140: if (I < 1 || I > 8 || j < 1 || j > 8) goto _4200;
                    _4160: if (_A[(int)(I + .5), (int)(j + .5)] == 3) goto _4240;
                    _4200:;
                }
            }
            _4220: D = 0;
            _4230: goto _4310;
            _4240: D = 1;
            _4249: // docked
            _4250: C = 3;
            //_4260: E = 3000;
            //_4270: P = 10;
            _4280: Console.WriteLine("SHIELDS DROPPED FOR DOCKING PURPOSES");
            //_4290: S = 0;
            _enterprise.Shields = 0;
            _4300: goto _4380;
            _4310: if (_P[1] > 0) goto _4350;
            _4320: if (_enterprise.Engery < K * .1) goto _4370;
            _4329: // green
            _4330: C = 0;
            _4340: goto _4380;
            _4349: // red
            _4350: C = 2;
            _4360: goto _4380;
            _4369: // yellow
            _4370: C = 1;
            _4380: if (_D[2] >= 0) goto _4430;
            _4390: Console.WriteLine();
            _4400: Console.WriteLine("*** SHORT RANGE SENSORS ARE OUT ***");
            _4410: Console.WriteLine();
            _4420: goto _4530;
            _4430: Console.WriteLine("-=--=--=--=--=--=--=--=-");
            _V[3] = 0;
            _9200();
            Console.WriteLine();
            _9200();
            Console.WriteLine(" STARDATE  {0}", _currentDate);
            _9200();
            Console.WriteLine(" CONDITION {0}", _enterprise.Condition.ToDisplayString());
            _9200();
            Console.WriteLine(" QUADRANT {0}", _enterprise.Position.Quadrant.ToDisplayString());
            _9200();
            Console.WriteLine(" SECTOR   {0}", _enterprise.Position.Sector.ToDisplayString());
            _9200();
            Console.WriteLine(" ENERGY    {0}", _enterprise.Engery);
            _9200();
            Console.WriteLine(" SHIELDS   {0}", _enterprise.Shields);
            _9200();
            Console.WriteLine(" PHOTON TORPEDOES {0}", _enterprise.Torpedoes);
            Console.WriteLine("-=--=--=--=--=--=--=--=-");
            _4530: return;
        }

        public void _5380()
        {
            _5378: // find-empty-location sub, strings removed
            _5380: F = (int)(_random.NextDouble() * 8 + 1);
            _5390: G = (int)(_random.NextDouble() * 8 + 1);
            _5400: if (_A[(int)F, (int)G] != 0) goto _5380;
        }

        public static void _9000()
        {
            _8995: // sub to help convert PRINT USING, displays " x,y "
            _8996: // coordinates (V[4],V[5])
            _9000: Console.Write(" ");
            _9010: L = (int)(_V[4] + .5);
            _9020: _9700();
            _9030: Console.Write(",");
            _9040: L = (int)(_V[5] + .5);
            _9050: _9700();
            _9060: Console.Write(" ");
            _9070: return;
        }

        public static void _9200()
        {
            _9195: // print display line from A[x,y]
            _9196: // y coord spec'd by V[3], incremented
            _9200: _V[3] = _V[3] + 1;
            for (int i = 1; i <= 8; i++)
            {
                _9220: A = _A[i, (int)_V[3]];
                _9230: if (A == 1) goto _9240;
                _9232: if (A == 2) goto _9242;
                _9233: if (A == 3) goto _9244;
                _9234: if (A == 4) goto _9246;
                _9235: Console.Write("   ");
                _9236: goto _9250;
                _9240: Console.Write("<*>");
                _9241: goto _9250;
                _9242: Console.Write("+++");
                _9243: goto _9250;
                _9244: Console.Write(">!<");
                _9245: goto _9250;
                _9246: Console.Write(" * ");
                _9250:;
            }
        }

        private static void _9400()
        {
        }

        public static void _9700()
        {
            _9695: // Digit print subroutine, digit in L
            _9700: if (L == 1) goto _9810;
            _9710: if (L == 2) goto _9830;
            _9720: if (L == 3) goto _9850;
            _9730: if (L == 4) goto _9870;
            _9740: if (L == 5) goto _9890;
            _9750: if (L == 6) goto _9910;
            _9760: if (L == 7) goto _9930;
            _9770: if (L == 8) goto _9950;
            _9780: if (L == 9) goto _9970;
            _9790: Console.Write("0");
            _9800: return;
            _9810: Console.Write("1");
            _9820: return;
            _9830: Console.Write("2");
            _9840: return;
            _9850: Console.Write("3");
            _9860: return;
            _9870: Console.Write("4");
            _9880: return;
            _9890: Console.Write("5");
            _9900: return;
            _9910: Console.Write("6");
            _9920: return;
            _9930: Console.Write("7");
            _9940: return;
            _9950: Console.Write("8");
            _9960: return;
            _9970: Console.Write("9");
            _9980: return;
        }

        private Enterprise _enterprise;
        private readonly Random _random;

        private Stardate _currentDate;

        // ReSharper disable once InconsistentNaming
        private const int TIME_LIMIT = 30;

        private static double A;
        private static double B;
        private static double C;
        private static double D;
        //private static double E;
        private static double F;
        private static double G;
        private static double I;
        //private static double J;
        private static double K;
        private static double L;
        private static double M;
        //private static double P;
        private static double Q;
        //private static double S;
        //private static double T;
        private static double X;
        //private static double Z;

        //private static double B, D, G, H, K, N, O, P, R, U, V, W, X, Y;
        private static double[,] _A = new double[9, 9];
        private static double[] _B = new double[3];
        private static double[,] _C = new double[10, 3];
        private static double[] _D = new double[10];
        private static double[,] _G = new double[9, 9];
        private static double[,] _K = new double[4, 4];
        private static double[] _N = new double[4];
        private static double[] _P = new double[4];
        private static double[] _Q = new double[3];
        private static double[] _S = new double[5];
        //private static double[] _T = new double[3];
        private static double[] _V = new double[7];
        //private static double[] _X = new double[3];
        private static double[,] _Z = new double[9, 9];
    }
}
