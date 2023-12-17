using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitCalculation
{
    public class BitPieces
    {
        private int[] Rotation90 = 
        {
            07, 15, 23, 31, 39, 47, 55, 63,
            06, 14, 22, 30, 38, 46, 54, 62, 
            05, 13, 21, 29, 37, 45, 53, 61,
            04, 12, 20, 28, 36, 44, 52, 60,
            03, 11, 19, 27, 35, 43, 51, 59,
            02, 10, 18, 26, 34, 42, 50, 58,
            01, 09, 17, 25, 33, 41, 49, 57,
            00, 08, 16, 24, 32, 40, 48, 56
        };
        private int[] RotationRight45 = 
        {
            00, 02, 05, 09, 14, 20, 27, 35,
            01, 04, 08, 13, 19, 26, 34, 42,
            03, 07, 12, 18, 25, 33, 41, 48,
            06, 11, 17, 24, 32, 40, 47, 53,
            10, 16, 23, 31, 39, 46, 52, 57,
            15, 22, 30, 38, 45, 51, 56, 60,
            21, 29, 37, 44, 50, 55, 59, 62,
            28, 36, 43, 49, 54, 58, 61, 63
        };
        public ulong WK { private set; get; }
        public ulong WQ { private set; get; }
        public ulong WR { private set; get; }
        public ulong WB { private set; get; }
        public ulong WN { private set; get; }
        public ulong WP { private set; get; }
        public ulong BK { private set; get; }
        public ulong BQ { private set; get; }
        public ulong BR { private set; get; }
        public ulong BB { private set; get; }
        public ulong BN { private set; get; }
        public ulong BP { private set; get; }
        public ulong BF { private set; get; }
        public ulong WF { private set; get; }
        public ulong TF { private set; get; }

        public ulong WKRotationRight90 { get; private set; }
        public ulong WQRotationRight90 { get; private set; }
        public ulong WRRotationRight90 { get; private set; }
        public ulong WBRotationRight90 { get; private set; }
        public ulong WNRotationRight90 { get; private set; }
        public ulong WPRotationRight90 { get; private set; }
        public ulong BKRotationRight90 { get; private set; }
        public ulong BQRotationRight90 { get; private set; }
        public ulong BRRotationRight90 { get; private set; }
        public ulong BBRotationRight90 { get; private set; }
        public ulong BNRotationRight90 { get; private set; }
        public ulong BPRotationRight90 { get; private set; }
        public ulong BFRotationRight90 { get; private set; }
        public ulong WFRotationRight90 { get; private set; }
        public ulong TFRotationRight90 { get; private set; }

        public ulong WKRotationRight45 { get; private set; }
        public ulong WQRotationRight45 { get; private set; }
        public ulong WRRotationRight45 { get; private set; }
        public ulong WBRotationRight45 { get; private set; }
        public ulong WNRotationRight45 { get; private set; }
        public ulong WPRotationRight45 { get; private set; }
        public ulong BKRotationRight45 { get; private set; }
        public ulong BQRotationRight45 { get; private set; }
        public ulong BRRotationRight45 { get; private set; }
        public ulong BBRotationRight45 { get; private set; }
        public ulong BNRotationRight45 { get; private set; }
        public ulong BPRotationRight45 { get; private set; }
        public ulong BFRotationRight45 { get; private set; }
        public ulong WFRotationRight45 { get; private set; }
        public ulong TFRotationRight45 { get; private set; }

        public BitPieces(List<int> pieces)
        {
            foreach (int p in pieces)
            {
                int square = (p >> 5) & 63;
                int r90 = Rotation90[square];
                int r45 = RotationRight45[square];
                ulong bitNormal = 1ul << square;
                ulong bitRotationRight90 = 1ul << r90;
                ulong bitRotationRight45 = 1ul << r45;
                switch (p & 31)
                {
                    case 09:
                        {
                            WK |= bitNormal;
                            WKRotationRight90 |= bitRotationRight90;
                            WKRotationRight45 |= bitRotationRight45;
                        } break;
                    case 10:
                        {
                            WQ |= bitNormal;
                            WQRotationRight90 |= bitRotationRight90;
                            WQRotationRight45 |= bitRotationRight45;
                        } break;
                    case 11:
                        {
                            WR |= bitNormal;
                            WRRotationRight90 |= bitRotationRight90;
                            WRRotationRight45 |= bitRotationRight45;
                        } break;
                    case 12:
                        {
                            WB |= bitNormal;
                            WBRotationRight90 |= bitRotationRight90;
                            WBRotationRight45 |= bitRotationRight45;
                        } break;
                    case 13:
                        {
                            WN |= bitNormal;
                            WNRotationRight90 |= bitRotationRight90;
                            WNRotationRight45 |= bitRotationRight45;
                        } break;
                    case 14:
                        {
                            WP |= bitNormal;
                            WPRotationRight90 |= bitRotationRight90;
                            WPRotationRight45 |= bitRotationRight45;
                        } break;
                    case 17:
                        {
                            BK |= bitNormal;
                            BKRotationRight90 |= bitRotationRight90;
                            BKRotationRight45 |= bitRotationRight45;
                        } break;
                    case 18:
                        {
                            BQ |= bitNormal;
                            BQRotationRight90 |= bitRotationRight90;
                            BQRotationRight45 |= bitRotationRight45;
                        } break;
                    case 19:
                        {
                            BR |= bitNormal;
                            BRRotationRight90 |= bitRotationRight90;
                            BRRotationRight45 |= bitRotationRight45;
                        } break;
                    case 20:
                        {
                            BB |= bitNormal;
                            BBRotationRight90 |= bitRotationRight90;
                            BBRotationRight45 |= bitRotationRight45;
                        } break;
                    case 21:
                        {
                            BN |= bitNormal;
                            BNRotationRight90 |= bitRotationRight90;
                            BNRotationRight45 |= bitRotationRight45;
                        } break;
                    case 22:
                        {
                            BP |= bitNormal;
                            BPRotationRight90 |= bitRotationRight90;
                            BPRotationRight45 |= bitRotationRight45;
                        } break;
                }
            }
            WF = WK | WQ | WR | WB | WN | WP;
            BF = BK | BQ | BR | BB | BN | BP;
            TF = WF | BF;
            
            WFRotationRight90 = WKRotationRight90 | WQRotationRight90 | WRRotationRight90 | WBRotationRight90 | WNRotationRight90 | WPRotationRight90;
            BFRotationRight90 = BKRotationRight90 | BQRotationRight90 | BRRotationRight90 | BBRotationRight90 | BNRotationRight90 | BPRotationRight90;
            TFRotationRight90 = WFRotationRight90 | BFRotationRight90;

            WFRotationRight45 = WKRotationRight45 | WQRotationRight45 | WRRotationRight45 | WBRotationRight45 | WNRotationRight45 | WPRotationRight45;
            BFRotationRight45 = BKRotationRight45 | BQRotationRight45 | BRRotationRight45 | BBRotationRight45 | BNRotationRight45 | BPRotationRight45;
            TFRotationRight45 = WFRotationRight45 | BFRotationRight45;
        }
    }
    public class BitToList
    {
        public readonly List<int> Squares;
        public BitToList(ulong bitboard)
        {
            Squares = new List<int>();
            BitPlace bitPlace = new BitPlace(bitboard);
            for (int i = 0; i < 64; i++)
            {
                if (bitPlace.Has(i))
                    Squares.Add(i);
            }
        }
    }
    public class BitAdded
    {
        public readonly ulong Bitboard;
        public BitAdded(ulong bitboard, int square)
        {
            Bitboard = bitboard | (1ul << square);
        }

    }
    public class BitMinus
    {
        public readonly ulong Bitboard;
        public BitMinus(ulong bitboard, int square)
        {
            Bitboard = bitboard | (~(1ul << square));
        }
    }
    public class BitPlace
    {
        private ulong bitboard;
        public BitPlace(ulong bitboard)
        {
            this.bitboard = bitboard;
        }
        public bool Has(int square)
        {
            if ((this.bitboard & (1ul << square)) != 0)
                return true;
            return false;
        }
    }
    public class BitCount
    {
        private ulong bitboard;
        public BitCount(ulong bbPiece)
        {
            bitboard = bbPiece;
        }
        public ulong Sum
        {
            get
            {
                bitboard -= (bitboard >> 1) & 0x5555555555555555ul;
                bitboard = ((bitboard >> 2) & 0x3333333333333333ul) + (bitboard & 0x3333333333333333ul);
                return ((((bitboard >> 4) + bitboard) & 0x0F0F0F0F0F0F0F0Ful) * 0x0101010101010101) >> 56;
            }
        }
    }
    public class BitRight
    {
        public readonly int Index;
        public BitRight(ulong bitboard)
        {
            ulong a = bitboard & ~(bitboard - 1);
            Index = (int)Math.Log(a, 2);
        }
    }
    
}
