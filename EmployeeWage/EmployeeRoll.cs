using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeRoll
    {
        const int Is_FULL_TIME = 0, Wage_PER_HR = 20, FULL_TIME_HR = 8;

        public void CalculateEmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_FULL_TIME)
            {
                int totalEmpWage = Wage_PER_HR * FULL_TIME_HR;
                Console.WriteLine(totalEmpWage);

            }
        }
    }
}
