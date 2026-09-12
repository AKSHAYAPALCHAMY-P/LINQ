using LinqUtils.Models;
using LinqUtils.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToObjects
{
    public static class ProjectionOperations
    {
        // get Data
        private static List<Employee> Employees = DataProvider.GetEmployees();

        public static void SelectOperator()
        {
            // Query Syntax
            Console.WriteLine("-----------Query Syntax---------");
            //var linqQuery = from employee in Employees where employee.Team  == Team.DevOps
            //                select (employee.Id , employee.Name);

            var linqQuery = from employee in Employees
                            where employee.Team == Team.DevOps
                            select new
                            {
                                Id = employee.Id,//Anonymous type
                                Name = employee.Name,
                            };

            foreach (var employee in Employees)
            {
                Console.WriteLine($"Name:{employee.Name}, Team:{employee.Id}");
            }

            // Query Method
            Console.WriteLine("-----------Query Method---------");

            var LinqMethod = Employees.Where(employee => employee.Team == Team.DevOps).Select(employee => new
            {
                Id = employee.Id,
                Name = employee.Name,
            });

            foreach (var employee in Employees)
            {
                Console.WriteLine($"Name:{employee.Name}, Team:{employee.Id}");
            }
        }

        public static void SelectManyOperator() //used when nested collections
        {

            // Query Syntax
            Console.WriteLine("-----------Query Syntax---------");
            var LinqQuery = from Employee in Employees
                            where Employee.Team == Team.ResearchAndDevelopment
                            from e in Employee.Name.ToArray()
                            select e;

            foreach (var x in LinqQuery)
            {
                Console.Write($"{x} |");
            }

            // Query Method
            Console.WriteLine("-----------Query Method---------");

            var Linqmethod = Employees.Where(x=> x.Team == Team.ResearchAndDevelopment).SelectMany(employee => employee.Name.ToArray());

            foreach (var x in LinqQuery)
            {
                Console.Write($"{x} |");
            }
        }

        public static void ZipOperator()
        {
            var topEmployee = Employees.Take(5);

            var Salaries = new List<decimal> { 5000, 6000, 5500, 7000, 6500 };

            var EmployeeWithSalary = topEmployee.Zip(Salaries, (emp, sal) => new
            {
                Name = emp.Name,
                Team = emp.Team,
                Salaries = sal
            });

            foreach (var emp in EmployeeWithSalary) { Console.WriteLine($"{emp.Name}, Team: {emp.Team}, Salary: {emp.Salaries}"); }
        }
    }
}
