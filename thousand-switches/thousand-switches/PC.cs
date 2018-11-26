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
        int SwitchNumber, RouterNumber;

        List<PC> PCList = new List<PC>();
        public PC(string Name, string IP, int RouterNumber, int SwitchNumber)
        {
            this.Name = Name;
            this.IP = IP;
            this.SwitchNumber = SwitchNumber;
            this.RouterNumber = RouterNumber;
        }

        public NetworcStruct AddPC(NetworcStruct NS)
        {
            NS.PC_List.Add(this);
            return NS;
        }

    }
}
