using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace DP.EX01
{
    public interface IStrategy
    {
        string Name { get;  }
        int DoOperation(User i_friend1, User i_friend2);
    }
}
