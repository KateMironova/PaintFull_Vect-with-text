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
    public partial class PMenu : UserControl
    {
        public XCommand xcom { get; set; }
        public PMenu()
        {
            InitializeComponent();

            chooseColorToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aColor.ActionPerformed(s, e));
            widthToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aWidth.ActionPerformed(s, e));
            typeToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aType.ActionPerformed(s, e));
            saveAsToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aSave.ActionPerformed(s, e));
            browseToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aLoad.ActionPerformed(s, e));
            fontToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aTxtFont.ActionPerformed(s, e));
            changeColorToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aTxtColor.ActionPerformed(s, e));
            textAlignToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aTxtAlign.ActionPerformed(s, e));
            textDirectionToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aTxtAngle.ActionPerformed(s, e));
            changeTextToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aSetText.ActionPerformed(s, e, toolStripTextBox1.Text.ToString()));
            addToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aAddDoc.ActionPerformed(s, e));
            deleteToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aDeleteDoc.ActionPerformed(s, e));
            tabToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aTabFind.ActionPerformed(s, e));
            languageToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aLanguage.ActionPerformed(s, e));
        }
        public void ReLoad()
        {
            InitializeComponent();

            chooseColorToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aColor.ActionPerformed(s, e));
            widthToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aWidth.ActionPerformed(s, e));
            typeToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aType.ActionPerformed(s, e));
            saveAsToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aSave.ActionPerformed(s, e));
            browseToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aLoad.ActionPerformed(s, e));
            fontToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aTxtFont.ActionPerformed(s, e));
            changeColorToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aTxtColor.ActionPerformed(s, e));
            textAlignToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aTxtAlign.ActionPerformed(s, e));
            textDirectionToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aTxtAngle.ActionPerformed(s, e));
            changeTextToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aSetText.ActionPerformed(s, e, toolStripTextBox1.Text.ToString()));
            addToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aAddDoc.ActionPerformed(s, e));
            deleteToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aDeleteDoc.ActionPerformed(s, e));
            tabToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aTabFind.ActionPerformed(s, e));
            languageToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aLanguage.ActionPerformed(s, e));
        }
    }
}
