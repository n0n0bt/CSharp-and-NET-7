﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_20_05
{
    public class Employee
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; } 

        public List<Employee>? Subordinared { get; set; }

        public Employee() { }
    }
}
