using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement_System
{
    public static class AccountManagement
    {
        public static List<Account> accountA = new List<Account>();

        //Add account to the list
        public static void AddAccount(Account account)
        {
            accountA.Add(account);
        }

        //Return requested account
        public static Account ReturnAccount(string accID)
        {
            List <Account> example = new List <Account>();

            foreach (Account account in accountA)
            {
                if (account.id == accID)
                {
                    return account;
                }
                continue;
            }

            return null;
        }
    }
}
