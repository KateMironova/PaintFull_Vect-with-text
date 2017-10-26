using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaintFull_Vect.API
{

    public class XText
    {
        public string Text { get; set; }
        public Font FontTxt { get; set; }
        public SolidBrush BrushTxt { get; set; }
        public StringFormat FormatTxt { get; set; }
        public int RotateAngle { get; set; }
        public XText()
        {
            Text = "text1";
            FontTxt = new Font("Arial", 12);
            FormatTxt = new StringFormat();
            FormatTxt.Alignment = StringAlignment.Center;
            FormatTxt.LineAlignment = StringAlignment.Center;
            BrushTxt = new SolidBrush(Color.Black);
            RotateAngle = 360;
        }
    }
}
