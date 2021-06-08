using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement_System
{
    public static class StaffList
    {
        public static List<Account> staffAccounts = new List<Account>();

        //Add account to the list
        public static void AddAccount(Account account)
        {
            staffAccounts.Add(account);
        }

        //Return requested account
        public static Account ReturnAccount(string accID)
        {
            List<Account> example = new List <Account>();

            foreach (Account account in staffAccounts)
            {
                if (account.id == accID)
                {
                    return account;
                }
            }

            return null;
        }
    }
}
