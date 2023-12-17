using System.Drawing;

namespace ChessImages
{
    public interface IFieldStyle
    {
        Bitmap Image(int item);
        int Size();
    }
    public interface IPieceStyle
    {
        Bitmap Image(int item);
        int SquareSize();
        int BoardSize();
        int BordSize();
    }
    
    public class OldPieces: IPieceStyle
    {
        private Bitmap[] items;
        public OldPieces()
        {
            items = new Bitmap[12];
            items[00] = new Bitmap(Properties.Resources.wkOldStyle);
            items[01] = new Bitmap(Properties.Resources.wqOldStyle);
            items[02] = new Bitmap(Properties.Resources.wrOldStyle);
            items[03] = new Bitmap(Properties.Resources.wbOldStyle);
            items[04] = new Bitmap(Properties.Resources.wnOldStyle);
            items[05] = new Bitmap(Properties.Resources.wpOldStyle);
            items[06] = new Bitmap(Properties.Resources.bkOldStyle);
            items[07] = new Bitmap(Properties.Resources.bqOldStyle);
            items[08] = new Bitmap(Properties.Resources.brOldStyle);
            items[09] = new Bitmap(Properties.Resources.bbOldStyle);
            items[10] = new Bitmap(Properties.Resources.bnOldStyle);
            items[11] = new Bitmap(Properties.Resources.bpOldStyle);
        }
        public Bitmap Board()
        {
            return Properties.Resources.areaOldStyle;
        }
        public Bitmap Image(int item)
        {
            return items[(item & 31) - (((item & 24) >> 2) + 7)];
        }
        public int SquareSize()
        {
            return 40;
        }
        public int BoardSize()
        {
            return 340;
        }
        public int BordSize()
        {
            return 20;
        }
    }
    public class OldField : IFieldStyle
    {
        private Bitmap[] images;
        public OldField()
        {
            images = new Bitmap[4];
            images[0] = new Bitmap(Properties.Resources.fieldCoralOldStyle);
            images[1] = new Bitmap(Properties.Resources.fieldGreenOldStyle);
            images[2] = new Bitmap(Properties.Resources.fieldLeafyOldStyle);
            images[3] = new Bitmap(Properties.Resources.fieldBrickOldStyle);
        }
        public Bitmap Image(int item)
        {
            return images[(item & 3)];
        }
        public int Size()
        {
            return 40;
        }
    }
    public class AlphaPieces: IPieceStyle
    {
        private Bitmap[] items;
        public AlphaPieces()
        {
            items = new Bitmap[12];
            items[00] = new Bitmap(Properties.Resources.wkAlpha);
            items[01] = new Bitmap(Properties.Resources.wqAlpha);
            items[02] = new Bitmap(Properties.Resources.wrAlpha);
            items[03] = new Bitmap(Properties.Resources.wbAlpha);
            items[04] = new Bitmap(Properties.Resources.wnAlpha);
            items[05] = new Bitmap(Properties.Resources.wpAlpha);
            items[06] = new Bitmap(Properties.Resources.bkAlpha);
            items[07] = new Bitmap(Properties.Resources.bqAlpha);
            items[08] = new Bitmap(Properties.Resources.brAlpha);
            items[09] = new Bitmap(Properties.Resources.bbAlpha);
            items[10] = new Bitmap(Properties.Resources.bnAlpha);
            items[11] = new Bitmap(Properties.Resources.bpAlpha);
        }
        public Bitmap Board()
        {
            return Properties.Resources.areaAlpha;
        }
        public Bitmap Image(int item)
        {
            return items[(item & 31) - (((item & 24) >> 2) + 7)];
        }
        public int SquareSize()
        {
            return 60;
        }
        public int BoardSize()
        {
            return 530;
        }
        public int BordSize()
        {
            return 50;
        }
    }
    public class AlphaField : IFieldStyle
    {
        private Bitmap[] images;
        public AlphaField()
        {
            images = new Bitmap[4];
            images[0] = new Bitmap(Properties.Resources.fieldGreenAlpha);
            images[1] = new Bitmap(Properties.Resources.fieldBrickAlpha);
            images[2] = new Bitmap(Properties.Resources.fieldBlackAlpha);
            images[3] = new Bitmap(Properties.Resources.fieldWhiteAlpha);
        }
        public Bitmap Image(int item)
        {
            return images[(item & 3)];
        }
        public int Size()
        {
            return 60;
        }
    }
    public class ChessMenu
    {
        private Bitmap _image;
        private Bitmap _selected;
        private Bitmap _cell;
        public ChessMenu()
        {
            _image = Properties.Resources.menuAlphaBackground;
            _selected = Properties.Resources.pickAlpha;
            _cell = Properties.Resources.menuAlpha;
        }
        public Bitmap Image { get { return _image; } }
        public Bitmap Selected { get { return _selected; } }
        public Bitmap Cell { get { return _cell; } }
    }
}
