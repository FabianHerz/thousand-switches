using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thousand_switches
{
    class Switch : Network
    {
        String Name, IP;
        int RouterNumber, SwitchNumber;

        public Switch(string Name, string IP, int RouterNumber, int SwitchNumber)
        {
            this.Name = Name;
            this.IP = IP;
            this.RouterNumber = RouterNumber;
            this.SwitchNumber = SwitchNumber;
        }

        public NetworcStruct AddSwitch(NetworcStruct NS)
        {
            NS.SW_List.Add(this);
            return NS;
        }
    }
}
