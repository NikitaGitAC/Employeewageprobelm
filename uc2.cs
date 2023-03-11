namespace EmployeeWageComputataionProblem
{
    public class EmployeeCheck
    {

        public static void EmployeeAttendence()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
    
