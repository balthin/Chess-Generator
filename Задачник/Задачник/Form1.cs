using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChessImages;
using ChessSystem.Painting;
using ChessSystem.Structure;

namespace Задачник
{
    public partial class Form1 : Form
    {
        class w
        {
            public static int k = 9, q = 10, r = 11, b = 12, n = 13, p = 14;
        }
        class b
        {
            public static int k = 17, q = 18, r = 19, l = 20, n = 21, p = 22;
        }
        class A
        {
            public static int _1 = 7 << 5, _2 = 15 << 5, _3 = 23 << 5, _4 = 31 << 5, _5 = 39 << 5, _6 = 47 << 5, _7 = 55 << 5, _8 = 63 << 5;
        }
        class B
        {
            public static int _1 = 6 << 5, _2 = 14 << 5, _3 = 22 << 5, _4 = 30 << 5, _5 = 38 << 5, _6 = 46 << 5, _7 = 54 << 5, _8 = 62 << 5;
        }
        class C
        {
            public static int _1 = 5 << 5, _2 = 13 << 5, _3 = 21 << 5, _4 = 29 << 5, _5 = 37 << 5, _6 = 45 << 5, _7 = 53 << 5, _8 = 61 << 5;
        }
        class D
        {
            public static int _1 = 4 << 5, _2 = 12 << 5, _3 = 20 << 5, _4 = 28 << 5, _5 = 36 << 5, _6 = 44 << 5, _7 = 52 << 5, _8 = 60 << 5;
        }
        class E
        {
            public static int _1 = 3 << 5, _2 = 11 << 5, _3 = 19 << 5, _4 = 27 << 5, _5 = 35 << 5, _6 = 43 << 5, _7 = 51 << 5, _8 = 59 << 5;
        }
        class F
        {
            public static int _1 = 2 << 5, _2 = 10 << 5, _3 = 18 << 5, _4 = 26 << 5, _5 = 34 << 5, _6 = 42 << 5, _7 = 50 << 5, _8 = 58 << 5;
        }
        class G
        {
            public static int _1 = 1 << 5, _2 = 09 << 5, _3 = 17 << 5, _4 = 25 << 5, _5 = 33 << 5, _6 = 41 << 5, _7 = 49 << 5, _8 = 57 << 5;
        }
        class H
        {
            public static int _1 = 0 << 5, _2 = 08 << 5, _3 = 16 << 5, _4 = 24 << 5, _5 = 32 << 5, _6 = 40 << 5, _7 = 48 << 5, _8 = 56 << 5;
        }
        int[] task1 = 
        {
            w.k + G._1, w.r + E._1, w.r + D._1, w.p + G._2, w.p + F._2, w.p + B._2, 
            w.p + G._3, w.n + F._3, w.p + A._3, w.q + G._4, w.b + D._5, 
            b.p + H._6, b.q + F._6, b.n + C._6, b.p + B._6, 
            b.p + G._7, b.p + F._7, b.r + D._7, b.l + B._7, b.p + A._7, b.k + G._8, b.r + D._8
        };
        int[] task2 = 
        {
            w.k + G._1, w.r + F._1, w.r + A._1, w.p + H._2, w.p + G._2, w.q + E._2, w.p + B._2, w.b + G._3, w.n + C._3,
            w.p + E._4, w.p + D._4, w.b + C._4, b.n + B._4, w.p + A._4, b.p + F._5, w.n + E._5, b.q + A._5, b.p + H._6,
            b.n + F._6, b.p + C._6, b.p + A._6, b.p + G._7, b.p + F._7, b.l + E._7, b.p + B._7, b.k + G._8, b.r + F._8, b.r + D._8, b.l + C._8
        };
        string[] comment = 
        {
            "Силовые ходы: 1.Ф:d7 (жертва) 1...Л:d7 2.Лe8+ (шах) 2...Крh7 3.Ce4+ (шах) 3...g6 4.Л:d7 (нападение) 4...Са6 5.С:с6 (взятие) и нельзя 5...Ф:с6 из-за 6.Л:f7#.",
            "Силовые ходы: 1.С:f7+ (шах + жертва) 1...Л:f7 2.Kc4 (нападение)."
        };
        AlphaPieces alpha;
        PiecePosition pieces;
        PiecePaint paint;
        LayerPaint layer;
        public Form1()
        {
            InitializeComponent();
            alpha = new AlphaPieces();
            Board.BackgroundImage = alpha.Board();
            pieces = new PiecePosition();
            paint = new PiecePaint(alpha);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (treeView.SelectedNode.Name)
            {
                case "Nd1": {
                    layer = new LayerPaint(paint.DrawPosition(task1.ToList()));
                    Comment.Text = comment[0];
                } break;
                case "Nd2": {
                    layer = new LayerPaint(paint.DrawPosition(task2.ToList()));
                    Comment.Text = comment[1];
                } break;
            }
            Area.Image = layer.Image();
        }
    }
}
