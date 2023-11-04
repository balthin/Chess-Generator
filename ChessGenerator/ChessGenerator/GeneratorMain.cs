using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChessImages;
using ChessSystem.Structure;
using ChessSystem.Painting;
using ChessSystem.Bitboard;

namespace ChessGenerator
{
    public partial class foMain : Form
    {
        AlphaPieces alphaStyle;
        PiecePosition pieces;
        PiecePaint piecesPicture;

        AlphaField alphaFields;
        FieldPosition fields;
        FieldPaint fieldsPicture;

        BitPieces bPieces;
        PseudoAttack pseudo;

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

            StartPositionChess();
        }

        private void numericPosition_ValueChanged(object sender, EventArgs e)
        {
            pieces = new PiecePosition();
            ulong num = (ulong)numericPosition.Value;
            int wrPos = (int)trackHorz.Value;
            
            ulong b = 1;
            for (int i = 0; i < 64; i++, b = (1ul << i))
            {
                if ((num & b) != 0)
                    pieces.Add((i << 5) + 21);
            }
            
            int track = (int)trackHorz.Value;
            ulong wrBit = 1ul << track;
            if ((num & wrBit) != 0)
                pieces.Add((track << 5) + 11);

            bPieces = new BitPieces(pieces.Items);
            pseudo = new PseudoAttack(bPieces.TF, wrPos);

            fields = new FieldPosition();

            foreach (int s in pseudo.AttackList())
                fields.Add(0 + (s << 2));
            
            LayerPaint alphaLayer = new LayerPaint(fieldsPicture.DrawFields(fields.Items), piecesPicture.DrawPosition(pieces.Items));
            pictureBoard.Image = alphaLayer.Image();
        }

        /// <summary>
        /// Раставить начальную позизицю.
        /// </summary>
        private void StartPositionChess()
        {
            pieces = new PiecePosition();
            pieces.Initialize();

            //pieces.Remove(11);
            //int pawn = 6;
            //int white = 8;
            //int whitePawn = white + pawn;
            //int vert = 3;
            //int horz = 3 << 3;
            //int e4 = vert + horz;
            //int wpE4 = whitePawn + (e4 << 5);

            //pieces.Add(wpE4);
            //pieces.Add(878);

            pieces.Remove(51);
            int color = 8;
            int white = 0;
            int black = 1;
            int colorFigure = color << black;
            int pawn = 6;
            //int black = 14;
            int blackPawn = colorFigure + pawn;
            int vert = 3;
            int horz = 4 << 3;
            int e5 = vert + horz;
            int wpE5 = blackPawn + (e5 << 5);
            pieces.Add(wpE5);

            piecesPicture = new PiecePaint(alphaStyle);
            piecesPicture.DrawPosition(pieces.Items);

            alphaFields = new AlphaField();
            fields = new FieldPosition();
            fieldsPicture = new FieldPaint(alphaFields);
            var layer = new LayerPaint(fieldsPicture.DrawFields(fields.Items), piecesPicture.DrawPosition(pieces.Items));
            pictureBoard.Image = layer.Image();
        }
    }
}
;