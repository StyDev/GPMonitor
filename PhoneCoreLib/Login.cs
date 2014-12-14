using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCoreLib
{
    public class Login
    {
        public string username;
        public string password;
        public string email;

        public string Username
        {
            get { return username; }
            set { username = value; }

        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
