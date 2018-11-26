using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thousand_switches
{
    class Network
    {

        List<NetworcStruct> NS;

       // CREATE NETWORK STRUCTURE BY MARIIA.
        public Network()
        {         
            NS = new List<NetworcStruct>();
        }

        // FIELDS OF STUCTURE: ROUTER, LIST OF HIS SWITCHES AND PC BY MARIIA.
        public struct NetworcStruct
        {
           public Router R;
           public  List<Switch> SW_List;
           public List<PC> PC_List;
           
            public NetworcStruct(Router R_, List <Switch> SW_, List<PC> PC_)
            {
                R = R_;
                SW_List = SW_ ;
                PC_List = PC_;
            }

        }

        // METHOD ADD BY MARIIA.
        public void AddEquipmentInStruct(string Equipment, string Name , string IP ,int RouterNumber, int SwitchNumber)
        {         
            switch (Equipment)
            {
                case "Router":
                    Router R = new Router(Name, IP, RouterNumber);                
                    NS.Add( R.AddRouter());
                    break;
                    // TODO проверить, что создан роутер для данного свича
                case "Switch":
                    Switch SW = new Switch(Name, IP, RouterNumber, SwitchNumber);
                    NS[RouterNumber] = SW.AddSwitch(NS.ElementAt(RouterNumber));               
                    break;
                case "PC":
                    PC P = new PC(Name, IP, RouterNumber, SwitchNumber);
                    NS[RouterNumber] = P.AddPC(NS[RouterNumber]);
                    break;
            }

        }

       

        
    
    }
}
