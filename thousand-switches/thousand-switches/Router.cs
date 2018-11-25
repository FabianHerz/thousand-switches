using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thousand_switches
{
    class Router : Network
    {
        String Name, IP;
        int RouterNumber;

        public Router(string Name, string IP, int RouterNumber)
        {
            this.Name = Name;
            this.IP = IP;
            this.RouterNumber = RouterNumber;
        }

    }
}
