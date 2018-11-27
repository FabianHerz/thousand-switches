using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thousand_switches
{
    public class PC 
    {
        public String Name, IP;
        public int row, column;


        public PC(string Name, string IP)
        {
            this.Name = Name;
            this.IP = IP;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
