using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace project1
{

    public class NotifyFriends
     {
        public event Action<string> m_MessageFollowersDelegates;

        public void NotifyAll (string i_Message)
            {
                if (m_MessageFollowersDelegates != null)
                {
                    m_MessageFollowersDelegates.Invoke(i_Message);
                }
            }
        }
}
