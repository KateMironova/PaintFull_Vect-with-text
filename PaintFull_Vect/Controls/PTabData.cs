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
    public class PTabData : TabPage
    {
        public XData data;
        public XText xText;
        public PDraw pDraw;
        XCommand xcom { set; get; }

        public PTabData(int createdTab, TabControl tabControl1, XCommand xcom)
        {
            data = new XData();
            xText = new XText();
            pDraw = new PDraw();

            Name = "Document " + createdTab.ToString();
            Text = "Document " + createdTab.ToString();
            tabControl1.TabPages.Add(this);
            pDraw.data = data;
            pDraw.xcom = xcom;
            pDraw.xText = xText;
            pDraw.pictBox.MouseMove += xcom.aStatus.ActionPerformed;
            pDraw.Location = new Point(0, 0);
            pDraw.Size = new Size(803, 377);
            Controls.Add(pDraw);


        }

    }
}
