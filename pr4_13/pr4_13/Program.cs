using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_13
{
    class Employee
    {
        private String firstName;
        private String lastName;
        private Decimal monthlySalary;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal MonthlySalary {
            get
            {
                return monthlySalary;
            } 
            set{
                if (value >= 0)
                {
                    monthlySalary = value;
                }
            }
        }

        public void printEmployee(){

        }
        
        public Employee(String firstName, String lastName, Decimal monthlySalary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MonthlySalary = monthlySalary;
        }
        public Employee(String firstName, String lastName, String monthlySalary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MonthlySalary = Convert.ToDecimal( monthlySalary );
        }
        public Employee()
        {
            this.FirstName = "Bill";
            this.LastName = "Gates";
            this.MonthlySalary = 1000000.00M;
        }
        
       
    }
}
