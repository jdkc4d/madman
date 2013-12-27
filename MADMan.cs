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
            NewMADForm.MdiParent = this;
            NewMADForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MadConfig NewConfig = new MadConfig();
            NewConfig.MdiParent = this;
            NewConfig.Show();
        }

        private void queueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAD_Work_Queue NewQueue = new MAD_Work_Queue();
            NewQueue.MdiParent = this;
            NewQueue.Show();
        }
    }
}
