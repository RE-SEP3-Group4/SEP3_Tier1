using SEP3_Tier1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SEP3_Tier1.Data
{
    public class ReservationService
    {
        /// <summary>
        /// This method gets the reservations for a specific user.
        /// </summary>
        /// <param name="userID">This is the id of the user who we are tring to get the reservations.</param>
        /// <returns>A list of reservations.</returns>
        public static async Task<List<Reservation>> GetReservations(int userID)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().GetAsync("/user?userID=" + userID))
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
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().PostAsJsonAsync("/user?userID=" + userID + "&date=" + date, ""))
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
