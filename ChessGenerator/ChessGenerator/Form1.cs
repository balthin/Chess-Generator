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
    public partial class Form1 : Form
    {
        AlphaPieces alphaStyle;
        PiecePosition pieces;
        PiecePaint piecesPicture;

        AlphaField alphaFields;
        FieldPosition fields;
        FieldPaint fieldsPicture;

        BitPieces bPieces;

        public Form1()
        {
            InitializeComponent();
           
            alphaStyle = new AlphaPieces();
            panelBoard.BackgroundImage = alphaStyle.Board();
            panelBoard.Size = new Size(alphaStyle.BoardSize(), alphaStyle.BoardSize());
            pictureBoard.Size = new Size(alphaStyle.BoardSize() - alphaStyle.BordSize(), alphaStyle.BoardSize() - alphaStyle.BordSize());
            pictureBoard.Location = new Point(alphaStyle.BordSize() / 2, alphaStyle.BordSize() / 2);
            pictureBoard.BackColor = Color.Transparent;
            
            alphaFields = new AlphaField();
            fields = new FieldPosition();
            fieldsPicture = new FieldPaint(alphaFields);

            pieces = new PiecePosition();
            pieces.Initialize();
            piecesPicture = new PiecePaint(alphaStyle);

            LayerPaint alphaLayer = new LayerPaint(fieldsPicture.DrawFields(fields.Items), piecesPicture.DrawPosition(pieces.Items));

            pictureBoard.Image = alphaLayer.Image();
            
            bPieces = new BitPieces(pieces.Items);
        }
    }
}
;