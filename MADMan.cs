using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADManager
{
    public partial class MADMan : Form
    {
        public MADMan()
        {
            InitializeComponent();
        }

        private void moveAddDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {//Start MAD Form
            MAD NewMADForm = new MAD();
            NewMADForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
