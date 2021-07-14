using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SEP3_Tier1.Models;

namespace SEP3_Tier1.Data
{
    /// <summary>
    /// This is class is used for communicating with the second tier.
    /// It has all the methods to communicate with the Web Service.
    /// </summary>
    public class GymService
    {
        /// <summary>
        /// Allows the user to login.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>A user object if the login is successful.</returns>
        public static async Task<User> login(string username, string password)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().GetAsync("/user?username=" + username + "&password=" + password))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<User>();
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
        public static async Task<bool> register(string username, string password)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().PostAsJsonAsync("/user?username=" + username + "&password=" + password, ""))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<bool>();
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
        public static async Task<bool> updateUser(int id, string username, string password)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().PutAsJsonAsync("/user?username=" + username + "&password=" + password + "&id=" + id, ""))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<bool>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
