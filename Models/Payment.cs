using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEP3_Tier1.Models
{
    /// <summary>
    /// This class holds the information regarding gym payments.
    /// Payments contain the user id, a date integer with the ddmmyyhhmm format and a period of time it is valid for.
    /// </summary>
    public class Payment
    {
        int userID { get; set; }
        int date { get; set; }
        int period { get; set; }

        public Payment() { }

        public Payment(int userID, int date, int period)
        {
            this.userID = userID;
            this.date = date;
            this.period = period;
        }
    }
}
