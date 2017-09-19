using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public partial class BasicOptionsUserControl : UserControl
    {
        public BasicOptionsUserControl()
        {
            InitializeComponent();
            pictureBoxSelectedFriend.LoadAsync("https://i.imgur.com/XqQBCA3.jpg");
        }

        #region First Tab Basic Options       

        private void fetchCheckins()
        {
            listBoxCheckIns.Invoke(new Action(() => listBoxCheckIns.Items.Clear()));
            foreach (Checkin checkin in FacebookUtilities.LoggedInUser.Checkins)
            {
                listBoxCheckIns.Invoke(new Action(() => listBoxCheckIns.Items.Add(checkin.Place.Name)));
            }

            if (FacebookUtilities.LoggedInUser.Checkins.Count == 0)
            {
                MessageBox.Show("No Checkins to retrieve :(");
            }
        }

        private void buttonCheckIns_Click(object sender, EventArgs e)
        {
            new Thread(fetchCheckins).Start();            
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status postedStatus = FacebookUtilities.LoggedInUser.PostStatus(textBoxPost.Text);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
        }

        private void buttonShowFreinds_Click(object sender, EventArgs e)
        {
            new Thread(fetchFriends).Start();
        }

        private void fetchFriends()
        {
            listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Clear()));
            listBoxFriends.Invoke(new Action(() => listBoxFriends.DisplayMember = "Name"));
            foreach (User friend in FacebookUtilities.LoggedInUser.Friends)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));
            }

            if (FacebookUtilities.LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItems.Count > 0)
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;
                pictureBoxSelectedFriend.LoadAsync(selectedFriend.PictureNormalURL);
                textBoxSelectedFriendName.Text = selectedFriend.Name;
                textBoxSelectedFriendBio.Text = selectedFriend.Bio ?? "No bio to show :(";
            }
        }

        private void buttonShowEvents_Click(object sender, EventArgs e)
        {
            new Thread(fetchEvents).Start();
        }

        private void fetchEvents()
        {
            listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Clear()));
            listBoxEvents.Invoke(new Action(() => listBoxEvents.DisplayMember = "Name"));
            foreach (Event fbEvent in FacebookUtilities.LoggedInUser.Events)
            {
                listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(fbEvent)));
            }

            if (FacebookUtilities.LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // FacebookUtilities.LogOut();
        }

        private void buttonShowPosts_Click(object sender, EventArgs e)
        {
            new Thread(fetchPosts).Start();
        }

        private void fetchPosts()
        {
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
            foreach (Post post in FacebookUtilities.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                }
                else
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                }
            }

            if (FacebookUtilities.LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            new Thread(fetchAlbums).Start();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Clear()));
            foreach (Album album in FacebookUtilities.LoggedInUser.Albums)
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(new AlbumDescriptionDecorator(album))));
            }

            if (FacebookUtilities.LoggedInUser.Albums.Count == 0)
            {
                MessageBox.Show("No Albumns to retrieve :(");
            }
        }

        #endregion

        private void textBoxSelectedFriendBio_Leave(object sender, EventArgs e)
        {
            User selectedFriend = listBoxFriends.SelectedItem as User;
            if (selectedFriend.Bio != textBoxSelectedFriendBio.Text)
            {
                selectedFriend.Bio = textBoxSelectedFriendBio.Text;
                FacebookUtilities.NotifyDel.Invoke(selectedFriend);
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count > 0)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                string eventInfo = new UserFacade().getFBObjectInfo(UserFacade.eFBObjectsTypes.Event, selectedEvent);
                richTextBoxSelectedEvent.Text = eventInfo;
                richTextBoxSelectedEventDescription.Text = selectedEvent.Description;
            }
        }

        private void richTextBoxSelectedEventDescription_Leave(object sender, EventArgs e)
        {
            (listBoxEvents.SelectedItem as Event).Description = richTextBoxSelectedEventDescription.Text;
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlbumDescriptionDecorator album = listBoxAlbums.SelectedItem as AlbumDescriptionDecorator;
            pictureBoxAlbums.LoadAsync(album.PictureSmallURL);
            labelLikesInAlbum.Text = "loading like count...";
            labelCreationAlbum.Text = album.CreationTimeDescription();

            new Thread(() =>
            {
                int likes = new LikesInAlbumCounterDecorator(album).LikesCount;
                labelLikesInAlbum.Invoke(new Action(() => { labelLikesInAlbum.Text = likes + " likes"; }));
            }).Start();

            new Thread(() =>
            {
                Photo mostLikedPhoto = new LikesInAlbumCounterDecorator(album).MostLikedPhoto();
                pictureBoxMostLikedPhoto.LoadAsync(mostLikedPhoto.PictureNormalURL);
            }).Start();
        }
    }
}
