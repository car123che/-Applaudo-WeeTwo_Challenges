namespace Challenge
{

    enum EmployeeType
    {
        Engineer,
        Salesman,
        Manager
    }


    class Employee
    {
        private int _employeeType;
        public double MonthlySalary { get; set; }
        public double Commission { get; set; }
        public double Bonus { get; set; }

        public Employee(int employeeType)
        {
            _employeeType = employeeType;
        }

        public double GetPaymentAmount()
        {
            switch (_employeeType)
            {
                case ((int)EmployeeType.Engineer):
                    return MonthlySalary;
                case ((int)EmployeeType.Salesman):
                    return MonthlySalary + Commission;
                case ((int)EmployeeType.Manager):
                    return MonthlySalary + Bonus;
                default:
                    throw new ArgumentException("Incorrect employee type", nameof(_employeeType));
            }
        }
    }

}