using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace thousand_switches
{
    [Serializable]
    public class CurrentUser
    {

         public Admin user=getData();
        public static Admin getData()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists("./CurrentUaser.dat"))
                using (FileStream fs = new FileStream("./CurrentUser.dat", FileMode.OpenOrCreate))
                {
                    return (Admin)formatter.Deserialize(fs);

                }
            else return new Admin();
        }
        public void saveData()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("./CurrentUser.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this.user);

            }
        }
    }
}
