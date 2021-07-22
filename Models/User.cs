using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEP3_Tier1.Models
{
    /// <summary>
    /// This class holds the information of the user that is logged in, such as id, username, password and securityLevel.
    /// </summary>
    [Serializable]
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public int id { get; set; }
        public int securityLevel { get; set; }

        public User() { }

        public User(int id, string username, string password, int securityLevel)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.securityLevel = securityLevel;
        }
    }
}
