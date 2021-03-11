using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaniuEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Kazeem", "Ganiu", 300000m);
            Employee employee2 = new Employee("Sabitu", "Olaiya", 1000000m);

            Console.WriteLine("Employee1 Name is: {0} {1}", employee1.FirstName, employee1.LastName);
            Console.WriteLine("Employee1 Monthly Salary is: N{0}", employee1.Salary);
            employee1.Salary = employee1.Salary * 12;
            Console.WriteLine("Employee1 yearly salary is: N{0}", employee1.Salary);

            Console.WriteLine("Employee2 Name is: {0} {1}", employee2.FirstName, employee2.LastName);
            Console.WriteLine("Employee2 Monthly Salary is: N{0}", employee2.Salary);
            employee2.Salary = employee2.Salary * 12;
            Console.WriteLine("Employee2 yearly salary is: N{0}", employee2.Salary);


            Console.WriteLine();
            Console.WriteLine("After 10% increment");

            employee1.Salary = employee1.Salary * 1.1M;
            employee2.Salary = employee2.Salary * 1.1M;

            Console.WriteLine("Employee1 new Salary is: N{0}", employee1.Salary);
            Console.WriteLine("Employee2 new Salary is: N{0}", employee2.Salary);


            Console.ReadKey();
        }
    }
}
