using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEP3_Tier1.Models;

namespace SEP3_Tier1.Data.Login
{
    public class UserService 
    {
        public static User user = null;

        public static User getUser() => user;

        public static void setUser(User input)
        {
            user = input;
        }
    }
}
