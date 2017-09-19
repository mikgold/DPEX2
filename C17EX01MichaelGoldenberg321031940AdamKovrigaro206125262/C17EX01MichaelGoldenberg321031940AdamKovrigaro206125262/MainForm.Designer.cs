namespace DP.EX01
{
    public partial class MainForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblConnect = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelPleaseLogin = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageLikeStats = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.checkBoxPrimaryApp = new System.Windows.Forms.CheckBox();
            this.basicOptionsUserControl1 = new DP.EX01.BasicOptionsUserControl();
            this.knowYourFriendsGameUserControl = new DP.EX01.KnowYourFriendsGameUserControl();
            this.likedYourPostTheMostControl = new DP.EX01.LikedYourPostTheMost();
            this.checkInUserControl2 = new DP.EX01.CheckInUserControl();
            this.checkInUserControl1 = new DP.EX01.CheckInUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPageLikeStats.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(13, 13);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.ForeColor = System.Drawing.Color.Crimson;
            this.lblConnect.Location = new System.Drawing.Point(103, 18);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(73, 13);
            this.lblConnect.TabIndex = 1;
            this.lblConnect.Text = "Disconnected";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(723, 22);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPageLikeStats);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(13, 89);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(980, 610);
            this.tabControl.TabIndex = 3;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelPleaseLogin);
            this.tabPage1.Controls.Add(this.basicOptionsUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelPleaseLogin
            // 
            this.labelPleaseLogin.AutoSize = true;
            this.labelPleaseLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPleaseLogin.Location = new System.Drawing.Point(207, 252);
            this.labelPleaseLogin.Name = "labelPleaseLogin";
            this.labelPleaseLogin.Size = new System.Drawing.Size(389, 25);
            this.labelPleaseLogin.TabIndex = 5;
            this.labelPleaseLogin.Text = "You Have to login to use these goodies";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.knowYourFriendsGameUserControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Know Your Friends Game";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPageLikeStats
            // 
            this.tabPageLikeStats.Controls.Add(this.likedYourPostTheMostControl);
            this.tabPageLikeStats.Location = new System.Drawing.Point(4, 22);
            this.tabPageLikeStats.Name = "tabPageLikeStats";
            this.tabPageLikeStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLikeStats.Size = new System.Drawing.Size(972, 584);
            this.tabPageLikeStats.TabIndex = 2;
            this.tabPageLikeStats.Text = "Who liked your posts the most? (takes time)";
            this.tabPageLikeStats.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkInUserControl2);
            this.tabPage3.Controls.Add(this.checkInUserControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(972, 584);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Check In Builder";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(12, 60);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // checkBoxPrimaryApp
            // 
            this.checkBoxPrimaryApp.AutoSize = true;
            this.checkBoxPrimaryApp.Location = new System.Drawing.Point(13, 37);
            this.checkBoxPrimaryApp.Name = "checkBoxPrimaryApp";
            this.checkBoxPrimaryApp.Size = new System.Drawing.Size(353, 17);
            this.checkBoxPrimaryApp.TabIndex = 5;
            this.checkBoxPrimaryApp.Text = "connect to secondary app (with more friends) to use the game feature";
            this.checkBoxPrimaryApp.UseVisualStyleBackColor = true;
            // 
            // basicOptionsUserControl1
            // 
            this.basicOptionsUserControl1.Location = new System.Drawing.Point(7, 7);
            this.basicOptionsUserControl1.Name = "basicOptionsUserControl1";
            this.basicOptionsUserControl1.Size = new System.Drawing.Size(986, 571);
            this.basicOptionsUserControl1.TabIndex = 1;
            // 
            // knowYourFriendsGameUserControl
            // 
            this.knowYourFriendsGameUserControl.Location = new System.Drawing.Point(6, 6);
            this.knowYourFriendsGameUserControl.Name = "knowYourFriendsGameUserControl";
            this.knowYourFriendsGameUserControl.Size = new System.Drawing.Size(776, 608);
            this.knowYourFriendsGameUserControl.TabIndex = 0;
            // 
            // likedYourPostTheMostControl
            // 
            this.likedYourPostTheMostControl.Location = new System.Drawing.Point(7, 19);
            this.likedYourPostTheMostControl.Name = "likedYourPostTheMostControl";
            this.likedYourPostTheMostControl.Size = new System.Drawing.Size(777, 531);
            this.likedYourPostTheMostControl.TabIndex = 0;
            // 
            // checkInUserControl2
            // 
            this.checkInUserControl2.Location = new System.Drawing.Point(47, 28);
            this.checkInUserControl2.Name = "checkInUserControl2";
            this.checkInUserControl2.Size = new System.Drawing.Size(330, 152);
            this.checkInUserControl2.TabIndex = 1;
            // 
            // checkInUserControl1
            // 
            this.checkInUserControl1.Location = new System.Drawing.Point(4, 17);
            this.checkInUserControl1.Name = "checkInUserControl1";
            this.checkInUserControl1.Size = new System.Drawing.Size(584, 514);
            this.checkInUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 704);
            this.Controls.Add(this.checkBoxPrimaryApp);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.lblConnect);
            this.Controls.Add(this.btnLogin);
            this.Name = "MainForm";
            this.Text = "Facebook Demo App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPageLikeStats.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageLikeStats;
        private System.Windows.Forms.Button buttonLogOut;
        private LikedYourPostTheMost likedYourPostTheMostControl;
        private KnowYourFriendsGameUserControl knowYourFriendsGameUserControl;
        private BasicOptionsUserControl basicOptionsUserControl1;
        private System.Windows.Forms.Label labelPleaseLogin;
        private System.Windows.Forms.CheckBox checkBoxPrimaryApp;
        private System.Windows.Forms.TabPage tabPage3;
        private CheckInUserControl checkInUserControl1;
        private CheckInUserControl checkInUserControl2;
    }
}
