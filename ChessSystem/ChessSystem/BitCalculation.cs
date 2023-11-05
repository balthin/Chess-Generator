using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitCalculation
{
    public class BitPieces
    {
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

        public BitPieces(List<int> pieces)
        {
            foreach (int p in pieces)
            {
                int s = (p >> 5) & 63;
                ulong b = 1;
                ulong bs = b << s;
                switch (p & 31)
                {
                    case 09: WK |= bs; break;
                    case 10: WQ |= bs; break;
                    case 11: WR |= bs; break;
                    case 12: WB |= bs; break;
                    case 13: WN |= bs; break;
                    case 14: WP |= bs; break;
                    case 17: BK |= bs; break;
                    case 18: BQ |= bs; break;
                    case 19: BR |= bs; break;
                    case 20: BB |= bs; break;
                    case 21: BN |= bs; break;
                    case 22: BP |= bs; break;
                }
            }
            WF = WK | WQ | WR | WB | WN | WP;
            BF = BK | BQ | BR | BB | BN | BP;
            TF = WF | BF;
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
