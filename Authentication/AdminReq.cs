using Microsoft.AspNetCore.Authorization;
using SEP3_Tier1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using SEP3_Tier1.Authentication;
namespace SEP3_Tier1.Authentication
{
    public class AdminReq : IAuthorizationRequirement
    {
        
        public User user = UserService.GetUser();
        public AdminReq(string username)
        {
            username = user.username;
        }

    }
}
