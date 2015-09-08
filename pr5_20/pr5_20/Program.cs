using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee();
            string firstName;
            string lastName;
            decimal numberOfHoursWorked;
            decimal hourlyRate;

            Console.WriteLine("-----  Constructor using String, String, Decimal, Decimal --------");

            Console.Write("Enter Employee First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter Employee Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter Employee Hours Worked: ");
            numberOfHoursWorked = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Employee Hours Rate: ");
            hourlyRate = Convert.ToDecimal(Console.ReadLine());
            Employee emp1 = new Employee(firstName, lastName, numberOfHoursWorked, hourlyRate);

            //Employee emp1 = new Employee("Steve", "Jobs", 45, 10.01m);
            Console.WriteLine("\nEmployee First Name: {0}\n", emp1.FirstName);
            Console.WriteLine("Employee Last Name: {0}\n", emp1.LastName);
            Console.WriteLine("Employee Hours Worked That Week: {0}\n", emp1.HoursWorkedThisWeek);
            Console.WriteLine("Employee Hours Worked over 40: {0}\n", emp1.HoursOverFourty);
            Console.WriteLine("Employee Hourly Rate: {0}\n",  emp1.HourlyRate);
            Console.WriteLine("Employee Gross Pay: {0:C}\n", emp1.GrossPay);

            Console.WriteLine("Hit enter to continue.");

            Console.ReadLine();
        }
    }
}
