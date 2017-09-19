using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public partial class MainForm : Form
    {          
        public MainForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
            tabObserveFriendsBio.Enabled = false;
            buttonLogOut.Hide();     
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                knowYourFriendsGameUserControl.Enabled = true;
                this.BeginInvoke(new Action(knowYourFriendsGameUserControl.StartGame));
            }
            else if (e.TabPageIndex == 2)
            {
                this.BeginInvoke(new Action(likedYourPostTheMostControl.BindData));
            }
            else if (e.TabPageIndex == 3)
            {
                this.BeginInvoke(new Action(checkInUserControl1.BindData));
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            try
            {
                User loggedInUser = FacebookUtilities.LoginToFacebookApp(!checkBoxPrimaryApp.Checked);

                if (loggedInUser != null)
                {
                    fetchUserInfo();
                }
                else
                {
                    MessageBox.Show("Couldn't Loggin");
                }
            }
            catch
            {
                MessageBox.Show("Something wen't wrong in connection please try again later");
            }
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(FacebookUtilities.LoggedInUser.PictureNormalURL);
            lblConnect.Text = string.Format("Logged in as: {0}", FacebookUtilities.LoggedInUser.Name);
            lblConnect.ForeColor = Color.Green;
            lblConnect.Location = new Point(lblConnect.Location.X - 95, lblConnect.Location.Y);
            btnLogin.Hide();
            buttonLogOut.Show();
            tabObserveFriendsBio.Enabled = true;
            labelPleaseLogin.Hide();
            checkBoxPrimaryApp.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogOut()
        {
            FacebookUtilities.LogOut();
            lblConnect.Text = string.Format("Disconnected");
            lblConnect.ForeColor = Color.Red;
            lblConnect.Location = new Point(lblConnect.Location.X + 95, lblConnect.Location.Y);
            pictureBoxProfile.Image = null;
            tabObserveFriendsBio.Enabled = false;
            labelPleaseLogin.Show();
            btnLogin.Show();
            buttonLogOut.Hide();
            checkBoxPrimaryApp.Show();
            tabObserveFriendsBio.SelectedIndex = 0;
        }                
    }
}
