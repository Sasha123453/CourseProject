using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectDb.Models
{
    public class Brigade
    {
        public int Id { get; set; }
        public string BrigadeName { get; set; }
        public int DepartmentId { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
