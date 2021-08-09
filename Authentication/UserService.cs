using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEP3_Tier1.Models;

namespace SEP3_Tier1.Authentication
{
    public sealed class UserService 
    {
        private static UserService userService = null;
        private static User user;
        
        public UserService() { }

        public static UserService getInstance()
        {
            if (userService == null)
            {
                userService = new UserService();
            }
            return userService;
        }

        public User GetUser() => user;

        public void SetUser(User input)
        {
            user = input;
        }
    }
}
