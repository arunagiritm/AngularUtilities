using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAngularFactoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAngularFactories ofrmAngularFactories = new frmAngularFactories();
            ofrmAngularFactories.Show(this);
            
        }

        private void createJasmineTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJasmine ofrmJasmine = new frmJasmine();
            ofrmJasmine.Show(this);
            
        }
    }
}
