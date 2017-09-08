using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP.EX01
{
    public partial class LikedYourPostTheMost : UserControl
    {
        #region Like Stats Tab

        private void fetchLikeStats()
        {
            Dictionary<string, int> dicLikeStats = FacebookUtilities.GetLikeStatistics();
            var sortedDict = from entry in dicLikeStats orderby entry.Value descending select entry;

            foreach (KeyValuePair<string, int> friend in sortedDict)
            {
                listBoxMostLikesFriends.Items.Add(friend.Key + string.Format("  likes count:({0})", friend.Value));
            }

            if (dicLikeStats.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }
        #endregion

        public LikedYourPostTheMost()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            fetchLikeStats();
        }
    }
}
