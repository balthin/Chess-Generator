using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitCalculation
{
    public class BitPieces
    {
        private int[] Rotation = 
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

        public BitPieces(List<int> pieces)
        {
            foreach (int p in pieces)
            {
                int square = (p >> 5) & 63;
                int r90 = Rotation[square];
                ulong bit = 1;
                ulong bs = bit << square;
                ulong bitRotation = bit << r90;
                switch (p & 31)
                {
                    case 09:
                        {
                            WK |= bs;
                            WKRotationRight90 |= bitRotation;
                        } break;
                    case 10:
                        {
                            WQ |= bs;
                            WQRotationRight90 |= bitRotation;
                        } break;
                    case 11:
                        {
                            WR |= bs;
                            WRRotationRight90 |= bitRotation;
                        } break;
                    case 12:
                        {
                            WB |= bs;
                            WBRotationRight90 |= bitRotation;
                        } break;
                    case 13:
                        {
                            WN |= bs;
                            WNRotationRight90 |= bitRotation;
                        } break;
                    case 14:
                        {
                            WP |= bs;
                            WPRotationRight90 |= bitRotation;
                        } break;
                    case 17:
                        {
                            BK |= bs;
                            BKRotationRight90 |= bitRotation;
                        } break;
                    case 18:
                        {
                            BQ |= bs;
                            BQRotationRight90 |= bitRotation;
                        } break;
                    case 19:
                        {
                            BR |= bs;
                            BRRotationRight90 |= bitRotation;
                        } break;
                    case 20:
                        {
                            BB |= bs;
                            BBRotationRight90 |= bitRotation;
                        } break;
                    case 21:
                        {
                            BN |= bs;
                            BNRotationRight90 |= bitRotation;
                        } break;
                    case 22:
                        {
                            BP |= bs;
                            BPRotationRight90 |= bitRotation;
                        } break;
                }
            }
            WF = WK | WQ | WR | WB | WN | WP;
            BF = BK | BQ | BR | BB | BN | BP;
            TF = WF | BF;
            WFRotationRight90 = WKRotationRight90 | WQRotationRight90 | WRRotationRight90 | WBRotationRight90 | WNRotationRight90 | WPRotationRight90;
            BFRotationRight90 = BKRotationRight90 | BQRotationRight90 | BRRotationRight90 | BBRotationRight90 | BNRotationRight90 | BPRotationRight90;
            TFRotationRight90 = WFRotationRight90 | BFRotationRight90;
        }
    }
    public class BitToList
    {
        public readonly List<int> Squares;
        public BitToList(ulong bitboard)
        {
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
