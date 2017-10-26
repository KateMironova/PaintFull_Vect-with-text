using PaintFull_Vect.Controls;
using PaintFull_Vect.Serialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintFull_Vect.API
{
    public class XCommand
    {
        public PPanel panel;
        public TabControl pTab;
        public PTabData childTab;

        public ActionType aType;
        public ActionColor aColor;
        public ActionWidth aWidth;
        public ActionSave aSave;
        public ActionLoad aLoad;
        public ActionStatus aStatus;
        public ActionSetText aSetText;
        public ActionTextColor aTxtColor;
        public ActionTextFont aTxtFont;
        public ActionTextAlign aTxtAlign;
        public ActionTextAngle aTxtAngle;
        public ActionAddDocument aAddDoc;
        public ActionDeleteDocument aDeleteDoc;
        public ActionTabFindDocument aTabFind;
        public ActionLanguage aLanguage;

        public XCommand()
        {
            aType = new ActionType(this);
            aColor = new ActionColor(this);
            aWidth = new ActionWidth(this);
            aSave = new ActionSave(this);
            aLoad = new ActionLoad(this);
            aStatus = new ActionStatus(this);
            aTxtColor = new ActionTextColor(this);
            aTxtFont = new ActionTextFont(this);
            aSetText = new ActionSetText(this);
            aTxtAlign = new ActionTextAlign(this);
            aTxtAngle = new ActionTextAngle(this);
            aAddDoc = new ActionAddDocument(this);
            aDeleteDoc = new ActionDeleteDocument(this);
            aTabFind = new ActionTabFindDocument(this);
            aLanguage = new ActionLanguage(this);
        }

        public class ActionColor
        {
            XCommand xcom;
            public ActionColor(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                ColorDialog dlgColor = new ColorDialog();
                if (dlgColor.ShowDialog() == DialogResult.OK)
                {
                    xcom.childTab.data.color = dlgColor.Color;
                }
            }
        }
        public class ActionWidth
        {
            XCommand xcom;
            public ActionWidth(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                xcom.childTab.data.width = Convert.ToInt32(((ComboBox)sender).SelectedItem.ToString());
            }

            public void ActionPerformed(object sender, ToolStripItemClickedEventArgs e)
            {
                xcom.childTab.data.width = Convert.ToInt32(e.ClickedItem.Text);
            }
        }
        public class ActionType
        {
            XCommand xcom;
            public ActionType(XCommand xcom)
            {
                this.xcom = xcom;
            }

            public void ActionPerformed(object sender, EventArgs e)
            {
                string type = Convert.ToString(((ComboBox)sender).SelectedItem.ToString());
                switch (type)
                {
                    case "Curve":
                        xcom.childTab.data.type = PFigure.Type.Curve;
                        break;
                    case "Line":
                        xcom.childTab.data.type = PFigure.Type.Line;
                        break;
                    case "Ellipse":
                        xcom.childTab.data.type = PFigure.Type.Ellipse;
                        break;
                    case "Rectangle":
                        xcom.childTab.data.type = PFigure.Type.Rectangle;
                        break;
                    case "RoundRectangle":
                        xcom.childTab.data.type = PFigure.Type.RoundRectangle;
                        break;
                }
            }
            public void ActionPerformed(object sender, ToolStripItemClickedEventArgs e)
            {
                string type = Convert.ToString(e.ClickedItem.Text);
                switch (type)
                {
                    case "Curve":
                        xcom.childTab.data.type = PFigure.Type.Curve;
                        break;
                    case "Line":
                        xcom.childTab.data.type = PFigure.Type.Line;
                        break;
                    case "Ellipse":
                        xcom.childTab.data.type = PFigure.Type.Ellipse;
                        break;
                    case "Rectangle":
                        xcom.childTab.data.type = PFigure.Type.Rectangle;
                        break;
                    case "RoundRectangle":
                        xcom.childTab.data.type = PFigure.Type.RoundRectangle;
                        break;
                }
            }
        }
        public class ActionSave
        {
            XCommand xcom;
            public ActionSave(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                SaveFileDialog dlgSave = new SaveFileDialog();
                string[] ext = { "JSON (*.json)|*.json", "XML (*.xml) | *.xml", "YAML (*.yaml)|*.yaml", "BIN (*.bin)|*.bin", "CSV (*.csv)|*.csv" };
                dlgSave.Filter = String.Join("|", ext);
                if (dlgSave.ShowDialog() == DialogResult.OK)
                {
                    SLFactory.GetInstance(dlgSave.FileName).Save(xcom.panel.Figures);
                }
            }
        }
        public class ActionLoad
        {
            XCommand xcom;
            public ActionLoad(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                OpenFileDialog dlgLoad = new OpenFileDialog();
                string ext = "SL (*.json; *.xml; *.yaml; *.bin; *.csv)| *.json; *.xml; *.yaml; *.bin; *.csv";
                dlgLoad.Filter = ext;
                if (dlgLoad.ShowDialog() == DialogResult.OK)
                {
                    string[] str = dlgLoad.FileName.Split('\\', '.');
                    xcom.panel.AddDoc(str[str.Length - 2]);
                    xcom.panel.Figures = SLFactory.GetInstance(dlgLoad.FileName).Load();
                    //xcom.panel.AddDoc(dlgLoad.FileName);
                }
            }
        }
        public class ActionStatus
        {
            XCommand xcom;
            public ActionStatus(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                xcom.Point = (e as MouseEventArgs).Location;
            }
        }
        public class ActionTextColor
        {
            XCommand xcom;
            public ActionTextColor(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                ColorDialog dlgColor = new ColorDialog();
                if (dlgColor.ShowDialog() == DialogResult.OK)
                {
                    xcom.childTab.xText.BrushTxt.Color = dlgColor.Color;
                }
            }
        }
        public class ActionSetText
        {
            XCommand xcom;
            public ActionSetText(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e, string txt)
            {
                xcom.childTab.xText.Text = txt;
            }
        }
        public class ActionTextFont
        {
            XCommand xcom;
            public ActionTextFont(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                FontDialog dlgFont = new FontDialog();
                if (dlgFont.ShowDialog() == DialogResult.OK)
                {
                    xcom.childTab.xText.FontTxt = dlgFont.Font;
                }
            }
        }
        public class ActionTextAlign
        {
            XCommand xcom;
            public ActionTextAlign(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                StringFormat strF = new StringFormat();
                string type = ((ComboBox)sender).SelectedItem.ToString();
                switch (type)
                {
                    case "Top":
                        xcom.childTab.xText.FormatTxt.LineAlignment = StringAlignment.Near;
                        break;
                    case "Center":
                        xcom.childTab.xText.FormatTxt.Alignment = StringAlignment.Center;
                        xcom.childTab.xText.FormatTxt.LineAlignment = StringAlignment.Center;
                        break;
                    case "Bottom":
                        xcom.childTab.xText.FormatTxt.LineAlignment = StringAlignment.Far;
                        break;
                    case "Left":
                        xcom.childTab.xText.FormatTxt.Alignment = StringAlignment.Near;
                        break;
                    case "Right":
                        xcom.childTab.xText.FormatTxt.Alignment = StringAlignment.Far;
                        break;
                }
            }
            public void ActionPerformed(object sender, ToolStripItemClickedEventArgs e)
            {
                StringFormat strF = new StringFormat();
                string type = e.ClickedItem.Text;
                switch (type)
                {
                    case "Top":
                        xcom.childTab.xText.FormatTxt.LineAlignment = StringAlignment.Near;
                        break;
                    case "Center":
                        xcom.childTab.xText.FormatTxt.Alignment = StringAlignment.Center;
                        xcom.childTab.xText.FormatTxt.LineAlignment = StringAlignment.Center;
                        break;
                    case "Bottom":
                        xcom.childTab.xText.FormatTxt.LineAlignment = StringAlignment.Far;
                        break;
                    case "Left":
                        xcom.childTab.xText.FormatTxt.Alignment = StringAlignment.Near;
                        break;
                    case "Right":
                        xcom.childTab.xText.FormatTxt.Alignment = StringAlignment.Far;
                        break;
                }
            }
        }
        public class ActionTextAngle
        {
            XCommand xcom;
            public ActionTextAngle(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                xcom.childTab.xText.RotateAngle = Convert.ToInt32(((ComboBox)sender).SelectedItem.ToString());
            }
            public void ActionPerformed(object sender, ToolStripItemClickedEventArgs e)
            {
                xcom.childTab.xText.RotateAngle = Convert.ToInt32(e.ClickedItem.Text);
            }
        }
        public class ActionAddDocument
        {
            XCommand xcom;
            public ActionAddDocument(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                xcom.panel.AddDoc();
            }
        }
        public class ActionDeleteDocument
        {
            XCommand xcom;
            public ActionDeleteDocument(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                xcom.panel.DeleteDoc();
            }
        }
        public class ActionTabFindDocument
        {
            XCommand xcom;
            public ActionTabFindDocument(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, ToolStripItemClickedEventArgs e)
            {
                //xcom.panel.TabFind(e.ToString());
            }
        }
        public class ActionLanguage
        {
            XCommand xcom;
            public ActionLanguage(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, ToolStripItemClickedEventArgs e)
            {
                string type = Convert.ToString(e.ClickedItem.Name);
                switch (type)
                {
                    case "englishToolStripMenuItem":
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                        xcom.panel.pMenu1.ReLoad();
                        break;
                    case "russianToolStripMenuItem":
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
                        xcom.panel.pMenu1.ReLoad();
                        break;
                }
                Properties.Settings.Default.Language = e.ClickedItem.ToString();

            }
        }

        public Point point;
        public Point Point
        {
            get { return point; }
            set
            {
                point = value;
                CoordsChanged(point);
            }
        }
        public delegate void coordDelegate(Point p);
        public event coordDelegate CoordsChanged;
    }

}
