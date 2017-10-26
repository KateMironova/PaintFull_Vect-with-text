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
    public partial class PSave : UserControl
    {
        public XCommand xcom { get; set; }
        public PSave()
        {
            InitializeComponent();

            btnSave.Click += new EventHandler((s, e) => xcom.aSave.ActionPerformed(s, e));
        }
    }
}
