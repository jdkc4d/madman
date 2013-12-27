using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace MADManager
{
    public partial class MadConfig : Form
    {
        public MadConfig()
        {
            InitializeComponent();
        }

        private void MadConfig_Load(object sender, EventArgs e)
        {
            //Get the local domain information from the currently logged in user
            tb_Username.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            tb_DomainName.Text = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            //Check that Password is not blank!
            if (tb_Password.Text == "") MessageBox.Show("The password box cannot be blank!", "Error", MessageBoxButtons.OK);
            else
            {
                //Verify the submitted credentials are correct
                PrincipalContext UserPC = new PrincipalContext(ContextType.Domain, tb_DomainName.Text);
                Boolean isValidCred = UserPC.ValidateCredentials(tb_Username.Text, tb_Password.Text);

                if (isValidCred) MessageBox.Show("Success!");
                else MessageBox.Show("Invalid Credenitals", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
