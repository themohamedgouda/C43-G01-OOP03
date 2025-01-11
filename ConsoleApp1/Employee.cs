using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{   // Enum for Security Levels
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    public class Employee
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        private string gender;

        // Property to ensure gender is restricted to "M" or "F"
        public string Gender
        {
            get => gender;
            set
            {
                if (value == "M" || value == "F")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
                }
            }
        }

        // Constructor
        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, DateTime hireDate, string gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        // Overriding ToString() method to represent employee data in string form using String.Format()
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "ID: {0}, Name: {1}, Security Level: {2}, Salary: ${3:C}, Hire Date: {4:yyyy-MM-dd}, Gender: {5}",
                                    ID, Name, SecurityLevel, Salary, HireDate, Gender);
        }

   
    }
}