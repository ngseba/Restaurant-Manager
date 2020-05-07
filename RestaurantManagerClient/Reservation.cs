using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagerClient
{
    public class Reservation
    {
        public int ReservationId;
        public DateTime ReservationDate;
        public TimeSpan ReservationTime;
        public int PartySize;
        public string ReservationDetails;
        public int ClientId;
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
    }
}
