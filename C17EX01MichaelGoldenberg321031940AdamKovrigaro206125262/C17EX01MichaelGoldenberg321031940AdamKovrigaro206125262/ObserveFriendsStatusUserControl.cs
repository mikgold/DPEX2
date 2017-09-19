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

namespace DP.EX01
{
    public partial class ObserveFriendsStatusUserControl : UserControl
    {
        private IStrategy[] strategies = { new SortByBirthday(), new SortFriendsByGender(), new SortByName()};

        public ObserveFriendsStatusUserControl()
        {
            InitializeComponent();
        }

        private void PopulateStrategies()
        {
            listBoxOrderMethod.Invoke(new Action(() => listBoxOrderMethod.Items.Clear()));
            listBoxOrderMethod.Invoke(new Action(() => listBoxOrderMethod.DisplayMember = "Name"));
            foreach (IStrategy strategy in strategies)
            {
                listBoxOrderMethod.Invoke(new Action(() => listBoxOrderMethod.Items.Add(strategy)));
            }
        }

        private void PopulateFriendsList(List<User> i_friendsList)
        {
            listBoxFriendsList.Invoke(new Action(() => listBoxFriendsList.Items.Clear()));
            listBoxFriendsList.Invoke(new Action(() => listBoxFriendsList.DisplayMember = "Name"));
            foreach (User friend in i_friendsList)
            {
                FacebookWrapper.ObjectModel.User.eRelationshipStatus er = (FacebookWrapper.ObjectModel.User.eRelationshipStatus)friend.RelationshipStatus;
                FacebookObjectCollection<Status> s = friend.Statuses; ;
                listBoxFriendsList.Invoke(new Action(() => listBoxFriendsList.Items.Add(friend)));
            }

            if (i_friendsList.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }
        private void listBoxOrderMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            IStrategy selectedStrategy = listBoxOrderMethod.SelectedItem as IStrategy;
            List<User> userFriends = FacebookUtilities.getOrderedFriendsList(selectedStrategy);
            PopulateFriendsList(userFriends);
        }

        private void buttonFetchMethods_Click(object sender, EventArgs e)
        {
            Task.Run(()=> { PopulateStrategies(); });
        }
    }
}
