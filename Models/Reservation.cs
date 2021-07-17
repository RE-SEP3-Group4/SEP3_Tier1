using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEP3_Tier1.Models
{
    public class Reservation
    {
        public int userId { get; set; }
        public int date { get; set; }

        public Reservation() { }

        public Reservation(int userId, int date)
        {
            this.userId = userId;
            this.date = date;
        }
    }
}
