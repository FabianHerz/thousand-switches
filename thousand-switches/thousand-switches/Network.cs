using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thousand_switches
{
    public class Network
    {
        public Router main_router;

        public Network()
        {

        }
        public Network(Router router)
        {
            main_router = router;
            main_router.row = 1;
            main_router.column = 1;
        }
    }
}
