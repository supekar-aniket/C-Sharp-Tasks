class BankAccount
{
    private string? name;
    private int age;
    private decimal balance;

    public string? Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name is required...!");
            }
            else
            {
                name = value;
            }
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be negative or 0...!");
            }
            else
            {
                age = value;
            }

        }
    }

    public decimal Balance
    {
        get { return balance; }
    }

    // This is constructor for set initial balance
    protected BankAccount(decimal initialBalance)
    {
        if (initialBalance <= 0)
        {
            throw new ArgumentException("Initial balance should be greater than 0...!");
        }
        else
        {
            balance = initialBalance;
        }
    }

    internal void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount should be greater than 0...!");
        }
        else
        {
            balance += amount;
        }
    }

    internal void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount should be greater than 0...!");
        }
        else if (amount > balance)
        {
            throw new ArgumentException("Balance is not sufficient...!");
        }
        else
        {
            balance -= amount;
        }

    }

}

class SavingAccount : BankAccount
{
    internal SavingAccount(decimal initialBalance)
        : base(initialBalance)
    {

    }

    public string? AccountType
    {
        get { return "Savings"; }
    }
}

class CurrentAccount : BankAccount
{
    internal CurrentAccount(decimal initialBalance)
            : base(initialBalance)
    {

    }

    public string? AccountType
    {
        get { return "Current"; }
    }
}

class Test
{
    public static void Main()
    {
        System.Console.WriteLine("-- Transaction Open --");

        SavingAccount s1 = new SavingAccount(45000);
        s1.Name = "Aniket";
        s1.Age = 30;

        System.Console.WriteLine("\nAccountHolder Name :" + s1.Name);
        System.Console.WriteLine("Account Type :" + s1.AccountType);
        System.Console.WriteLine("Age :" + s1.Age);
        System.Console.WriteLine("Inital Balance :" + s1.Balance);

        s1.Withdraw(35000);
        System.Console.WriteLine("Balance After Withdraw:" + s1.Balance);

        s1.Deposit(15000);
        System.Console.WriteLine("Balance After Deposit:" + s1.Balance);

        CurrentAccount c1 = new CurrentAccount(40000);
        c1.Name = "Vedant";
        c1.Age = 25;

        System.Console.WriteLine("\nAccountHolder Name :" + c1.Name);
        System.Console.WriteLine("Account Type :" + c1.AccountType);
        System.Console.WriteLine("Age :" + c1.Age);
        System.Console.WriteLine("Inital Balance :" + c1.Balance);

        c1.Withdraw(35000);
        System.Console.WriteLine("Balance After Withdraw:" + c1.Balance);

        c1.Deposit(15000);
        System.Console.WriteLine("Balance After Deposit:" + c1.Balance);

    }
}