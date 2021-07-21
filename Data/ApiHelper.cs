using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SEP3_Tier1.Data
{
    /// <summary>
    /// This class is used to create and allow an HTTP client to be called when needed.
    /// </summary>
    public sealed class ApiHelper
    {
        private static HttpClient ApiClient = null;

        /// <summary>
        /// This method initialises the HTTP client if it has not been initialised before and returns it.
        /// </summary>
        public static HttpClient GetApiClient()
        {
            if (ApiClient == null)
            {
                ApiClient = new HttpClient();
                ApiClient.BaseAddress = new Uri("http://localhost:8080");
                ApiClient.DefaultRequestHeaders.Accept.Clear();
                ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("aplication/json"));
            }
            return ApiClient;
        }
    }
}
