using PaintFull_Vect.API;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintFull_Vect.Serialization
{
    [Serializable()]
    public class FigureMemento
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int color { get; set; }
        public int width { get; set; }
        public int type { get; set; }
        
        public string Text { get; set; }
        public string FontTypeTxt { get; set; }
        public float FontSizeTxt { get; set; }
        public int ColorBrushTxt { get; set; }
        public int FormatTxtAlignment { get; set; }
        public int FormatTxtLineAlignment { get; set; }
        public int RotateAngle { get; set; }

        public FigureMemento(PFigure figure)
        {
            x1 = figure.StartPoint.X;
            y1 = figure.StartPoint.Y;
            x2 = figure.EndPoint.X;
            y2 = figure.EndPoint.Y;
            color = figure.Color.ToArgb();
            width = figure.LineWidth;
            type = (int)figure.FigureType;
            Text = figure.xText.Text;
            FontTypeTxt = figure.xText.FontTxt.Name;
            FontSizeTxt = figure.xText.FontTxt.Size;
            ColorBrushTxt = figure.xText.BrushTxt.Color.ToArgb();
            FormatTxtAlignment = (int)figure.xText.FormatTxt.Alignment;
            FormatTxtLineAlignment = (int)figure.xText.FormatTxt.LineAlignment;
            RotateAngle = figure.xText.RotateAngle;


        }

        public FigureMemento()
        {

        }

        public PFigure GetState()
        {
            XData xdata = new XData();
            xdata.type = (PFigure.Type)type;
            xdata.color = Color.FromArgb(color);
            xdata.width = width;

            XText xText = new XText();
            xText.Text = Text;
            xText.FontTxt = new Font(FontTypeTxt, FontSizeTxt);
            xText.BrushTxt = new SolidBrush(Color.FromArgb(ColorBrushTxt));
            StringFormat f = new StringFormat();
            f.Alignment = (StringAlignment)FormatTxtAlignment;
            f.LineAlignment = (StringAlignment)FormatTxtLineAlignment;
            xText.FormatTxt = f;
            xText.RotateAngle = RotateAngle;

            return new PFigure
            {
                data = xdata,
                StartPoint = new Point(x1, y1),
                EndPoint = new Point(x2, y2),
                xText = xText
            };
        }
    }
}
