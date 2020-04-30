using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DODO_Pitsa.Modules
{
    class Methods
    {
        public class GlobalVars
        {

            public struct AuthData
            {
                public int u_id;
                public string name;
                public string login;
                public string pass;
                public string addr;
                public string phone;
            }
            public static AuthData[] arr = new AuthData[20];
            public static int uid = 0;
            public static int auth_id;

            public struct OrderData
            {
                public int order_id;
                public int u_id;
                public string fio;
                public string cost;
                
            }
            public static OrderData[] orders = new OrderData[20];
            public static int oid = 0;
        }
    }

}
