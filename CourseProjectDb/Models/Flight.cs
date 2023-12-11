using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectDb.Models
{
    public class Flight
    {
        public int ID { get; set; }
        public string DepartureDays { get; set; }
        public int AirplaneId { get; set; }
        public int BrigadeId { get; set; }
        public Airplane Airplane { get; set; }
        public Brigade Brigade { get; set; }
        public FlightType FlightType { get; set; }
        public int FlightTypeId { get; set; }
        public TimeSpan TimeOfDeparture { get; set; }
        public TimeSpan TimeOfArrival { get; set; }
        public string Route { get; set; }
        public int FlightId { get; set; }
    }
}
