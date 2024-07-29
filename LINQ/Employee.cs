using System;
using System.Collections.Generic;

namespace LINQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public IEnumerable<Employee> getEmployee()
        {
            return new List<Employee>()
            {
                new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 60000, HireDate = new DateTime(2020, 1, 15) },
                new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 75000, HireDate = new DateTime(2019, 7, 22) },
                new Employee { Id = 3, Name = "Charlie", Department = "Finance", Salary = 80000, HireDate = new DateTime(2021, 3, 10) },
                new Employee { Id = 4, Name = "David", Department = "Marketing", Salary = 55000, HireDate = new DateTime(2022, 5, 25) },
                new Employee { Id = 5, Name = "Eva", Department = "Sales", Salary = 70000, HireDate = new DateTime(2018, 11, 30) },
                new Employee { Id = 6, Name = "Frank", Department = "IT", Salary = 72000, HireDate = new DateTime(2021, 8, 12) },
                new Employee { Id = 7, Name = "Grace", Department = "HR", Salary = 65000, HireDate = new DateTime(2020, 2, 20) },
                new Employee { Id = 8, Name = "Hannah", Department = "Finance", Salary = 85000, HireDate = new DateTime(2019, 9, 5) },
                new Employee { Id = 9, Name = "Ian", Department = "Marketing", Salary = 58000, HireDate = new DateTime(2022, 6, 15) },
                new Employee { Id = 10, Name = "Jack", Department = "Sales", Salary = 72000, HireDate = new DateTime(2017, 12, 22) }
            };
        }


    }

}
