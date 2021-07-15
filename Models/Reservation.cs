using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEP3_Tier1.Models
{
    /// <summary>
    /// This class holds the information regarding gym reservation.
    /// Reservations contain the user id and a date integer with the ddmmyyhhmm format.
    /// Reservations are made in segments of one hour.
    /// </summary>
    public class Reservation
    {
        int userID { get; set; }
        int date { get; set; }

        public Reservation() { }

        public Reservation(int userID, int date)
        {
            this.userID = userID;
            this.date = date;
        }
    }
}
