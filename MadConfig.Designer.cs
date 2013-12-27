namespace MADManager
{
    partial class MadConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_DomainName = new System.Windows.Forms.TextBox();
            this.lbl_DomainName = new System.Windows.Forms.Label();
            this.gb_Identity = new System.Windows.Forms.GroupBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Verify = new System.Windows.Forms.Button();
            this.gb_Identity.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This page will pull info from a config file, or allow a config file to be created" +
    "/modified via a form.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Allow user to select OU\'s that are accessible to this program";
            // 
            // tb_DomainName
            // 
            this.tb_DomainName.Location = new System.Drawing.Point(94, 33);
            this.tb_DomainName.Name = "tb_DomainName";
            this.tb_DomainName.Size = new System.Drawing.Size(190, 20);
            this.tb_DomainName.TabIndex = 2;
            // 
            // lbl_DomainName
            // 
            this.lbl_DomainName.AutoSize = true;
            this.lbl_DomainName.Location = new System.Drawing.Point(8, 36);
            this.lbl_DomainName.Name = "lbl_DomainName";
            this.lbl_DomainName.Size = new System.Drawing.Size(80, 13);
            this.lbl_DomainName.TabIndex = 3;
            this.lbl_DomainName.Text = "Domain Name: ";
            // 
            // gb_Identity
            // 
            this.gb_Identity.Controls.Add(this.btn_Verify);
            this.gb_Identity.Controls.Add(this.tb_Password);
            this.gb_Identity.Controls.Add(this.lbl_Password);
            this.gb_Identity.Controls.Add(this.tb_Username);
            this.gb_Identity.Controls.Add(this.lbl_UserName);
            this.gb_Identity.Controls.Add(this.tb_DomainName);
            this.gb_Identity.Controls.Add(this.lbl_DomainName);
            this.gb_Identity.Location = new System.Drawing.Point(13, 13);
            this.gb_Identity.Name = "gb_Identity";
            this.gb_Identity.Size = new System.Drawing.Size(314, 171);
            this.gb_Identity.TabIndex = 4;
            this.gb_Identity.TabStop = false;
            this.gb_Identity.Text = "Identity";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(8, 71);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(66, 13);
            this.lbl_UserName.TabIndex = 4;
            this.lbl_UserName.Text = "User Name: ";
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(94, 68);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(190, 20);
            this.tb_Username.TabIndex = 5;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(8, 105);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(59, 13);
            this.lbl_Password.TabIndex = 6;
            this.lbl_Password.Text = "Password: ";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(94, 102);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(190, 20);
            this.tb_Password.TabIndex = 7;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // btn_Verify
            // 
            this.btn_Verify.Location = new System.Drawing.Point(209, 142);
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.Size = new System.Drawing.Size(75, 23);
            this.btn_Verify.TabIndex = 8;
            this.btn_Verify.Text = "Verify";
            this.btn_Verify.UseVisualStyleBackColor = true;
            this.btn_Verify.Click += new System.EventHandler(this.btn_Verify_Click);
            // 
            // MadConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 631);
            this.Controls.Add(this.gb_Identity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MadConfig";
            this.Text = "MAD Configuration Editor";
            this.Load += new System.EventHandler(this.MadConfig_Load);
            this.gb_Identity.ResumeLayout(false);
            this.gb_Identity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_DomainName;
        private System.Windows.Forms.Label lbl_DomainName;
        private System.Windows.Forms.GroupBox gb_Identity;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Button btn_Verify;
    }
}