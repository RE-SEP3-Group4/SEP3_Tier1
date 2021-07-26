using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEP3_Tier1.Models;

namespace Authentication
{
    public class UserService 
    {
        public static User user = null;

        public static User GetUser() => user;

        public static void SetUser(User input)
        {
            user = input;
        }
    }
}
