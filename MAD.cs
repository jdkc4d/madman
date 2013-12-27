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
    public partial class MAD : Form
    {
        public MAD()
        {
            InitializeComponent();
        }

        private void tb_MoveUsername_Leave(object sender, EventArgs e)
        {
            //On leave, check for content and search. If empty, replace the "username" text
            if (tb_MoveUsername.Text == "") tb_MoveUsername.Text = "Username";
            else
            {
                //Otherwise search the tree for the user, and specify the location in the group box
            }
        }
    }
}
