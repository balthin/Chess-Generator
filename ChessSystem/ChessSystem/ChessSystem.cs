using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using ChessImages;

namespace ChessSystem
{
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
