using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public class UserLog
    {
        private User m_user;
        public User User { get { return m_user; } set { m_user = value; } }

        private DateTime m_changeTime;
        public DateTime ChangeTime { get { return m_changeTime; } set { m_changeTime = value; } }

        public UserLog(User i_user)
        {
            this.User = i_user;
            this.ChangeTime = DateTime.Now;
        }
    }
}
