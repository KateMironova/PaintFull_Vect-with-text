using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintFull_Vect.API
{
    public class XData
    {
        public PFigure.Type type { get; set; }
        public Color color { get; set; }
        public int width { get; set; }

        public XData()
        {
            type = PFigure.Type.Curve;
            color = Color.Black;
            width = 1;
        }
    }
}
