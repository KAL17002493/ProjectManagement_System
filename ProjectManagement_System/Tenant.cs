using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement_System
{
    public class Tenant : DiffAccount
    {
        public string phone;

        public Tenant(string fname, string lname, string email, string Phone) : base(fname, lname, email)
        {
            this.phone = Phone;
        }
    }
}
