using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EmployeeQ4
    {
        public string Name { get; set; }
        public DateTime HireDate { get; set; }

        public EmployeeQ4(string name, DateTime hireDate)
        {
            Name = name;
            HireDate = hireDate;
        }
    }
}
