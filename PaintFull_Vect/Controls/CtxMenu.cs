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
    public partial class CtxMenu : UserControl
    {
        PFigure activeFigure;
        public CtxMenu(PFigure figure)
        {
            InitializeComponent();

            activeFigure = figure;
            colorToolStripMenuItem.Click += ChangeColor;
            widthToolStripMenuItem.DropDownItemClicked += ChangeWidth;
            typeToolStripMenuItem.DropDownItemClicked += ChangeType;
            changeColorToolStripMenuItem.Click += ChangeTextColor;
            changeFontToolStripMenuItem.Click += ChangeTextFont;
            changeAlignToolStripMenuItem.DropDownItemClicked += ChangeTextAlign;
            changeAngleToolStripMenuItem.DropDownItemClicked += ChangeTextAngle;
            changeTextToolStripMenuItem.Click += ChangeText;
        }

        private void ChangeType(object sender, ToolStripItemClickedEventArgs e)
        {
            string type = e.ClickedItem.Text;
            switch (type)
            {
                case "Curve":
                    activeFigure.FigureType = PFigure.Type.Curve;
                    break;
                case "Line":
                    activeFigure.FigureType = PFigure.Type.Line;
                    break;
                case "Ellipse":
                    activeFigure.FigureType = PFigure.Type.Ellipse;
                    break;
                case "Rectangle":
                    activeFigure.FigureType = PFigure.Type.Rectangle;
                    break;
                case "RoundRectangle":
                    activeFigure.FigureType = PFigure.Type.RoundRectangle;
                    break;
                
            }
            activeFigure.UpdateFigure();
        }
        private void ChangeWidth(object sender, ToolStripItemClickedEventArgs e)
        {
            activeFigure.LineWidth = Convert.ToInt32(e.ClickedItem.Text);
            activeFigure.UpdateFigure();
        }
        private void ChangeColor(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                activeFigure.Color = dlgColor.Color;
                activeFigure.UpdateFigure();
            }
        }
        private void ChangeTextColor(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                activeFigure.xText.BrushTxt.Color = dlgColor.Color;
                activeFigure.UpdateFigure();
            }
        }
        private void ChangeTextFont(object sender, EventArgs e)
        {
            FontDialog dlgFont = new FontDialog();
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                activeFigure.xText.FontTxt = dlgFont.Font;
                activeFigure.UpdateFigure();
            }
        }
        private void ChangeTextAlign(object sender, ToolStripItemClickedEventArgs e)
        {
            StringFormat strF = new StringFormat();
            string type = e.ClickedItem.Text;
            switch (type)
            {
                case "Top":
                    activeFigure.xText.FormatTxt.LineAlignment = StringAlignment.Near;
                    break;
                case "Center":
                    activeFigure.xText.FormatTxt.Alignment = StringAlignment.Center;
                    activeFigure.xText.FormatTxt.LineAlignment = StringAlignment.Center;
                    break;
                case "Bottom":
                    activeFigure.xText.FormatTxt.LineAlignment = StringAlignment.Far;
                    break;
                case "Left":
                    activeFigure.xText.FormatTxt.Alignment = StringAlignment.Near;
                    break;
                case "Right":
                    activeFigure.xText.FormatTxt.Alignment = StringAlignment.Far;
                    break;
            }
            activeFigure.UpdateFigure();
        }
        private void ChangeTextAngle(object sender, ToolStripItemClickedEventArgs e)
        {
            activeFigure.xText.RotateAngle = Convert.ToInt32(e.ClickedItem.Text);
            activeFigure.UpdateFigure();
        }
        private void ChangeText(object sender, EventArgs e)
        {
            activeFigure.xText.Text = toolStripTextBox1.Text;
            activeFigure.UpdateFigure();
        }
    }
}
