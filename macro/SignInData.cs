using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace macro
{
    class SignInData
    {
        private string userId;
        private string userPw;

        public string getUserID()
        {
            return userId;
        }

        public void setUserID(string inputUserID)
        {
            userId = inputUserID;
        }

        public string getUserPW()
        {
            return userPw;
        }

        public void setUserPw(string inputUserPW)
        {
            userPw = inputUserPW;
        }
    }
}
