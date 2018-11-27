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
    public class Data
    {
        BinaryFormatter formatter = new BinaryFormatter();
        public static CurrentUser user =new CurrentUser();
        public static List<Admin> adminList = new List<Admin>();
        public static Network this_network;
        public static List<object> equipment_router;

        public static string DAT_FILE_PATH = "../../admin_list.dat";


        public static void getData()
        {
            adminList = getAdminList();
            user.user = CurrentUser.getData();
        }
        public static List<Admin> getAdminList()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            List<Admin> dat = new List<Admin>();
            if (File.Exists(DAT_FILE_PATH))
                using (FileStream fs = new FileStream(DAT_FILE_PATH, FileMode.OpenOrCreate))
                {
                    dat = (List<Admin>)formatter.Deserialize(fs);
                }
            return dat;

        }
        public static bool log_in(string email_or_username, string password)
        {
            foreach (Admin temp in adminList)
            {
                if (temp.email == email_or_username || temp.username == email_or_username)
                {
                    if (temp.password == password)
                    {
                        Data.user.user = temp;
                        return true;
                    }
                }
            }

            return false;
        }
        public static void addNewAdmin(Admin nn)
        {
   
            adminList.Add(nn);
            saveData();
        }
        public static  void saveData()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            File.Delete(DAT_FILE_PATH);

            using (FileStream fs = new FileStream(DAT_FILE_PATH, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, adminList);
            }
        }
    }
}
