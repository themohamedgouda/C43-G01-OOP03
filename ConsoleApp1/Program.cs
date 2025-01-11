namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] .args)
        {
            #region Q1
            //try
            //{
            //    Employee emp = new Employee(1, "Sama", SecurityLevel.Developer, 80000, DateTime.Parse("2022-05-15"), "F");
            //    Console.WriteLine(emp.ToString());

            //    Employee emp2 = new Employee(2, "Mohamed", SecurityLevel.DBA, 95000, DateTime.Parse("2020-11-10"), "M");
            //    Console.WriteLine(emp2.ToString());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //} 
            #endregion
            #region Q2
            //HiringDate hireDate = new HiringDate(15, 5, 2022);
            //Console.WriteLine("Hiring Date: " + hireDate.ToString());
            #endregion
            #region Q3
            //try
            //{
            //    EmployeeQ3[] EmpArr = new EmployeeQ3[3];

            //    EmpArr[0] = new EmployeeQ3("Mohamed", "DBA", "Read/Write");
            //    EmpArr[1] = new EmployeeQ3("Abdelgayed", "Guest", "Read Only");
            //    EmpArr[2] = new EmployeeQ3("Abdalla", "Security Officer", "Full Access");

            //    Console.WriteLine("Employee Information:");
            //    foreach (var emp in EmpArr)
            //    {
            //        Console.WriteLine(emp);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //}
            #endregion
            #region Q4
            //    EmployeeQ4[] employees = new EmployeeQ4[]
            //{
            //    new EmployeeQ4("Alice", new DateTime(2022, 1, 15)),
            //    new EmployeeQ4("Bob", new DateTime(2021, 6, 25)),
            //    new EmployeeQ4("Charlie", new DateTime(2023, 3, 10))
            //};

            //    int boxingCount = 0;
            //    int unboxingCount = 0;
            //    // Sorting the array based on hire date using manual comparison
            //    for (int i = 0; i < employees.Length - 1; i++)
            //    {
            //        for (int j = i + 1; j < employees.Length; j++)
            //        {
            //            // Boxing and unboxing happens when comparing values that are of value types (DateTime in this case)
            //            if (employees[i].HireDate > employees[j].HireDate)
            //            {
            //                EmployeeQ4 temp = employees[i];
            //                employees[i] = employees[j];
            //                employees[j] = temp;

            //                // Track boxing and unboxing
            //                boxingCount++;
            //                unboxingCount++;
            //            }
            //        }
            //    }
            //    // Print the sorted array and boxing/unboxing count
            //    Console.WriteLine("Sorted Employees by Hire Date:");
            //    foreach (var employee in employees)
            //    {
            //        Console.WriteLine($"{employee.Name} - {employee.HireDate.ToShortDateString()}");
            //    }

            //    Console.WriteLine($"Boxing Count: {boxingCount}");
            //    Console.WriteLine($"Unboxing Count: {unboxingCount}");

            #endregion
            #region Q5
            //// Creating an EBook instance
            //EBook eBook = new EBook("Digital Fortress", "Dan Brown", "978-0446579903", 1.2);
            //eBook.DisplayInfo();
            //Console.WriteLine();

            //// Creating a PrintedBook instance
            //PrintedBook printedBook = new PrintedBook("The Da Vinci Code", "Dan Brown", "978-0307474278", 454);
            //printedBook.DisplayInfo();
            #endregion

        }
    }
}
