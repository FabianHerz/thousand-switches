using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thousand_switches
{
    public class History
    {
        DateTime DT = new DateTime() ;
        String action = "", current_elem_name = "", connected_with_current_elem_mane = "";

        public History() { }
        public History(string action, string current_elem_name, string connected_with_current_elem_mane) {
            this.action = action;
            this.current_elem_name = current_elem_name;
            this.connected_with_current_elem_mane = connected_with_current_elem_mane;
            DT = DateTime.Now;
        }

        public override string ToString()
        {
            if (action.Equals("add"))
                return DT.ToString() + "        " + current_elem_name + " was connected to " + connected_with_current_elem_mane;
            else return DT.ToString() + "        " + current_elem_name + " has been disconected from " + connected_with_current_elem_mane;
        }



    }
}
