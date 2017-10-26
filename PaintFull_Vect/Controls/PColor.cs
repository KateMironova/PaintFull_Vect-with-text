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
    public partial class PColor : UserControl
    {
        public XCommand xcom { get; set; }
        public PColor()
        {
            InitializeComponent();

            btnColor.Click += new EventHandler((s, e) => xcom.aColor.ActionPerformed(s, e));

        }
    }
}
