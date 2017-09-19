using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public class ObservedUser : User
    {
        private List<User> m_observers = new List<User>();
        private eRelationshipStatus m_status;
        
        public ObservedUser()
        {
            if (base.RelationshipStatus != null)
            {
                this.m_status = (eRelationshipStatus)base.RelationshipStatus;
            }
            else
            {
                m_status = eRelationshipStatus.Single;
            }
        }

        public eRelationshipStatus getStatus()
        {
            return m_status;
        }

        public void setStatus(eRelationshipStatus i_status)
        {
            m_status = i_status;
            Notify();
        }

        public void Attach(User i_user)
        {
            m_observers.Add(i_user);
        }

        public void Dettach(User i_user)
        {
            m_observers.Remove(i_user);
        }

        public void Notify()
        {
            foreach (User observer in m_observers)
            {
                //observer.Update();
            }
        }
    }
}
