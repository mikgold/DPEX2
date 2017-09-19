using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    class SortByBirthday : IStrategy
    {
        private string m_name = "Sort by birthday";
        public string Name { get { return m_name; } }
        public int DoOperation(User i_Friend1, User i_Friend2)
        {
            return (string.Compare(i_Friend1.Birthday, i_Friend2.Birthday));
        }
    }
}
