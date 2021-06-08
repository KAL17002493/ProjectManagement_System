using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement_System
{
    public static class Authenticator
    {
        public static bool Authenticate(Account a, string pin)
        {
            if (a.PIN == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
