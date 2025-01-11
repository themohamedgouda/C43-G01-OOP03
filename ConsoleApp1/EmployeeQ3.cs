using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EmployeeQ3
    {
        // Properties for Employee class
        public string Name { get; set; }
        public string Position { get; set; }
        public string Permissions { get; set; }

        // Constructor to initialize Employee with Name, Position, and Permissions
        public EmployeeQ3(string name, string position, string permissions)
        {
            Name = name;
            Position = position;
            Permissions = permissions;
        }

        // Override ToString() to display Employee information
        public override string ToString()
        {
            return $"{Name} - {Position} - Permissions: {Permissions}";
        }
    }
}
