namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employeewage program.");

            EmpWageBuilder empWageBuilder = new EmpWageBuilder();

            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
}