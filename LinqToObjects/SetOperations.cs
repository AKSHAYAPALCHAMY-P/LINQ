using LinqUtils.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToObjects
{
    public class SetOperations
    {
        private static List<int> Numbers = DataProvider.Numbers;
        private static List<Employee> Employees = DataProvider.GetEmployees();
        private static string[] Box1 = DataProvider.Box1;
        private static string[] Box2 = DataProvider.Box2;

        public static void DistinctOperator()
        {
            foreach (int i in Numbers)
            {
                Console.Write(i + '|');
            }
            // Query Syntax
            Console.WriteLine("-----------Query Syntax---------");

            var NumberQuery = (from n in Numbers select n).Distinct();
            foreach (var n in NumberQuery) { Console.Write(n + "|"); }


            // Query Method
            Console.WriteLine("-----------Query Method---------");
            var NumberLinqmethod = Numbers.Distinct().Select(x => x);
            foreach (var n in NumberLinqmethod) { Console.Write(n + "|"); }
        }

        public static void DistinctByOperator()
        {

            // Query Syntax
            Console.WriteLine("-----------Query Syntax---------");
            var LinqQuery = (from employee in Employees select employee).DistinctBy(x => x.Id);
            foreach (var employee in LinqQuery)
            {
                Console.WriteLine($"Name:{employee.Name}, Team:{employee.Id}");
            }

            // Query Method
            Console.WriteLine("-----------Query Method---------");
            var LinqMethod = Employees.DistinctBy(x => x.Id);
            foreach (var employee in LinqMethod)
            {
                Console.WriteLine($"Name:{employee.Name}, Team:{employee.Id}");
            }
        }
    }
}
