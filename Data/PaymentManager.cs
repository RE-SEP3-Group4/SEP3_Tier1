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
    /// This is class is used for the comunication with the second tier regarding the Payment class.
    /// </summary>
    public class PaymentManager
    {
        private static readonly string url = "http://localhost:8080";

        /// <summary>
        /// This method gets the payments for a specific user.
        /// </summary>
        /// <param name="userID">This is the id of the user who we are tring to get the payments.</param>
        /// <returns>A list of reservations.</returns>
        public static async Task<List<Payment>> GetPayments(int userID)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"{url}/payment?userID={userID}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Payment>>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// This method creates a payment.
        /// </summary>
        /// <param name="userID">The id of the user that is going to use the payment.</param>
        /// <param name="date">Date is integer with the ddmmyyhhmm format.</param>
        /// <param name="period">Period is the period of time the payment is valid for.</param>
        /// <returns>A boolean that is true if the command was successful.</returns>
        public static async Task<bool> CreatePayment(int userID, string startDate, string endDate)
        {
            Payment payment = new Payment(userID, startDate, endDate);
            string jsonPayment = Newtonsoft.Json.JsonConvert.SerializeObject(payment);
            StringContent content = new StringContent(jsonPayment, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync($"{url}/payment", content))
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
