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

namespace ChessGenerator
{
    public partial class Form1 : Form
    {
        AlphaPieces alpha;
        PiecePosition alphaPosition;
        PiecePaint alphaPaint;

        AlphaField alf;
        FieldPosition alfPosition;
        FieldPaint alfPaint;

        public Form1()
        {
            InitializeComponent();
            int wp = 8 + 6;
            int e2 = 3 + (1 << 3);
            int e4 = 3 + (3 << 3);
            int d5 = 4 + (4 << 3);
            int wr = 8 + 3;

            alpha = new AlphaPieces();
            panelBoard.BackgroundImage = alpha.Board();
            panelBoard.Size = new Size(alpha.BoardSize(), alpha.BoardSize());
            pictureBoard.Size = new Size(alpha.BoardSize() - alpha.BordSize(), alpha.BoardSize() - alpha.BordSize());
            pictureBoard.Location = new Point(alpha.BordSize() / 2, alpha.BordSize() / 2);
            pictureBoard.BackColor = Color.Transparent;
            
            alf = new AlphaField();

            alfPosition = new FieldPosition();
            //alfPosition.Add((d5 << 2) + 3);
            alfPaint = new FieldPaint(alf);

            alphaPosition = new PiecePosition();
            //alphaPosition.Add(wr + (d5 << 5));
            alphaPosition.Initialize();
            alphaPaint = new PiecePaint(alpha);

            LayerPaint alphaLayer = new LayerPaint(alfPaint.DrawFields(alfPosition.Items), alphaPaint.DrawPosition(alphaPosition.Items));

            pictureBoard.Image = alphaLayer.Image();
        }
    }
}
;