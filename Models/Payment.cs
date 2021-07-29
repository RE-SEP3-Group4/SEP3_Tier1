using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEP3_Tier1.Models
{
    /// <summary>
    /// This class holds the information regarding gym payments.
    /// Payments contain the user id and startDate and a endDate sting with the DDMMYYYY format.
    /// </summary>
    [Serializable]
    public class Payment
    {
        public int userID { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }

        public Payment() { }

        public Payment(int userID, string startDate, string endDate)
        {
            this.userID = userID;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
