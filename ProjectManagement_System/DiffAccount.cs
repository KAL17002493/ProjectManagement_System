using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement_System
{
    public abstract class DiffAccount
    {
        public string fname;
        public string lname;
        public string email;

        public DiffAccount(string fname, string lname, string email)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
        }
    }
}
