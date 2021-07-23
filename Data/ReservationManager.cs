using SEP3_Tier1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SEP3_Tier1.Data
{
    public class ReservationManager
    {
        private static readonly string url = "http://localhost:8080";

        /// <summary>
        /// This method gets the reservations for a specific user.
        /// </summary>
        /// <param name="userID">This is the id of the user who we are tring to get the reservations.</param>
        /// <returns>A list of reservations.</returns>
        public static async Task<List<Reservation>> GetReservations(int userID)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"{url}/reservation?userID={userID}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Reservation>>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// This method creates reservations.
        /// </summary>
        /// <param name="userID">The id of the user that is going to use the reservation.</param>
        /// <param name="date">Date is integer with the ddmmyyhhmm format</param>
        /// <returns>A boolean that is true if the command was successful.</returns>
        public static async Task<bool> CreateReservation(int userID, int date)
        {
            Reservation reservation = new Reservation(userID, date);
            string jsonReservation = Newtonsoft.Json.JsonConvert.SerializeObject(reservation);
            StringContent content = new StringContent(jsonReservation, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync($"{url}/reservation", content))
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
