using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    abstract class AbstractObserverUser : User
    {
        protected ObservedUser m_observerdUser;
        public abstract void update();
    }
}
