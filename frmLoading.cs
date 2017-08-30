using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SATeC
{
    public partial class frmLoading : Form
    {
        Timer tmr;

        public frmLoading()
        {
            InitializeComponent();
        }
        private void frmLoading_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 60000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
        }
        private void frmLoading_Load(object sender, EventArgs e)
        {
        }
    }
}
