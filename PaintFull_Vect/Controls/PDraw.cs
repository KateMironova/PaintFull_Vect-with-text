using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintFull_Vect.API;

namespace PaintFull_Vect.Controls
{
    public partial class PDraw : UserControl
    {
        public XCommand xcom { get; set; }

        public PDraw()
        {
            InitializeComponent();
        }

        public XData data { get; set; }
        public XText xText { get; set; }
        public Point startPoint;
        private void pictBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                startPoint = e.Location;
        }

        private void pictBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (data.type == PFigure.Type.Curve && e.Button == MouseButtons.Left)
            {
                using (Graphics g = pictBox.CreateGraphics())
                {
                    g.DrawLine(new Pen(data.color, data.width), startPoint, e.Location);
                    startPoint = e.Location;
                }
            }
        }

        private void pictBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (data.type != PFigure.Type.Curve)
            {
                PFigure figure = new PFigure(data, startPoint, e.Location, xText);
                figure.MouseMove += xcom.aStatus.ActionPerformed;
                pictBox.Controls.Add(figure);
                figure.Location = startPoint;
            }
        }
        public PictureBox GetPictureBox()
        {
            return pictBox;
        }

    }
}
