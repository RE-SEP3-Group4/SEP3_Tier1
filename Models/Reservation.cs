using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEP3_Tier1.Models
{
    /// <summary>
    /// This class holds the information regarding gym reservation.
    /// Reservations contain the user id, a date string with the DDMMYYYY format, and a hour string with the format HHMM.
    /// Reservations are made in segments of one hour.
    /// </summary>
    [Serializable]
    public class Reservation
    {
        int userID { get; set; }
        string date { get; set; }
        string hour { get; set; }

        public Reservation() { }

        public Reservation(int userID, string date, string hour)
        {
            this.userID = userID;
            this.date = date;
            this.hour = hour;
        }
    }
}
