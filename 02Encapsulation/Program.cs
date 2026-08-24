class Employee
{
    private string? name;
    private int age;
    public decimal Salary { get; private set; }

    public string? Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name is required...!");
            }
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 18)
            {
                throw new ArgumentException("Age should be greater than 18..!");
            }
            age = value;
        }
    }

    public Employee(string name, int age, decimal initialSalary)
    {
        Name = name;
        Age = age;

        if (initialSalary <= 0)
        {
            throw new ArgumentException("Initial salary should be greater than 0...!");
        }
        Salary = initialSalary;
    }

    public void GiveRaise(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Giveraise amount should be greater than 0...!");
        }
        Salary += amount;
    }

    public void DeductSalary(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deduct amount should be greater than 0....!");
        }
        else if (amount > Salary)
        {
            throw new ArgumentException("Deduct amount cannot be greater than current salary...!");
        }
        Salary -= amount;
    }

    public void DisplayDetails()
    {
        System.Console.WriteLine("\n---- Employee Details ----\n");

        System.Console.WriteLine("Employee Name : " + name);
        System.Console.WriteLine("Employee Age : " + age);
        System.Console.WriteLine("Employee Salary : " + Salary);
    }

}

class Test
{
    public static void Main()
    {
        Employee e = new Employee("Aniket", 24, 25000);

        e.DisplayDetails();

        // e.Salary = 10000;

        System.Console.WriteLine("Giving salary raise of 5000...!");
        e.GiveRaise(5000);
        System.Console.WriteLine("Updated salary is : " + e.Salary);

        System.Console.WriteLine("Deducting salary of 2000...!");
        e.DeductSalary(2000);
        System.Console.WriteLine("Updated salary is : " + e.Salary);

        e.DisplayDetails();
    }
}