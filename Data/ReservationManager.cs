using Newtonsoft.Json;
using SEP3_Tier1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SEP3_Tier1.Data
{
    /// <summary>
    /// This is class is used for the comunication with the second tier regarding the Reservation class.
    /// </summary>
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
                    var json = await response.Content.ReadAsStringAsync();
                    var reservations = JsonConvert.DeserializeObject<List<Reservation>>(json);
                    return reservations;
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
        public static async Task<bool> CreateReservation(int userID, string date, string hour)
        {
            Reservation reservation = new Reservation(userID, date, hour);
            string jsonReservation = Newtonsoft.Json.JsonConvert.SerializeObject(reservation);
            var content = new StringContent(jsonReservation, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync($"{url}/reservation", content))
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

        public static async Task<bool> DeleteReservation(Reservation reservation)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync($"{url}/reservation?userID={reservation.userID}&date={reservation.date}&hour={reservation.hour}"))
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
    }
}
