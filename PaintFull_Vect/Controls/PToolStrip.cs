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
    public partial class PToolStrip : UserControl
    {
        public XCommand xcom { get; set; }
        public PToolStrip()
        {
            InitializeComponent();

            toolStripBtnColor.Click += new EventHandler((s, e) => xcom.aColor.ActionPerformed(s, e));
            toolStripSplitBtnWidth.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aWidth.ActionPerformed(s, e));
            toolStripSplitBtnType.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aType.ActionPerformed(s, e));
            toolStripBtnSave.Click += new EventHandler((s, e) => xcom.aSave.ActionPerformed(s, e));
            toolStripBtnLoad.Click += new EventHandler((s, e) => xcom.aLoad.ActionPerformed(s, e));
            toolStripBtnColorTxt.Click += new EventHandler((s, e) => xcom.aTxtColor.ActionPerformed(s, e));
            toolStripBtnFontTxt.Click += new EventHandler((s, e) => xcom.aTxtFont.ActionPerformed(s, e));
            toolStripBtnAlignTxt.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aTxtAlign.ActionPerformed(s, e));
            toolStripBtnAngleTxt.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aTxtAngle.ActionPerformed(s, e));
            toolStripButton1.Click += new EventHandler((s, e) => xcom.aSetText.ActionPerformed(s, e, SetText.Text.ToString()));
        }

    }
}
