using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thousand_switches
{
    class PC : Network
    {
        String Name, IP;
        int SwitchNumber;
        public PC(string Name, string IP, int SwitchNumber)
        {
            this.Name = Name;
            this.IP = IP;
            this.SwitchNumber = SwitchNumber;
        }
    }
}
