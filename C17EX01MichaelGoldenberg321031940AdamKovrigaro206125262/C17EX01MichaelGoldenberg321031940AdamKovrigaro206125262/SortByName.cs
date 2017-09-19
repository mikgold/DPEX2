using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    class SortByName : IStrategy
    {
        private string m_name = "Sort by name";
        public string Name { get { return m_name; } }
        public int DoOperation(User i_Friend1,User i_Friend2)
        {

            return string.Compare(i_Friend1.Name, i_Friend2.Name);
        }
    }
}
