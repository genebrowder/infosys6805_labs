using System;

namespace pr4_13
{
    public class EmployeeTest
    {
        public EmployeeTest()
        {
        }

        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            Console.WriteLine("----- Default Constructor --------");
            Console.WriteLine("Employee First Name: {0}", emp1.FirstName);
            Console.WriteLine("Employee Last Name: {0}", emp1.LastName);
            Console.WriteLine("Employee Yearly Salary: {0:C}\n", 12*emp1.MonthlySalary);

            Console.WriteLine("----- Negative Monthly Salary --------");
            emp1.MonthlySalary = -100.00m;
            Console.WriteLine("Monthly Salary : {0}", emp1.MonthlySalary);
            Console.WriteLine("Employee First Name: {0}", emp1.FirstName);
            Console.WriteLine("Employee Last Name: {0}", emp1.LastName);
            Console.WriteLine("Employee Yearly Salary: {0:C}\n", 12 * emp1.MonthlySalary);

            Console.WriteLine("-----  Constructor using String, String, Decimal --------");
            Employee emp2 = new Employee("Steve","Jobs",1000);
            Console.WriteLine("Employee First Name: {0}", emp2.FirstName);
            Console.WriteLine("Employee Last Name: {0}", emp2.LastName);
            Console.WriteLine("Employee Yearly Salary: {0:C}\n", 12 * emp2.MonthlySalary);

            //Give Raise
            Console.WriteLine("-----  Give 10% Raise - emp1 --------");
            emp1.MonthlySalary = emp1.MonthlySalary + Decimal.Multiply(.1m, emp1.MonthlySalary);
            Console.WriteLine("Employee First Name: {0}", emp1.FirstName);
            Console.WriteLine("Employee Last Name: {0}", emp1.LastName);
            Console.WriteLine("Employee Yearly Salary: {0:C}\n", 12 * emp1.MonthlySalary);

            Console.WriteLine("-----  Give 10% Raise - emp2 --------"); 
            emp2.MonthlySalary = emp2.MonthlySalary + Decimal.Multiply(.1m, emp2.MonthlySalary);
            Console.WriteLine("Employee First Name: {0}", emp2.FirstName);
            Console.WriteLine("Employee Last Name: {0}", emp2.LastName);
            Console.WriteLine("Employee Yearly Salary: {0:C}\n", 12 * emp2.MonthlySalary);


            Console.WriteLine("Hit enter to continue.");

            Console.ReadLine();
        }
    }
}
