using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeRoll
    {
        const int Is_FULL_TIME = 0, IS_PART_TIME = 1, Wage_PER_HR = 20, FULL_TIME_HR = 8, PART_TIME = 4;
        int totalEmpWage = 0, empHrs = 0;
        public void SwitchCase()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_FULL_TIME)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void CalculateEmpWge()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            switch (empCheck)
            {
                case  Is_FULL_TIME:
                    empHrs = FULL_TIME_HR;
                break;
                case IS_PART_TIME:
                    empHrs = PART_TIME;
                break;
            }
            totalEmpWage = Wage_PER_HR * empHrs;
            Console.WriteLine(totalEmpWage);
        }
    }
}
