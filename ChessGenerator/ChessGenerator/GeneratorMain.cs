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
using BitCalculation;
using Bitboard;

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

        String[] Vert = { "1", "2", "3", "4", "5", "6", "7", "8" };
        String[] Horz = { "H", "G", "F", "E", "D", "C", "B", "A" };

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
        }

        private void numericPosition_ValueChanged(object sender, EventArgs e)
        {
            pieces = new PiecePosition();
            
            int h = (int)trackHorz.Value;
            int v = (int)trackVert.Value;
            int s = h | (v << 3);
            int wrPos = s;

            ulong num = (ulong)numericPosition.Value;
            ulong blockers = num << (v * 8);
            
            ulong b = 1;
            for (int i = 0; i < 64; i++, b = (1ul << i))
            {
                if ((blockers & b) != 0)
                    pieces.Add((i << 5) + 21);
            }
            
            
            ulong wrBit = 1ul << s;
            if ((blockers & wrBit) != 0)
                pieces.Add((s << 5) + 11);

            bPieces = new BitPieces(pieces.Items);
            pseudo = new PseudoAttack(bPieces.TF, wrPos);
            Text = pseudo.AttackHorz().ToString();
            fields = new FieldPosition();

            foreach (int sq in pseudo.AttackList())
                fields.Add(0 + (sq << 2));

            
            
            LayerPaint alphaLayer = new LayerPaint(fieldsPicture.DrawFields(fields.Items), piecesPicture.DrawPosition(pieces.Items));
            pictureBoard.Image = alphaLayer.Image();
        }

        private void trackVert_Scroll(object sender, EventArgs e)
        {
            laSquare.Text = "";
            laSquare.Text = laSquare.Text + Horz[trackHorz.Value] + Vert[trackVert.Value];
        }

        private void trackHorz_Scroll(object sender, EventArgs e)
        {
            laSquare.Text = "";
            laSquare.Text = laSquare.Text + Horz[trackHorz.Value] + Vert[trackVert.Value];
        }
    }
}
;