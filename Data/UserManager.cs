using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SEP3_Tier1.Models;
using SEP3_Tier1.Authentication;
using Newtonsoft.Json;

namespace SEP3_Tier1.Data
{
    /// <summary>
    /// This is class is used for the comunication with the second tier regarding the User class.
    /// </summary>
    public static class UserManager
    {
        private static readonly string url = "http://localhost:8080";

        /// <summary>
        /// Allows the user to login.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>A user object if the login is successful.</returns>
        public static async Task<User> Login(string username, string password)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"{url}/user?username={username}&password={password}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var user = JsonConvert.DeserializeObject<User>(json);
                    return user;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Allows the user to create an account.
        /// </summary>
        /// <param name="username">The new username of the user.</param>
        /// <param name="password">The new password of the user.</param>
        /// <returns>A boolean that is true if the command was successful.</returns>
        public static async Task<bool> Register(string username, string password)
        {
            User user = new User(0, username, password, 0);
            string jsonUser = Newtonsoft.Json.JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync($"{url}/user", content))
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var boolean = JsonConvert.DeserializeObject<bool>(json);
                    return boolean;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Allows the user to change the details of its own account.
        /// </summary>
        /// <param name="id">The id of the user that is changing its details.</param>
        /// <param name="username">The new/old username depending on the wishes of the user.</param>
        /// <param name="password">The new/old password depending on the wishes of the user.</param>
        /// <returns>A boolean that is true if the command was successful.</returns>
        public static async Task<bool> UpdateUser(int id, string username, string password)
        {
            User user = new User(id, username, password, 0);
            string jsonUser = Newtonsoft.Json.JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync($"{url}/user?id={id}", content))
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var boolean = JsonConvert.DeserializeObject<bool>(json);
                    return boolean;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<bool> DeleteUser(int id)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync($"{url}/user?id={id}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var boolean = JsonConvert.DeserializeObject<bool>(json);
                    return boolean;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<List<User>> GetAllUsers()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"{url}/users"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var users = JsonConvert.DeserializeObject<List<User>>(json);
                    return users;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
