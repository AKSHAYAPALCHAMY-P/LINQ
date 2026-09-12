using LinqUtils.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToObjects
{
    public static class Filters
    {
        private static List<Employee> Employees = DataProvider.GetEmployees();

        public static void LinqWhere()
        {
            Console.WriteLine("-------------------------------");
            var LinqQuery = from employee in Employees where employee.Name.Equals("Bob Smith") select employee;

            foreach (var employee in LinqQuery)
            {
                Console.WriteLine($"Name:{employee.Name}, Team:{employee.Team};");
            }

            Console.WriteLine("-------------------------------");
            var LinqMethod = Employees.Where(x => x.Name.Equals("Diana Prince"));

            foreach (var employee in LinqMethod)
            {
                Console.WriteLine($"Name:{employee.Name}, Team:{employee.Team};");
            }

            var LinqMethods = Employees.Where(x => x.Name=="Diana Prince");

            foreach (var employee in LinqMethods)
            {
                Console.WriteLine($"Name:{employee.Name}, Team:{employee.Team};");
            }
        }

        public static void LinqOfType()
        {
            var Managers = Employees.OfType<Manager>();

            Console.WriteLine("-------------------Manager List----------------------");

            foreach(var employee in Managers)
            {
                Console.WriteLine($"Name:{employee.Name}, Team:{employee.Team}");
            }

            var securityEngineer = Employees.OfType<SecurityEngineer>();

            Console.WriteLine("-------------------Manager List----------------------");

            foreach (var Security in securityEngineer)
            {
                Console.WriteLine($"Name:{Security.Name}, Team:{Security.Team}");
            }
        }
    }
}
