using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace DP.EX01
{
    public partial class CheckInUserControl : UserControl
    {
        public CheckInUserControl()
        {
            InitializeComponent();
            pictureBox1.LoadAsync("https://scontent.fhfa2-1.fna.fbcdn.net/v/t1.0-9/16711881_1109943625801657_5707778191887488709_n.jpg?oh=7d5e507de60b0c1920b9cdbda9385cb7&oe=5A4976C4");
            pictureBox2.LoadAsync("https://scontent.fhfa2-1.fna.fbcdn.net/v/t31.0-8/14311394_963505157112172_8975619934356712344_o.jpg?oh=93d56b5012d436b0973ae84d96aade62&oe=5A581ECB");
            pictureBox3.LoadAsync("https://scontent.fhfa2-1.fna.fbcdn.net/v/t31.0-8/14305262_963504830445538_3574468904038292657_o.jpg?oh=f1040e4627e51a3b30ed388e31f98858&oe=5A56D7EF");
            radioButton1.Tag = pictureBox1;
            radioButton2.Tag = pictureBox2;
            radioButton3.Tag = pictureBox3;
        }

        public void BindData()
        {            
            new Thread(loadFriendImages).Start();    
        }

        private void loadFriendImages()
        {
            labelNotEnoughFriends.Invoke(new Action(() => labelNotEnoughFriends.Visible = false));
            panelCheckBox.Invoke(new Action(() => panelCheckBox.Enabled = false));
            
            User user1 = FacebookUtilities.LoggedInUser.Friends.Find(new Predicate<FacebookWrapper.ObjectModel.User>((user) => user.Name == "Desigi Pat"));
            if (user1 == null)
            {
                labelNotEnoughFriends.Invoke(new Action(() => labelNotEnoughFriends.Visible = true));
                panelCheckBox.Invoke(new Action(() => panelCheckBox.Enabled = false));
                string emptyPictureUrl = "https://i.imgur.com/XqQBCA3.jpg";
                checkBox1.Invoke(new Action(() => checkBox1.Text = ""));
                checkBox2.Invoke(new Action(() => checkBox2.Text = ""));
                checkBox3.Invoke(new Action(() => checkBox3.Text = ""));
                pictureBox4.Invoke(new Action(() => pictureBox4.Load(emptyPictureUrl)));
                pictureBox5.Invoke(new Action(() => pictureBox5.Load(emptyPictureUrl)));
                pictureBox6.Invoke(new Action(() => pictureBox6.Load(emptyPictureUrl)));
            }
            else
            {
                User user2 = FacebookUtilities.LoggedInUser.Friends.Find(new Predicate<FacebookWrapper.ObjectModel.User>((user) => user.Name == "Desig Onn"));
                User user3 = FacebookUtilities.LoggedInUser.Friends.Find(new Predicate<FacebookWrapper.ObjectModel.User>((user) => user.Name == "Dov Kuala"));

                panelCheckBox.Invoke(new Action(() => panelCheckBox.Enabled = true));
                labelNotEnoughFriends.Invoke(new Action(() => labelNotEnoughFriends.Visible = false));
                checkBox1.Invoke(new Action(() => checkBox1.Text = "Desigi Pat"));
                checkBox2.Invoke(new Action(() => checkBox2.Text = "Desig Onn"));
                checkBox3.Invoke(new Action(() => checkBox3.Text = "Dov Kuala"));
                pictureBox4.Invoke(new Action(() => pictureBox4.Load(user1.PictureNormalURL)));
                pictureBox5.Invoke(new Action(() => pictureBox5.Load(user2.PictureNormalURL)));
                pictureBox6.Invoke(new Action(() => pictureBox6.Load(user3.PictureNormalURL)));
            }
        }

        private void buttonSumbit_Click(object sender, EventArgs e)
        {
            CheckInBuilder builder = new CheckInBuilder();
            RadioButton selectedRadio = panelRadios.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            List<string> selectedFriendsNames = panelCheckBox.Controls.OfType<CheckBox>()
                                      .Where(r => r.Checked).Select(r => r.Text).ToList<string>();
            Checkin checkIn = builder.
                PlaceId(comboBoxLocations.SelectedItem != null ? comboBoxLocations.SelectedItem.ToString() : null).
                Message(textBoxMessage.Text).
                Link(textBoxLink.Text).
                PicutreUrl(selectedRadio != null ? (selectedRadio.Tag as PictureBox).ImageLocation : null).
                TaggedFriendsNames(selectedFriendsNames).
                Build();
            
            if (checkIn == null)
            {
                MessageBox.Show("You must select a place");
            }
            else
            {
                MessageBox.Show("Checked in Succesfully");
            }            
        }
    }
}
