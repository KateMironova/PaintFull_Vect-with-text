using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using PaintFull_Vect.Serialization;
using PaintFull_Vect.Controls;

namespace PaintFull_Vect.API
{
    public partial class PFigure : PictureBox
    {
        public enum Type { Curve, Line, Ellipse, Rectangle, RoundRectangle };
        public enum Side { left, topLeft, top, topRight, right, botRight, bot, botLeft, none, startLine, endLine, center };
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color Color { get; set; }
        public int LineWidth { get; set; }
        public Type FigureType { get; set; }
        public Size FigureSize { get; private set; }
        public XData data { get; set; }
        public XText xText { get; set; }
        int space;
        Point moving;
        Side resizing;

        public PFigure(XData data, Point start, Point end, XText xText)
        {
            Init(start, end, data, xText);
        }
        public PFigure()
        { }
        private void Init(Point location, Point endPoint, XData data, XText xText)
        {
            InitializeComponent();
            
            Color = data.color;
            StartPoint = location;
            EndPoint = endPoint;
            FigureType = data.type;
            LineWidth = data.width;
            Size = new Size(GetFigureSize().Width + 1, GetFigureSize().Height + 1);
            BackColor = Color.Transparent;

            this.xText = xText;

            ContextMenuStrip = ctxMenu1.contextMenuStrip1;

            if (data.type != Type.Line)
            {
                StartPoint = new Point(Math.Min(endPoint.X, location.X), Math.Min(endPoint.Y, location.Y));
                EndPoint = new Point(Math.Max(endPoint.X, location.X), Math.Max(endPoint.Y, location.Y));
            }
            else
            {
                StartPoint = location;
                EndPoint = endPoint;
            }

            FigureSize = new Size(Math.Abs(EndPoint.X - StartPoint.X), Math.Abs(EndPoint.Y - StartPoint.Y));
            Color = data.color;
            FigureType = data.type;
            LineWidth = data.width;
            space = 4 + LineWidth;

            UpdateFigure();
        }
        Rectangle figureRect;
        public void UpdateFigure()
        {
            space = 4 + LineWidth;

            figureRect = new Rectangle(new Point(LineWidth / 2, LineWidth / 2), FigureSize);
            Width = FigureSize.Width + LineWidth;
            Height = FigureSize.Height + LineWidth;

            Bitmap bitmap = new Bitmap(Width, Height);
            Pen figurePen = new Pen(Color, LineWidth);

            using (Graphics g = Graphics.FromImage(bitmap))
            {

                g.Clear(Color.Transparent);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                switch (FigureType)
                {
                    case Type.Rectangle: g.DrawRectangle(figurePen, figureRect); break;
                    //case Type.RoundRectangle: g.DrawPath(figurePen, GetRRectangle(figureRect)); break;
                    case Type.Ellipse: g.DrawEllipse(figurePen, figureRect); break;
                    //case Type.Line: g.DrawLine(figurePen); break;
                }
            }
            Graphics graph = Graphics.FromImage(bitmap);

            graph.TranslateTransform(Width / 2, Height / 2);// перемещаемся на нужную точку
            graph.RotateTransform(xText.RotateAngle);// поворачиваем элемент
            graph.TranslateTransform(-Width / 2, -Height / 2);// возвращаемся назад

            graph.DrawString(xText.Text, xText.FontTxt, xText.BrushTxt, figureRect, xText.FormatTxt);

            BackgroundImage = bitmap;

            if (FigureType != Type.Line)
                Location = StartPoint;
        }

        #region DrawingFunctions
        public Size GetFigureSize()
        {
            int width = Math.Abs(EndPoint.X - StartPoint.X);
            int height = Math.Abs(EndPoint.Y - StartPoint.Y);
            return new Size(width, height);
        }

        public GraphicsPath GetGraphicsPath()
        {

            Size size = GetFigureSize();
            Point pathStart = new Point(0, 0);
            Point lineEnd = new Point(GetFigureSize().Width, GetFigureSize().Height);

            GraphicsPath figure = new GraphicsPath();

            if (FigureType == Type.Rectangle)
                figure.AddRectangle(new Rectangle(pathStart, size));
            else if (FigureType == Type.Ellipse)
                figure.AddEllipse(new Rectangle(pathStart, size));
            else if (FigureType == Type.Line)
                figure.AddLine(pathStart, lineEnd);
            else if (FigureType == Type.RoundRectangle)
                figure.AddPath(RoundRectangle(new Rectangle(pathStart, size), 20), false);

            return figure;
        }

        private GraphicsPath RoundRectangle(Rectangle bounds, int diameter)
        {
            GraphicsPath path = new GraphicsPath();
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            arc.Y = bounds.Top;
            path.CloseFigure();
            return path;
        }
        #endregion
        #region ResizingMethods
        private void ResizeFigure(Point location)
        {
            int x1 = StartPoint.X;
            int y1 = StartPoint.Y;
            int x2 = EndPoint.X;
            int y2 = EndPoint.Y;


            if (resizing == Side.top)
            {
                y1 = location.Y;
                if (y1 > y2)
                    resizing = Side.bot;
            }
            else if (resizing == Side.topRight)
            {
                y1 = location.Y;
                x2 = location.X;
                if (y1 > y2)
                    resizing = Side.botRight;
                else if (x2 < x1)
                    resizing = Side.topLeft;
            }
            else if (resizing == Side.right)
            {
                x2 = location.X;
                if (x2 < x1)
                    resizing = Side.left;
            }
            else if (resizing == Side.botRight || resizing == Side.endLine)
            {
                x2 = location.X;
                y2 = location.Y;
                if (y2 < y1 && resizing != Side.endLine)
                    resizing = Side.topRight;
                else if (x2 < x1 && resizing != Side.endLine)
                    resizing = Side.botLeft;
            }
            else if (resizing == Side.bot)
            {
                y2 = location.Y;
                if (y2 < y1)
                    resizing = Side.top;
            }
            else if (resizing == Side.botLeft)
            {
                x1 = location.X;
                y2 = location.Y;
                if (y2 < y1)
                    resizing = Side.topLeft;
                else if (x1 > x2)
                    resizing = Side.botRight;
            }
            else if (resizing == Side.left)
            {
                x1 = location.X;
                if (x1 > x2)
                    resizing = Side.right;
            }
            else if (resizing == Side.topLeft || resizing == Side.startLine)
            {
                x1 = location.X;
                y1 = location.Y;
                if (y1 > y2 && resizing != Side.startLine)
                    resizing = Side.botLeft;
                else if (x1 > x2 && resizing != Side.startLine)
                    resizing = Side.topRight;
            }


            StartPoint = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            EndPoint = new Point(Math.Max(x1, x2), Math.Max(y1, y2));
            FigureSize = new Size(EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);

            UpdateFigure();

        }
        private Side GetSide(Point point)
        {
            Side pos = Side.none;
            int x = point.X;
            int y = point.Y;
            if (0 <= y && y <= space)
            {
                if (0 <= x && x <= space)
                    pos = Side.topLeft;
                else if (space <= x && x <= Width - space)
                    pos = Side.top;
                else if (Width - space <= x && x <= Width)
                    pos = Side.topRight;
            }
            else if (space <= y && y <= Height - space)
            {
                if (0 <= x && x <= space)
                    pos = Side.left;
                else if (space <= x && x <= Width - space)
                    pos = Side.center;
                else if (Width - space <= x && x <= Width)
                    pos = Side.right;
            }
            else if (Height - space <= y && y <= Height)
            {
                if (0 <= x && x <= space)
                    pos = Side.botLeft;
                else if (space <= x && x <= Width - space)
                    pos = Side.bot;
                else if (Width - space <= x && x <= Width)
                    pos = Side.botRight;
            }
            return pos;
        }
        private void ChangeCursor(Side pos)
        {
            if (pos == Side.top || pos == Side.bot)
                Cursor.Current = Cursors.SizeNS;
            else if (pos == Side.topRight || pos == Side.botLeft)
                Cursor.Current = Cursors.SizeNESW;
            else if (pos == Side.botRight || pos == Side.topLeft)
                Cursor.Current = Cursors.SizeNWSE;
            else if (pos == Side.right || pos == Side.left)
                Cursor.Current = Cursors.SizeWE;
            else if (pos == Side.startLine || pos == Side.endLine || pos == Side.center)
                Cursor.Current = Cursors.SizeAll;
            else
                Cursor.Current = Cursors.Arrow;
        }
        #endregion
        #region MouseEvents
        private void PFigure_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moving = e.Location;
                resizing = GetSide(e.Location);
            }
            else if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip.Show(e.Location);
            }
        }

        private void PFigure_MouseMove(object sender, MouseEventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
            ChangeCursor(GetSide(e.Location));
            if (e.Button == MouseButtons.Left)
            {
                if (resizing == Side.center)
                {
                    StartPoint = new Point(StartPoint.X + (e.Location.X - moving.X), StartPoint.Y + (e.Location.Y - moving.Y));
                    EndPoint = new Point(StartPoint.X + FigureSize.Width, StartPoint.Y + FigureSize.Height);
                    Location = StartPoint;
                }
                else
                {
                    ResizeFigure(new Point(StartPoint.X + e.Location.X, StartPoint.Y + e.Location.Y));
                }
            }
        }

        private void PFigure_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }
        #endregion
        #region Memento

        public void SetMemento(FigureMemento memento)
        {
            InitializeComponent();
            PFigure figure = memento.GetState();
            Init(figure.StartPoint, figure.EndPoint, figure.data, figure.xText);
        }
        public FigureMemento GetMemento()
        {
            return new FigureMemento(this);
        }
        #endregion
        
    }
}
