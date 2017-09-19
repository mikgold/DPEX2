using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.EX01
{
    class ObserverUserStatus : ObservedUser
    {
        public ObservedUser m_observerdUser;
        public string update()
        {
            return m_observerdUser.getStatus.ToString();
        }
    }
}
