using System;
using System.Drawing;
using System.Windows.Forms;
using ChessSystem;
using ChessImages;
using ChessSystem.Structure;
using ChessSystem.Painting;
using BitCalculation;
using Bitboard;

namespace ChessGenerator
{
    public partial class foMain : Form
    {
        AlphaBoardClick boardClick;
        AlphaPieces alphaStyle;
        PiecePosition pieces;
        PiecePaint piecesPicture;

        AlphaField alphaFields;
        FieldPosition fields;
        FieldPaint fieldsPicture;
        ArrowPosition arrows;
        ArrowPaint arwPicture;
        AlphaMenu menuPicture;

        BitPieces bPieces;
        BitToList hList;
        BitToList vList;
        PseudoHorzAttack horz;
        PseudoVertAttack vert;

        String[] Vert = { "1", "2", "3", "4", "5", "6", "7", "8" };
        String[] Horz = { "H", "G", "F", "E", "D", "C", "B", "A" };

        Int32[] Rotated90 = 
        {
            56, 48, 40, 32, 24, 16, 08, 00,
            57, 49, 41, 33, 25, 17, 09, 01,
            58, 50, 42, 34, 26, 18, 10, 02,
            59, 51, 43, 35, 27, 19, 11, 03,
            60, 52, 44, 36, 28, 20, 12, 04,
            61, 53, 45, 37, 29, 21, 13, 05,
            62, 54, 46, 38, 30, 22, 14, 06,
            63, 55, 47, 39, 31, 23, 15, 07
        };

        public foMain()
        {
            InitializeComponent();
            alphaStyle = new AlphaPieces();
            panelBoard.BackgroundImage = alphaStyle.Board();
            panelBoard.Size = new Size(alphaStyle.BoardSize(), alphaStyle.BoardSize());
            pictureBoard.Size = new Size(alphaStyle.BoardSize() - alphaStyle.BordSize(), alphaStyle.BoardSize() - alphaStyle.BordSize());
            pictureBoard.Location = new Point(alphaStyle.BordSize() / 2, alphaStyle.BordSize() / 2);
            pictureBoard.BackColor = Color.Transparent;
            Setting.Top = panelBoard.Top;
            Setting.Left = panelBoard.Left + panelBoard.Width + 25;

            pieces = new PiecePosition();
            piecesPicture = new PiecePaint(alphaStyle);

            alphaFields = new AlphaField();
            fields = new FieldPosition();
            fieldsPicture = new FieldPaint(alphaFields);

            arrows = new ArrowPosition();
            arwPicture = new ArrowPaint(alphaFields);

            arrows.Add(6971);
            LayerPaint alphaLayer = new LayerPaint(arwPicture.DrawArrows(arrows.Items));

            pictureBoard.Image = alphaLayer.Image();

            menuPicture = new AlphaMenu();
            pictureMenu.Image = menuPicture.MenuImage;
        }

        private void numericPosition_ValueChanged(object sender, EventArgs e)
        {
            pieces = new PiecePosition();
            
            int h = (int)trackHorz.Value;
            int v = (int)trackVert.Value;
            int s = h | (v << 3);
            
            int wrPos = 0;
            if (checkVert.Checked)
                wrPos = Rotated90[s];
            else
                wrPos = s;

            ulong num = (ulong)numericPosition.Value;
            ulong blockers = num << (v * 8);
            
            ulong b = 1;
            for (int i = 0; i < 64; i++, b = (1ul << i))
            {
                if ((blockers & b) != 0)
                {
                    if (checkVert.Checked)
                        pieces.Add((Rotated90[i] << 5) + 21);
                    else
                        pieces.Add((i << 5) + 21);
                }
            }
            
            ulong wrBit = 1ul << s;
            if ((blockers & wrBit) != 0)
                pieces.Add((wrPos << 5) + 11);

            bPieces = new BitPieces(pieces.Items);
            horz = new PseudoHorzAttack(bPieces.TF, wrPos);
            vert = new PseudoVertAttack(bPieces.TFRotationRight90, wrPos);
            hList = new BitToList(horz.AttackHorz());
            vList = new BitToList(vert.AttackVert());
            fields = new FieldPosition();
            Text = bPieces.TFRotationRight90.ToString();

            if (checkVert.Checked)
                foreach (int sq in vList.Squares)
                    fields.Add(0 + (sq << 2));
            else
                foreach (int sq in hList.Squares)
                    fields.Add(0 + (sq << 2));
            
            LayerPaint alphaLayer = new LayerPaint(fieldsPicture.DrawFields(fields.Items), piecesPicture.DrawPosition(pieces.Items));
            pictureBoard.Image = alphaLayer.Image();
        }

        private void trackVert_Scroll(object sender, EventArgs e)
        {
            laSquare.Text = "";
            if (checkVert.Checked)
                laSquare.Text = laSquare.Text + Horz[trackVert.Value] + Vert[7-trackHorz.Value];
            else
                laSquare.Text = laSquare.Text + Horz[trackHorz.Value] + Vert[trackVert.Value];
        }

        private void trackHorz_Scroll(object sender, EventArgs e)
        {
            laSquare.Text = "";
            if (checkVert.Checked)
                laSquare.Text = laSquare.Text + Horz[trackVert.Value] + Vert[7-trackHorz.Value];
            else
                laSquare.Text = laSquare.Text + Horz[trackHorz.Value] + Vert[trackVert.Value];
        }

        private void pictureMenu_MouseDown(object sender, MouseEventArgs e)
        {
            Text = (e.Y / 60 * 60).ToString(); 
            menuPicture.Select(new Point(e.X, e.Y));
            pictureMenu.Image = menuPicture.MenuImage;
        }

        private void pictureBoard_MouseDown(object sender, MouseEventArgs e)
        {
            boardClick = new AlphaBoardClick(new Point(e.X, e.Y));
            Text = boardClick.X.ToString() + ":" + boardClick.Y.ToString();
        }
    }
}
;