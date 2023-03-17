# Challenge 5
How would you Improve the maintability of the following code:

``` Csharp
  class Employee
    {
        private int _type;
        static final int ENGINEER = 0;
        static final int SALESMAN = 1;
        static final int MANAGER = 2;
        public double MonthlySalary { get; set; }
        public double Commission { get; set; }
        public double  Bonus { get; set; }

        public Employee(int type)
        {
            _type = type;
        }

        public int GetPaymentAmount()
        {
            switch (_type)
            {
                case 0:
                    return MonthlySalary;
                case 1:
                    return MonthlySalary + Commission;
                case 2:
                    return MonthlySalary + Bonus;
                default:
                    throw new RuntimeException("Incorrect Employee");
            }
        }
    }

```

## Changes Description 
* Use an enum instead of static fianal fields to represent the different employee types. This would make the code more readable and less error-prone.

Enum:

``` Csharp
enum EmployeeType
{
    Engineer,
    Salesman,
    Manager
}
```
* Change the `_type` variable name because it is not very descriptive. Use `_employeeType` instead.
  * Also for the name `type` parameter in the constructor change it to `employeeType`.
* Change the return type of GetPaymentAmount() from `int` to `double` beacuse there are some convertions mistakes in the returns of the method.
* Use the enum values for the switch cases instead of the magin numbers `case 0, case 1, case 2`.
* The code currently throws a RuntimeException if the employee type is incorrect. It's better to use an ArgumentException instead, which is more specific and provides more information about the error.


## Final Code
``` Csharp
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
```