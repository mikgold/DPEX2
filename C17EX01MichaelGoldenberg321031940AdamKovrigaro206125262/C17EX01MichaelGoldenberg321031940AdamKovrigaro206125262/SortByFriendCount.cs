using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    class SortByFriendCount : IStrategy
    {
        private string m_name = "Sort by friends count";
        public string Name { get { return m_name; } }
        public int DoOperation(User i_Friend1, User i_Friend2)
        {
            if (i_Friend1.Friends.Count() < i_Friend2.Friends.Count())
            {
                return -1;
            }
            else
            {
                if (i_Friend1.Friends.Count() == i_Friend2.Friends.Count())
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
