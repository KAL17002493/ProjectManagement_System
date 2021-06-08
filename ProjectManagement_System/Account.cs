using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement_System
{
    public class Account : DiffAccount
    {
        private string password; //pin
        public string id; //accountNo
        //public SupportStaff accountUser; //customer

        public string role;
        public string name;


        public Account(string fname, string lname, string email, string Role) : base(fname, lname, email)
        {
            this.email = email;
            this.role = Role;

            this.name = $"{fname} {lname}";

            this.password = "0000";
            this.id = fname + lname;
        
        }

        public string PIN
        {
            get { return password; }
            set { password = value; }
        }
    }
}
