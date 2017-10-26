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
    public partial class TextBar : UserControl
    {
        public XCommand xcom { get; set; }
        public XData data { get; set; }
        public TextBar()
        {
            InitializeComponent();
            //this.xcom = xcom;
            //data = xcom.data;

            btnSetTxt.Click += new EventHandler((s, e) => xcom.aSetText.ActionPerformed(s, e, SetText.Text.ToString()));
            btnColorTxt.Click += new EventHandler((s, e) => xcom.aTxtColor.ActionPerformed(s, e));
            btnFontTxt.Click += new EventHandler((s, e) => xcom.aTxtFont.ActionPerformed(s, e));
            comboAlignTxt.SelectedIndexChanged += new EventHandler((s, e) => xcom.aTxtAlign.ActionPerformed(s, e));
            comboAngleTxt.SelectedIndexChanged += new EventHandler((s, e) => xcom.aTxtAngle.ActionPerformed(s, e));
        }

    }
}
