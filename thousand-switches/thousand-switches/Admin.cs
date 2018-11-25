using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thousand_switches
{
    [Serializable]
    public class Admin
    {
        public string name;
        public string username;
        public string email;
        public string password;
        public Admin()
        {

        }

        public Admin(string name, string username,string email,string password)
        {
            this.name = name;
            this.username = username;
            this.email = email;
            this.password = password;
        }
        public string  toShow()
        {
            string styr= name + " " + username + " " + email + " " + password + "\n";
            return styr;
        }
    }
}
