namespace MADManager
{
    partial class MAD
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Add = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_delete = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_move = new System.Windows.Forms.TabPage();
            this.lbl_MoveToLocation = new System.Windows.Forms.Label();
            this.cb_MoveToOU = new System.Windows.Forms.ComboBox();
            this.gb_MoveUser = new System.Windows.Forms.GroupBox();
            this.lbl_MoveUsername = new System.Windows.Forms.Label();
            this.tb_MoveUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tp_Add.SuspendLayout();
            this.tp_delete.SuspendLayout();
            this.tp_move.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tp_Add);
            this.tabControl1.Controls.Add(this.tp_delete);
            this.tabControl1.Controls.Add(this.tp_move);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 327);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_Add
            // 
            this.tp_Add.Controls.Add(this.label1);
            this.tp_Add.Location = new System.Drawing.Point(4, 22);
            this.tp_Add.Name = "tp_Add";
            this.tp_Add.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Add.Size = new System.Drawing.Size(418, 301);
            this.tp_Add.TabIndex = 0;
            this.tp_Add.Text = "Add";
            this.tp_Add.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This tab to implement the addition of users ";
            // 
            // tp_delete
            // 
            this.tp_delete.Controls.Add(this.label2);
            this.tp_delete.Location = new System.Drawing.Point(4, 22);
            this.tp_delete.Name = "tp_delete";
            this.tp_delete.Padding = new System.Windows.Forms.Padding(3);
            this.tp_delete.Size = new System.Drawing.Size(418, 301);
            this.tp_delete.TabIndex = 1;
            this.tp_delete.Text = "Delete";
            this.tp_delete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "This tab to implement the deletion of users";
            // 
            // tp_move
            // 
            this.tp_move.Controls.Add(this.lbl_MoveToLocation);
            this.tp_move.Controls.Add(this.cb_MoveToOU);
            this.tp_move.Controls.Add(this.gb_MoveUser);
            this.tp_move.Controls.Add(this.lbl_MoveUsername);
            this.tp_move.Controls.Add(this.tb_MoveUsername);
            this.tp_move.Controls.Add(this.label3);
            this.tp_move.Location = new System.Drawing.Point(4, 22);
            this.tp_move.Name = "tp_move";
            this.tp_move.Padding = new System.Windows.Forms.Padding(3);
            this.tp_move.Size = new System.Drawing.Size(418, 301);
            this.tp_move.TabIndex = 2;
            this.tp_move.Text = "Move";
            this.tp_move.UseVisualStyleBackColor = true;
            // 
            // lbl_MoveToLocation
            // 
            this.lbl_MoveToLocation.AutoSize = true;
            this.lbl_MoveToLocation.Location = new System.Drawing.Point(7, 150);
            this.lbl_MoveToLocation.Name = "lbl_MoveToLocation";
            this.lbl_MoveToLocation.Size = new System.Drawing.Size(147, 13);
            this.lbl_MoveToLocation.TabIndex = 5;
            this.lbl_MoveToLocation.Text = "Choose new location for user:";
            // 
            // cb_MoveToOU
            // 
            this.cb_MoveToOU.FormattingEnabled = true;
            this.cb_MoveToOU.Location = new System.Drawing.Point(7, 166);
            this.cb_MoveToOU.Name = "cb_MoveToOU";
            this.cb_MoveToOU.Size = new System.Drawing.Size(121, 21);
            this.cb_MoveToOU.TabIndex = 4;
            // 
            // gb_MoveUser
            // 
            this.gb_MoveUser.Location = new System.Drawing.Point(196, 24);
            this.gb_MoveUser.Name = "gb_MoveUser";
            this.gb_MoveUser.Size = new System.Drawing.Size(200, 100);
            this.gb_MoveUser.TabIndex = 3;
            this.gb_MoveUser.TabStop = false;
            // 
            // lbl_MoveUsername
            // 
            this.lbl_MoveUsername.AutoSize = true;
            this.lbl_MoveUsername.Location = new System.Drawing.Point(7, 24);
            this.lbl_MoveUsername.Name = "lbl_MoveUsername";
            this.lbl_MoveUsername.Size = new System.Drawing.Size(172, 13);
            this.lbl_MoveUsername.TabIndex = 2;
            this.lbl_MoveUsername.Text = "Please enter the user to be moved:";
            // 
            // tb_MoveUsername
            // 
            this.tb_MoveUsername.Location = new System.Drawing.Point(7, 43);
            this.tb_MoveUsername.Name = "tb_MoveUsername";
            this.tb_MoveUsername.Size = new System.Drawing.Size(100, 20);
            this.tb_MoveUsername.TabIndex = 1;
            this.tb_MoveUsername.Text = "Username";
            this.tb_MoveUsername.Leave += new System.EventHandler(this.tb_MoveUsername_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "This tab to implement the movement of users";
            // 
            // MAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 351);
            this.Controls.Add(this.tabControl1);
            this.Name = "MAD";
            this.Text = "Move/Add/Delete";
            this.tabControl1.ResumeLayout(false);
            this.tp_Add.ResumeLayout(false);
            this.tp_Add.PerformLayout();
            this.tp_delete.ResumeLayout(false);
            this.tp_delete.PerformLayout();
            this.tp_move.ResumeLayout(false);
            this.tp_move.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Add;
        private System.Windows.Forms.TabPage tp_delete;
        private System.Windows.Forms.TabPage tp_move;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MoveToLocation;
        private System.Windows.Forms.ComboBox cb_MoveToOU;
        private System.Windows.Forms.GroupBox gb_MoveUser;
        private System.Windows.Forms.Label lbl_MoveUsername;
        private System.Windows.Forms.TextBox tb_MoveUsername;
        private System.Windows.Forms.Label label3;
    }
}