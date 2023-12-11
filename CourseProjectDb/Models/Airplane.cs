using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectDb.Models
{
    public class Airplane
    {
        public int Id { get; set; }
        public AirplaneType AirplaneType { get; set; }
        public int AirplaneTypeId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfArrival { get; set; }
    }
}
