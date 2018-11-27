using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thousand_switches
{
    public class Router 
    {
        public String Name, IP;
        public int row, column;
        public List<object> list_connect = new List<object>();
        public Router()
        {

        }
        public Router(string Name, string IP)
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
