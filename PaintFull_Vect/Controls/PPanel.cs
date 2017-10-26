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
    public partial class PPanel : UserControl
    {
        XCommand xcom;
        PTabData childTab;
        int createdTab = 1; 
        public PPanel()
        {
            xcom = new XCommand();
            xcom.panel = this;

            InitializeComponent();

            pMenu1.xcom = xcom;
            pToolStrip1.xcom = xcom;
            pColor1.xcom = xcom;
            pWidth1.xcom = xcom;
            pType1.xcom = xcom;
            textBar1.xcom = xcom;
            pStatusStrip1.xcom = xcom;
            pStatusStrip1.xcom.CoordsChanged += pStatusStrip1.PointListener;
            xcom.pTab = tabControl1;

        }
        public void AddDoc()
        {
            childTab = new PTabData(createdTab, tabControl1, xcom);
            xcom.childTab = childTab;
            
            tabControl1.SelectTab(childTab);                
            createdTab++;
            ToolStripMenuItem newMenuTab = new ToolStripMenuItem();
            newMenuTab.Text = childTab.Text;                    
            newMenuTab.Name = childTab.Name;
            pMenu1.tabToolStripMenuItem.DropDownItems.Add(newMenuTab);

            newMenuTab.Click += new EventHandler(TabFind);
        }
        public void AddDoc(String name)
        {
            childTab = new PTabData(createdTab, tabControl1, xcom);
            xcom.childTab = childTab;
            xcom.childTab.Name = name;
            xcom.childTab.Text = name;

            tabControl1.SelectTab(childTab);
            createdTab++;
            ToolStripMenuItem newMenuTab = new ToolStripMenuItem();
            newMenuTab.Text = childTab.Text;
            newMenuTab.Name = childTab.Name;
            pMenu1.tabToolStripMenuItem.DropDownItems.Add(newMenuTab);

            newMenuTab.Click += new EventHandler(TabFind);
        }
        public void DeleteDoc()
        {
            pMenu1.tabToolStripMenuItem.DropDownItems.RemoveByKey(tabControl1.SelectedTab.Name);
            tabControl1.SelectedTab.Dispose();

        }
        public void TabFind(object sender, EventArgs e)
        {
            foreach (TabPage theTab in tabControl1.TabPages)
            {
                if (theTab.Text == sender.ToString())
                {
                    tabControl1.SelectTab(theTab);
                }
            }
        }

        public List<PFigure> Figures {
            get {
                List<PFigure> list = new List<PFigure>();
                foreach (Control figure in xcom.childTab.pDraw.GetPictureBox().Controls)
                {
                    list.Add((figure as PFigure));
                }
                return list;
            }
            set {
                xcom.childTab.pDraw.GetPictureBox().Controls.Clear();
                foreach (PFigure figure in value)
                {
                    xcom.childTab.pDraw.GetPictureBox().Controls.Add(figure);
                }
            }
        }


    }
}
