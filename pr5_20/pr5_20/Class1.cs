using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_20
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private decimal hoursWorkedThisWeek;
        private decimal hourlyRate;
        private decimal hoursOverFourty;
        private decimal grossPay; 

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal HoursWorkedThisWeek
        {
            get
            {
                return hoursWorkedThisWeek;
            }
            set
            {
                if (value >= 40.0m)
                {
                    HoursOverFourty = value - 40.0m;
                    hoursWorkedThisWeek = 40;                 
                }
                else
                {
                    HoursOverFourty = 0;
                    hoursWorkedThisWeek = value;
                } 
            }
        }
        public decimal HourlyRate { get; set; }

        public decimal HoursOverFourty { get; private set; }

        public decimal GrossPay
        {
            get
            {
                grossPay = HoursWorkedThisWeek * HourlyRate + HoursOverFourty * 1.5m * HourlyRate;
                return grossPay;
            }
            private set
            {
                
            }
        }

        public Employee(string firstName, string lastName, decimal hoursWorkedThisWeek, decimal hourlyRate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.HoursWorkedThisWeek = hoursWorkedThisWeek;
            this.HourlyRate = hourlyRate;
        }
    }
}
