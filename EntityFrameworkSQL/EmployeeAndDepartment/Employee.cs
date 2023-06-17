using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndDepartment
{
    public class Employee
    {
        public uint EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public Department Department { get; set; }

    }
}
