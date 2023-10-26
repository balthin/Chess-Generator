using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using ChessImages;

namespace ChessSystem
{
    namespace Bitboard
    {
        public class PseudoLegal
        {
            private ulong[] PseudoLegalKnight =
            {
                0x0000000000020400, 0x0000000000050800, 0x00000000000A1100, 0x0000000000142200, 0x0000000000284400, 0x0000000000508800, 0x0000000000A01000, 0x0000000000402000,
                0x0000000002040004, 0x0000000005080008, 0x000000000A110011, 0x0000000014220022, 0x0000000028440044, 0x0000000050880088, 0x00000000A0100010, 0x0000000040200020,
                0x0000000204000402, 0x0000000508000805, 0x0000000A1100110A, 0x0000001422002214, 0x0000002844004428, 0x0000005088008850, 0x000000A0100010A0, 0x0000004020002040,
                0x0000020400040200, 0x0000050800080500, 0x00000A1100110A00, 0x0000142200221400, 0x0000284400442800, 0x0000508800885000, 0x0000A0100010A000, 0x0000402000204000,
                0x0002040004020000, 0x0005080008050000, 0x000A1100110A0000, 0x0014220022140000, 0x0028440044280000, 0x0050880088500000, 0x00A0100010A00000, 0x0040200020400000,
                0x0204000402000000, 0x0508000805000000, 0x0A1100110A000000, 0x1422002214000000, 0x2844004428000000, 0x5088008850000000, 0xA0100010A0000000, 0x4020002040000000,
                0x0400040200000000, 0x0800080500000000, 0x1100110A00000000, 0x2200221400000000, 0x4400442800000000, 0x8800885000000000, 0x100010A000000000, 0x2000204000000000,
                0x0004020000000000, 0x0008050000000000, 0x00110A0000000000, 0x0022140000000000, 0x0044280000000000, 0x0088500000000000, 0x0010A00000000000, 0x0020400000000000
            };
            private ulong[] PseudoLegalKing =
            {
                0x0000000000000302, 0x0000000000000705, 0x0000000000000E0A, 0x0000000000001C14, 0x0000000000003828, 0x0000000000007050, 0x000000000000E0A0, 0x000000000000C040,
                0x0000000000030203, 0x0000000000070507, 0x00000000000E0A0E, 0x00000000001C141C, 0x0000000000382838, 0x0000000000705070, 0x0000000000E0A0E0, 0x0000000000C040C0,
                0x0000000003020300, 0x0000000007050700, 0x000000000E0A0E00, 0x000000001C141C00, 0x0000000038283800, 0x0000000070507000, 0x00000000E0A0E000, 0x00000000C040C000,
                0x0000000302030000, 0x0000000705070000, 0x0000000E0A0E0000, 0x0000001C141C0000, 0x0000003828380000, 0x0000007050700000, 0x000000E0A0E00000, 0x000000C040C00000,
                0x0000030203000000, 0x0000070507000000, 0x00000E0A0E000000, 0x00001C141C000000, 0x0000382838000000, 0x0000705070000000, 0x0000E0A0E0000000, 0x0000C040C0000000,
                0x0003020300000000, 0x0007050700000000, 0x000E0A0E00000000, 0x001C141C00000000, 0x0038283800000000, 0x0070507000000000, 0x00E0A0E000000000, 0x00C040C000000000,
                0x0302030000000000, 0x0705070000000000, 0x0E0A0E0000000000, 0x1C141C0000000000, 0x3828380000000000, 0x7050700000000000, 0xE0A0E00000000000, 0xC040C00000000000,
                0x0203000000000000, 0x0507000000000000, 0x0A0E000000000000, 0x141C000000000000, 0x2838000000000000, 0x5070000000000000, 0xA0E0000000000000, 0x40C0000000000000
            };
            public PseudoLegal() { }//Bugaenko?!
            public ulong OfKnight(int square)
            {
                return PseudoLegalKnight[square];
            }
            public ulong OfKing(int square)
            {
                return PseudoLegalKing[square];
            }

        }
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
        public class BitPlus
        {
            public readonly ulong Bitboard;
            public BitPlus(ulong bitboard, int square)
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
        public class BitCalculation
        {
            private ulong bitboard;
            public BitCalculation(ulong bbPiece)
            {
                bitboard = bbPiece;
            }
            public ulong BitCount
            {
                get
                {
                    bitboard -= (bitboard >> 1) & 0x5555555555555555ul;
                    bitboard = ((bitboard >> 2) & 0x3333333333333333ul) + (bitboard & 0x3333333333333333ul);
                    return ((((bitboard >> 4) + bitboard) & 0x0F0F0F0F0F0F0F0Ful) * 0x0101010101010101) >> 56;
                }
            }
        }
        public class RightBit
        {
            public readonly int Index;
            public RightBit(ulong bitboard)
            {
                ulong a = bitboard & ~(bitboard - 1);
                Index = (int)Math.Log(a, 2);
            }
        }
    }
    namespace Structure
    {
        
        public class PiecePosition
        {
            int[] initial = 
            {
                0011, 0045, 0076, 0105, 0138, 0172, 0205, 0235,
                0270, 0302, 0334, 0366, 0398, 0430, 0462, 0494,
                1558, 1590, 1622, 1654, 1686, 1718, 1750, 1782,
                1811, 1845, 1876, 1905, 1938, 1972, 2005, 2035
            };

            public List<int> Items { private set; get; }

            public PiecePosition()
            {
                Items = new List<int>();
            }
            public void Remove(int square)
            {
                if (Items.Any(p => ((p >> 5) & 63) == square))
                    Items.RemoveAll(p => ((p >> 5) & 63) == square);
            }
            public void Add(int figure)
            {
                Remove((figure >> 5) & 63);
                Items.Add(figure);
            }
            public void Add(List<int> position)
            {
                Items = new List<int>();
                foreach (int pos in position)
                    Items.Add(pos);
            }
            public void Initialize()
            {
                Items = new List<int>();
                foreach (int pos in initial)
                    Items.Add(pos);
            }
            public void Clear()
            {
                Items = new List<int>();
            }
        }
        public class FieldPosition
        {
            public List<int> Items { private set; get; }
            public FieldPosition()
            {
                Items = new List<int>();
            }
            public void Remove(int square)
            {
                if (Items.Any(f => ((f >> 2) & 63) == square))
                    Items.RemoveAll(f => ((f >> 2) & 63) == square);
            }
            public void Add(int item)
            {
                Remove((item >> 2) & 63);
                Items.Add(item);
            }
            public void Add(List<int> position)
            {
                foreach (int pos in position)
                {
                    Remove((pos >> 2) & 63);
                    Items.Add(pos);
                }
            }
            public void Clear()
            {
                Items = new List<int>();
            }
        }
    }
    namespace Painting
    {
        public class PiecePaint
        {
            private Point[] area;
            private IPieceStyle style;
            public PiecePaint(IPieceStyle style)
            {
                this.style = style;
                area = new Point[64];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        area[63 - ((i << 3) + j)] = new Point(j * this.style.SquareSize(), i * this.style.SquareSize());
                    }
                }
            }
            public Bitmap DrawPosition(List<int> position)
            {
                Bitmap b = new Bitmap(8 * this.style.SquareSize(), 8 * this.style.SquareSize());
                b.MakeTransparent();
                using (Graphics g = Graphics.FromImage(b))
                {
                    foreach (var pos in position)
                    {
                        Bitmap piece = this.style.Image(pos);
                        Point square = area[(pos >> 5) & 63];
                        g.DrawImage(piece, square);
                    }
                }
                return b;
            }
        }
        public class FieldPaint
        {
            private Point[] area;
            private IFieldStyle style;
            public FieldPaint(IFieldStyle style)
            {
                this.style = style;
                area = new Point[64];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        area[63 - ((i << 3) + j)] = new Point(j * this.style.Size(), i * this.style.Size());
                    }
                }
            }
            public Bitmap DrawFields(List<int> items)
            {
                Bitmap b = new Bitmap(8 * this.style.Size(), 8 * this.style.Size());
                b.MakeTransparent();
                using (Graphics g = Graphics.FromImage(b))
                {
                    foreach (var f in items)
                    {
                        Bitmap field = this.style.Image(f);
                        Point square = area[(f >> 2) & 63];
                        g.DrawImage(field, square);
                    }
                }
                return b;
            }
        }
        public class LayerPaint 
        {
            private Bitmap b;
            public LayerPaint(Bitmap fieldLayer, Bitmap pieceLayer)
            {
                this.b = new Bitmap(fieldLayer.Width, fieldLayer.Height);
                b.MakeTransparent();
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.DrawImage(fieldLayer, new Point());
                    g.DrawImage(pieceLayer, new Point());
                }
            }
            public Bitmap Image()
            {
                return b;
            }
        }
        //public class ChessMenu
        //{
        //    private PaintMenu paintMenu;
        //    public Bitmap Figures { private set; get; }
        //    public int Piece { private set; get; }
        //    public ChessMenu()
        //    {
        //        paintMenu = new PaintMenu();
        //        Figures = paintMenu.panel;
        //    }
        //    public void Select(Point mouse)
        //    {
        //        paintMenu = new PaintMenu();
        //        Figures = new Bitmap(paintMenu.panel);
        //        using (Graphics g = Graphics.FromImage(Figures))
        //        {
        //            Point click = new Point(mouse.X / 40, mouse.Y / 40);
        //            Bitmap selected = paintMenu.selected;
        //            g.DrawImage(selected, click.X * 40, click.Y * 40);
        //            Piece = (8 << click.X) + (click.Y + 1);
        //        }
        //    }
        //}
    }
}
