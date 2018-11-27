using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thousand_switches
{
    public class Switch 
    {
        public String Name, IP;
        public List<object> list_connect = new List<object>();
        public int row, column;

        public Switch()
        {

        }

        public Switch(string Name, string IP)
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
